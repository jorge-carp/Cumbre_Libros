using Cumbre_Libros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cumbre_Libros
{
    public partial class Reporte : UserControl
    {
        private CumbreContext _context = new CumbreContext();
        private int _idUsuario = -1;

        public Reporte()
        {
            InitializeComponent();

            cbUsuarios.DataSource = _context.Usuarios
                .Where(u => u.IdRol == 3)
                .Select(u => u.Apellido + " " + u.Nombre)
                .ToList();

            cbUsuarios.SelectedIndex = -1;

            cbUsuarios.DropDownStyle = ComboBoxStyle.DropDown;
            cbUsuarios.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbUsuarios.AutoCompleteSource = AutoCompleteSource.ListItems;

            dgvVentas.DataSource = _context.VentasCabeceras
                .Where(v => !v.Eliminado)
                .Select(v => new
                {
                    v.Id,
                    v.IdUsuarioNavigation.Apellido,
                    v.IdUsuarioNavigation.Nombre,
                    v.Fecha,
                    v.TotalVenta
                })
                .ToList();
        }

        private void dtHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtHasta.Value < dtDesde.Value)
            {
                MessageBox.Show("Las fechas no son válidas.");
                return;
            }

            if (_idUsuario == -1)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            DateTime desde = dtDesde.Value.Date;
            DateTime hasta = dtHasta.Value.Date;

            var lista_ventas = _context.VentasCabeceras
                .Where(v => !v.Eliminado && v.Fecha >= desde && v.Fecha <= hasta && v.IdUsuario == _idUsuario)
                .Select(v => new
                {
                    v.Id,
                    v.IdUsuarioNavigation.Apellido,
                    v.IdUsuarioNavigation.Nombre,
                    Fecha = v.Fecha.ToString("dd-MM-yyyy HH:mm:ss"),
                    Total = v.TotalVenta.ToString("N0"),
                })
                .ToList();

            //using StreamWriter writer = new StreamWriter("debug_report.txt");
            //writer.WriteLine($"Ventas para usuario {_idUsuario} desde {desde} hasta {hasta}: {lista_ventas.Count} registros.\n");

            dgvVentas.DataSource = lista_ventas;

            // 3) Clear and prepare chart
            chartVentas.Series.Clear();
            chartVentas.ChartAreas.Clear();

            var area = new ChartArea("VentasArea");
            area.AxisX.Title = "Fecha";
            area.AxisY.Title = "Total de Ventas";
            area.AxisX.LabelStyle.Format = "yyyy-MM-dd";
            area.AxisX.IntervalType = DateTimeIntervalType.Days;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisX.Interval = 1;               // one tick per day
            area.AxisX.LabelStyle.Angle = -45;
            chartVentas.ChartAreas.Add(area);


            // 4) Create series
            var series = new Series("Ventas")
            {
                ChartType = SeriesChartType.Column, // or Line
                XValueType = ChartValueType.DateTime,
                IsValueShownAsLabel = true
            };

            int days = (hasta - desde).Days + 1;
            var start = desde;
            // 5) Add a point for each day in the range (fill zeros if missing)
            for (int i = 0; i < days; i++)
            {
                var dt = start.AddDays(i);
                //double total = lookup.TryGetValue(dateOnly, out var t) ? t : 0.0;

                var total = lista_ventas.Where(v => DateOnly.ParseExact(v.Fecha.Substring(0, 10), "dd-MM-yyyy", null) == DateOnly.FromDateTime(dt))
                    .Sum(v => double.Parse(v.Total));
                //writer.WriteLine($"i = {i}, X = {dt}, Y = {total}");

                // Use DateTime for X
                series.Points.AddXY(dt, total);
            }

            chartVentas.Series.Add(series);

            var resultado = _context.VentasDetalles
                .Include(v => v.IdVentaNavigation)
                .Include(v => v.IdProductoNavigation)
                .Where(v =>
                    v.IdVentaNavigation.Fecha >= desde &&
                    v.IdVentaNavigation.Fecha <= hasta &&
                    v.IdVentaNavigation.IdUsuario == _idUsuario)
                .GroupBy(v => new
                {
                    v.IdProducto,
                    v.IdProductoNavigation.Titulo
                })
                .Select(g => new
                {
                    Producto = g.Key.Titulo,
                    TotalVendido = g.Sum(x => x.Cantidad)
                })
                .OrderByDescending(x => x.TotalVendido)
                .FirstOrDefault();

            lTotal.Text = $"Total: ${lista_ventas.Sum(v => double.Parse(v.Total)).ToString("N2")}";
            lLibro.Text = $"Producto más vendido: {resultado.Producto}, {resultado.TotalVendido} veces";

            // 6) Optional nice formatting
            //series.LabelFormat = "C"; // currency
            series.Color = Color.DodgerBlue;
        }

        private void cbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUsuarios.SelectedIndex != -1)
            {
                _idUsuario = _context.Usuarios
                    .Where(u => (u.Apellido + " " + u.Nombre) == cbUsuarios.SelectedItem.ToString())
                    .Select(u => u.Id)
                    .FirstOrDefault();
            }
        }

        private async void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvVentas.Columns[e.ColumnIndex].Name == "Factura")
            {
                int idVenta = (int)dgvVentas.Rows[e.RowIndex].Cells["Id"].Value;
                var venta = _context.VentasCabeceras
                    .FirstOrDefault(v => v.Id == idVenta);
                var detalles = _context.VentasDetalles
                    .Include(d => d.IdProductoNavigation)
                    .Where(d => d.IdVenta == idVenta)
                    .ToList();

                if (venta != null)
                {
                    var factura = new Factura(_context, new BindingList<VentasDetalle>(detalles), venta);
                    await factura.GenerarFactura();
                }
            }
            else if (dgvVentas.Columns[e.ColumnIndex].Name == "Anular")
            {
                var transaction = _context.Database.BeginTransaction();

                int idVenta = (int)dgvVentas.Rows[e.RowIndex].Cells["Id"].Value;
                var venta = _context.VentasCabeceras
                    .FirstOrDefault(v => v.Id == idVenta);

                try
                {
                    if (venta != null)
                    {
                        var confirmResult = MessageBox.Show("¿Está seguro de que desea anular esta venta?",
                                             "Confirmar anulación",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Information);

                        if (confirmResult == DialogResult.Yes)
                        {
                            var detalles = _context.VentasDetalles
                                .Where(d => d.IdVenta == idVenta)
                                .ToList();

                            var n_credito = new VentasCabecera
                            {
                                IdUsuario = venta.IdUsuario,
                                IdMetodoPago = venta.IdMetodoPago,
                                TotalVenta = venta.TotalVenta
                            };

                            _context.VentasCabeceras.Add(n_credito);
                            _context.SaveChanges();

                            foreach (var detalle in detalles)
                            {
                                var n_detalle = new VentasDetalle
                                {
                                    IdVenta = n_credito.Id,
                                    IdProducto = detalle.IdProducto,
                                    Cantidad = detalle.Cantidad,
                                    Precio = detalle.Precio,
                                    Total = detalle.Total
                                };
                                _context.VentasDetalles.Add(n_detalle);
                                var producto = _context.Libros
                                    .FirstOrDefault(p => p.Id == detalle.IdProducto);
                                if (producto != null)
                                {
                                    producto.Stock += detalle.Cantidad;
                                }
                            }

                            venta.Eliminado = true;
                            _context.SaveChanges();
                            transaction.Commit();

                            var factura = new Factura(_context, new BindingList<VentasDetalle>(detalles), venta, n_credito);
                            await factura.GenerarFactura();

                            MessageBox.Show("La venta ha sido anulada.", "Confirmar anulación",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    MessageBox.Show("La venta no se pudo anular.", "Confirmar anulación",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    throw;
                }
            }
        }

        private void cbEliminados_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEliminados.Checked)
            {
                dgvVentas.DataSource = _context.VentasCabeceras
                    .Where(v => v.Eliminado)
                    .Select(v => new
                    {
                        v.Id,
                        v.IdUsuarioNavigation.Apellido,
                        v.IdUsuarioNavigation.Nombre,
                        v.Fecha,
                        v.TotalVenta
                    })
                    .ToList();
                dgvVentas.Columns["Anular"].Visible = false;
            }
            else
            {
                dgvVentas.DataSource = _context.VentasCabeceras
                    .Where(v => !v.Eliminado)
                    .Select(v => new
                    {
                        v.Id,
                        v.IdUsuarioNavigation.Apellido,
                        v.IdUsuarioNavigation.Nombre,
                        v.Fecha,
                        v.TotalVenta
                    })
                    .ToList();
                dgvVentas.Columns["Anular"].Visible = true;
            }
        }

        private void dgvVentas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvVentas.Columns["Factura"].DisplayIndex = dgvVentas.ColumnCount - 1;
            dgvVentas.Columns["Anular"].DisplayIndex = dgvVentas.ColumnCount - 1;

            foreach (DataGridViewColumn column in dgvVentas.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
