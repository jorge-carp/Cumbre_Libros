using Cumbre_Libros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WkHtmlToPdfDotNet;
using WkHtmlToPdfDotNet.Contracts;
using PuppeteerSharp;
using PuppeteerSharp.Media;
using System.Threading.Tasks;

namespace Cumbre_Libros
{
    public partial class Caja : UserControl
    {
        private CumbreContext _context = new CumbreContext();
        private int _ID_Usuario;
        private BindingList<VentasDetalle> _carrito = new BindingList<VentasDetalle>();
        private BindingList<LibrosView> _libros;

        public class LibrosView
        {
            public int ID { get; set; }
            public long ISBN { get; set; }
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public string Categoria { get; set; }
            public string Editorial { get; set; }
            public string Idioma { get; set; }
            public string Fecha_publicacion { get; set; }
            public double Precio { get; set; }
            public int Stock { get; set; }
            public int StockMinimo { get; set; }
            public bool Eliminado { get; set; }
        }

        public Caja(int ID)
        {
            InitializeComponent();
            _ID_Usuario = ID;

            _context.Libros.Load();

            var categorias = _context.Categorias
                .Where(c => !c.Eliminado)
                .OrderBy(c => c.Descripcion)
                .ToList();

            cbGenero.DataSource = categorias;
            cbGenero.DisplayMember = "Descripcion";
            cbGenero.ValueMember = "Descripcion";

            var titulos = _context.Libros
                .Where(l => !l.Eliminado)
                .Select(l => l.Titulo)
                .ToList();

            var autoSource = new AutoCompleteStringCollection();
            autoSource.AddRange(titulos.ToArray());

            tBuscar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tBuscar.AutoCompleteCustomSource = autoSource;

            cbMetodos.DataSource = _context.MetodosPagos.Select(m => m.Descripcion).ToList();
            cbMetodos.SelectedIndex = -1;

            var libros = _context.Libros
                .Include(l => l.IdAutorNavigation)
                .Include(l => l.IdCategoriaNavigation)
                .Include(l => l.IdEditorialNavigation)
                .Include(l => l.IdIdiomaNavigation)
                .Select(l => new LibrosView
                {
                    ID = l.Id,
                    ISBN = l.Isbn,
                    Titulo = l.Titulo,
                    Autor = l.IdAutorNavigation.Nombre + " " + l.IdAutorNavigation.Apellido,
                    Categoria = l.IdCategoriaNavigation.Descripcion,
                    Editorial = l.IdEditorialNavigation.Descripcion,
                    Idioma = l.IdIdiomaNavigation.Descripcion,
                    Fecha_publicacion = l.FechaPublicacion.ToString("d/M/yyyy", CultureInfo.InvariantCulture),
                    Precio = l.Precio,
                    Stock = l.Stock,
                    StockMinimo = l.StockMin,
                    Eliminado = l.Eliminado
                })
                .ToList();

            _libros = new BindingList<LibrosView>(libros);
            dgvLibros.DataSource = _libros.Where(l => !l.Eliminado && l.Stock > l.StockMinimo).ToList();
            cbGenero.SelectedIndex = -1;

            foreach (DataGridViewColumn column in dgvLibros.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvCarrito.DataSource = _carrito;

            var colLibro = new DataGridViewTextBoxColumn
            {
                HeaderText = "Título",
                Name = "Titulo",
                ReadOnly = true
            };
            dgvCarrito.Columns.Add(colLibro);

            foreach (DataGridViewColumn column in dgvCarrito.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvLibros.Columns["Id"].Visible = false;
            dgvLibros.Columns["Eliminado"].Visible = false;
            dgvLibros.Columns["StockMinimo"].Visible = false;
            dgvLibros.Columns["Agregar"].DisplayIndex = dgvLibros.ColumnCount - 1;
            dgvLibros.Columns["Fecha_publicacion"].HeaderText = "Publicado";

            dgvCarrito.Columns["Id"].Visible = false;
            dgvCarrito.Columns["IdVenta"].Visible = false;
            dgvCarrito.Columns["IdProducto"].Visible = false;
            dgvCarrito.Columns["IdProductoNavigation"].Visible = false;
            dgvCarrito.Columns["IdVentaNavigation"].Visible = false;

            dgvCarrito.Columns["Titulo"].DisplayIndex = 1;
            dgvCarrito.Columns["Sumar"].DisplayIndex = dgvCarrito.ColumnCount - 1;
            dgvCarrito.Columns["Restar"].DisplayIndex = dgvCarrito.ColumnCount - 1;
            dgvCarrito.Columns["Eliminar"].DisplayIndex = dgvCarrito.ColumnCount - 1;
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLibros.Columns[e.ColumnIndex].Name == "Agregar")
            {
                var libro = dgvLibros.Rows[e.RowIndex].DataBoundItem as LibrosView;

                if (_carrito.Any(d => d.IdProducto == libro.ID))
                {
                    var detalleExistente = _carrito.First(d => d.IdProducto == libro.ID);
                    detalleExistente.Cantidad += 1;
                    detalleExistente.Total = detalleExistente.Cantidad * detalleExistente.Precio;
                    dgvCarrito.Refresh();
                }
                else
                {
                    var nuevo = new VentasDetalle
                    {
                        IdVenta = 0,
                        IdProducto = libro.ID,
                        Cantidad = 1,
                        Precio = libro.Precio,
                        Total = libro.Precio
                    };

                    _carrito.Add(nuevo);
                }

                lSubtotal.Text = _carrito.Sum(d => d.Total).ToString();
            }
        }

        private void dgvCarrito_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCarrito.Columns[e.ColumnIndex].Name == "Titulo")
            {
                var detalle = dgvCarrito.Rows[e.RowIndex].DataBoundItem as VentasDetalle;
                if (detalle != null)
                {
                    var libro = _context.Libros.Local.FirstOrDefault(l => l.Id == detalle.IdProducto);
                    e.Value = libro?.Titulo ?? "(Desconocido)";
                }
            }
        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvCarrito.Columns[e.ColumnIndex].Name == "Sumar")
            {
                var detalle = dgvCarrito.Rows[e.RowIndex].DataBoundItem as VentasDetalle;
                if (detalle != null)
                {
                    detalle.Cantidad += 1;
                    detalle.Total = detalle.Cantidad * detalle.Precio;
                    dgvCarrito.Refresh();
                }
            }
            else if (dgvCarrito.Columns[e.ColumnIndex].Name == "Restar")
            {
                var detalle = dgvCarrito.Rows[e.RowIndex].DataBoundItem as VentasDetalle;
                if (detalle != null && detalle.Cantidad > 1)
                {
                    detalle.Cantidad -= 1;
                    detalle.Total = detalle.Cantidad * detalle.Precio;
                    dgvCarrito.Refresh();
                }
            }
            else if (dgvCarrito.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                var detalle = dgvCarrito.Rows[e.RowIndex].DataBoundItem as VentasDetalle;
                if (detalle != null)
                {
                    _carrito.Remove(detalle);
                }
            }

