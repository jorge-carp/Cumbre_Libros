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

namespace Cumbre_Libros
{
    

    public partial class Caja : UserControl
    {
        private CumbreContext _context = new CumbreContext();
        private int _ID_Usuario;
        private BindingList<VentasDetalle> _carrito = new BindingList<VentasDetalle>();

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
        }

        public class TicketPdfGenerator
        {
            private readonly IConverter _converter;
            private BindingList<VentasDetalle> _carrito;
            private VentasCabecera _venta_cabecera;

            public TicketPdfGenerator(BindingList<VentasDetalle> carrito, VentasCabecera venta)
            {
                _converter = new SynchronizedConverter(new PdfTools());
                _carrito = carrito;
                _venta_cabecera = venta;
            }

            public void GenerateTicket(string templatePath, string outputPdfPath)
            {
                // 1️⃣ Load template
                string template = File.ReadAllText(templatePath);

                // 2️⃣ Build item list HTML
                var sb = new StringBuilder();
                foreach (var item in _carrito)
                    sb.AppendLine($"{item.IdProductoNavigation.Titulo} x{item.Cantidad} .... ${item.Total:F2}<br>");

                // 3️⃣ Replace placeholders
                string filledHtml = template
                    .Replace("{{Date}}", _venta_cabecera.Fecha.ToString())
                    .Replace("{{Items}}", sb.ToString())
                    .Replace("{{Total}}", _venta_cabecera.TotalVenta.ToString("F2"));

                // 4️⃣ Configure PDF generation
                var doc = new HtmlToPdfDocument()
                {
                    GlobalSettings = new GlobalSettings
                    {
                        PaperSize = PaperKind.A4,
                        Orientation = WkHtmlToPdfDotNet.Orientation.Portrait,
                        Margins = new MarginSettings { Top = 5, Bottom = 5, Left = 5, Right = 5 },
                        Out = outputPdfPath,
                        DocumentTitle = "Ticket de venta"
                    },
                    Objects = {
                new ObjectSettings
                {
                    HtmlContent = filledHtml,
                    WebSettings = { DefaultEncoding = "utf-8", PrintMediaType = true },
                    LoadSettings = { BlockLocalFileAccess = false }
                }
            }
                };

                // 5️⃣ Generate PDF
                _converter.Convert(doc);

                //Console.WriteLine($"✅ Ticket PDF generated: {outputPdfPath}");
                MessageBox.Show("Ticket de venta generado.");
            }
        }

        public Caja(int ID)
        {
            InitializeComponent();
            _ID_Usuario = ID;

            _context.Libros.Load();
            
            cbMetodos.DataSource = _context.MetodosPagos.Select(m => m.Descripcion).ToList();
            cbMetodos.SelectedIndex = -1;

            List<LibrosView> libros = _context.Libros
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
                })
                .ToList();

            dgvLibros.DataSource = libros;

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

        private void bConfirmar_Click(object sender, EventArgs e)
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
                    libro.Stock -= detalle.Cantidad;
                }
                //_context.SaveChanges();
                //transaction.Commit();

                var generator = new TicketPdfGenerator(_carrito, nuevaVenta);
                generator.GenerateTicket("ticket_template.html", "ticket.pdf");

                MessageBox.Show("La venta se ha confirmado con éxito.", "Confirmar venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _carrito.Clear();
                lSubtotal.Text = "0";
                cbMetodos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.InnerException.Message, "Confirmar venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