            lSubtotal.Text = _carrito.Sum(d => d.Total).ToString();
        }

        private async void bConfirmar_Click(object sender, EventArgs e)
        {
            var transaction = _context.Database.BeginTransaction();

            if (cbMetodos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un método de pago.", "Confirmar venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                var nuevaVenta = new VentasCabecera
                {
                    TotalVenta = _carrito.Sum(d => d.Total),
                    IdUsuario = _ID_Usuario,
                    IdMetodoPago = cbMetodos.SelectedIndex + 1,
                };
                _context.VentasCabeceras.Add(nuevaVenta);
                _context.SaveChanges();

                foreach (var detalle in _carrito)
                {
                    detalle.IdVenta = nuevaVenta.Id;
                    _context.VentasDetalles.Add(detalle);
                    var libro = _context.Libros.First(l => l.Id == detalle.IdProducto);
                    if ((libro.Stock - detalle.Cantidad) < libro.StockMin)
                    {
                        throw new Exception($"No hay suficiente stock del libro '{libro.Titulo}'.");
                    }
                    libro.Stock -= detalle.Cantidad;
                }
                _context.SaveChanges();
                transaction.Commit();

                var generator = new Factura(_context, _carrito, nuevaVenta);
                await generator.GenerarFactura();

                MessageBox.Show("La venta se ha confirmado con éxito.", "Confirmar venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _carrito.Clear();
                lSubtotal.Text = "0";
                cbMetodos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message, "Confirmar venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string filtro = tBuscar.Text.Trim().ToLower();

                var lista = _libros
                    .Where(l => l.Titulo.ToLower().Contains(filtro))
                    .ToList();

                dgvLibros.DataSource = new BindingList<LibrosView>(lista);
            }

            if (string.IsNullOrWhiteSpace(tBuscar.Text))
            {
                dgvLibros.DataSource = _libros.Where(l => !l.Eliminado && l.Stock > l.StockMinimo).ToList();
                return;
            }
        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGenero.SelectedIndex == -1)
            {
                dgvLibros.DataSource = _libros.Where(l => !l.Eliminado && l.Stock > l.StockMinimo).ToList();
                return;
            }

            string categoria = (string)cbGenero.SelectedValue;

            var filtrados = _libros
                .Where(l => l.Categoria == categoria)
                .ToList();

            dgvLibros.DataSource = _libros.Where(l => l.Categoria == categoria).ToList(); ;
        }
    }
}
