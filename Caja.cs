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

            public async Task GenerateTicket(string templatePath, string outputPdfPath)
            {
                /*
                // Paths
                string workingDir = AppDomain.CurrentDomain.BaseDirectory;
                string basePath = Path.Combine(Directory.GetParent(workingDir).Parent.Parent.Parent.FullName, "Templates");
                string htmlPath = Path.Combine(basePath, "index.html");
                string cssPath = Path.Combine(basePath, "style.css");
                string outputPdf = Path.Combine(workingDir, "invoice.pdf");

                // Load HTML
                string html = File.ReadAllText(htmlPath);

                // Convert resource logo to Base64
                string logoBase64 = "data:image/png;base64," + ImageToBase64(Properties.Resources.logo);

                // Build the item table
                var itemsHtml = new StringBuilder();
                for (int i = 0; i < _carrito.Count; i++)
                {
                    itemsHtml.AppendLine($"<tr>\r\n" +
                        $"<td class=\"border-b py-3 pl-3\">{i+1}</td>\r\n" +
                        $"<td class=\"border-b py-3 pl-2\">{_carrito[i].IdProductoNavigation.Titulo}</td>\r\n" +
                        $"<td class=\"border-b py-3 pl-2 text-right\">${_carrito[i].Precio}</td>\r\n" +
                        $"<td class=\"border-b py-3 pl-2 text-center\">{_carrito[i].Cantidad}</td>\r\n" +
                        $"<td class=\"border-b py-3 pl-2 text-right\">${_carrito[i].Total}</td>\r\n" +
                        $"</tr>");
                }

                // Replace placeholder in the HTML
                html = html
                    .Replace("{{LogoBase64}}", logoBase64)
                    //.Replace("{{Date}}", _venta_cabecera.Fecha.ToString("d", CultureInfo.InvariantCulture))
                    //.Replace("{{Number}}", _venta_cabecera.Id.ToString())
                    .Replace("{{Items}}", itemsHtml.ToString());

                // PDF options
                var doc = new HtmlToPdfDocument
                {
                    GlobalSettings = new GlobalSettings
                    {
                        PaperSize = PaperKind.A4,
                        Orientation = WkHtmlToPdfDotNet.Orientation.Portrait,
                        Out = outputPdf,
                        DocumentTitle = "Invoice"
                    },
                    Objects = {
                        new ObjectSettings
                        {
                            HtmlContent = html,
                            WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = cssPath },
                            LoadSettings = { BlockLocalFileAccess = false }
                        }
                    }
                };

                _converter.Convert(doc);
                MessageBox.Show("Factura generada.");
                */
                await new BrowserFetcher().DownloadAsync();

                using var browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true });

                string workingDir = AppDomain.CurrentDomain.BaseDirectory;
                string basePath = Path.Combine(Directory.GetParent(workingDir).Parent.Parent.Parent.FullName, "Templates");
                string htmlPath = Path.Combine(basePath, "invoice.html");
                var template = File.ReadAllText(htmlPath);

                // Convert resource logo to Base64
                string logoBase64 = "data:image/png;base64," + ImageToBase64(Properties.Resources.logo);

                // Build the item table
                var itemsHtml = new StringBuilder();
                for (int i = 0; i < _carrito.Count; i++)
                {
                    itemsHtml.AppendLine($"<tr>\r\n" +
                        $"<td class=\"border-b py-3 pl-3\">{i + 1}</td>\r\n" +
                        $"<td class=\"border-b py-3 pl-2\">{_carrito[i].IdProductoNavigation.Titulo}</td>\r\n" +
                        $"<td class=\"border-b py-3 pl-2 text-right\">${_carrito[i].Precio.ToString("N2")}</td>\r\n" +
                        $"<td class=\"border-b py-3 pl-2 text-center\">{_carrito[i].Cantidad}</td>\r\n" +
                        $"<td class=\"border-b py-3 pl-2 text-right\">${_carrito[i].Total.ToString("N2")}</td>\r\n" +
                        $"</tr>");
                }

                template = template
                    .Replace("{{LogoBase64}}", logoBase64)
                    .Replace("{{Date}}", _venta_cabecera.Fecha.ToString("d", CultureInfo.InvariantCulture))
                    .Replace("{{Number}}", _venta_cabecera.Id.ToString())
                    .Replace("{{Items}}", itemsHtml.ToString())
                    .Replace("{{Subtotal}}", _venta_cabecera.TotalVenta.ToString("N2"))
                    .Replace("{{Total}}", _venta_cabecera.TotalVenta.ToString("N2"))
                    .Replace("{{Metodo_pago}}", _venta_cabecera.IdMetodoPagoNavigation.Descripcion);

                var page = await browser.NewPageAsync();
                await page.SetContentAsync(template);
                await page.PdfAsync("invoice.pdf", new PdfOptions
                {
                    Format = PaperFormat.A4,
                    PrintBackground = true,
                    MarginOptions = new MarginOptions
                    {
                        Top = "20px",
                        Right = "20px",
                        Bottom = "20px",
                        Left = "20px"
                    },
                    DisplayHeaderFooter = false,
                    Landscape = false
                });

                await page.PdfAsync("invoice.pdf", new PdfOptions
                {
                    Scale = 1.0m,
                    PrintBackground = true,
                    Landscape = false,
                    PageRanges = "1-2",
                    Format = PaperFormat.A4,
                    MarginOptions = new MarginOptions
                    {
                        Top = "50px",
                        Bottom = "50px",
                        Left = "20px",
                        Right = "20px"
                    }
                });
                MessageBox.Show("PDF Generated Successfully!");
            }

            public static string ImageToBase64(Image image)
            {
                using (var ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return Convert.ToBase64String(ms.ToArray());
                }
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
                    libro.Stock -= detalle.Cantidad;
                }
                //_context.SaveChanges();
                //transaction.Commit();

                var generator = new Factura(_context, _carrito, nuevaVenta);
                await generator.GenerarFactura();

                MessageBox.Show("La venta se ha confirmado con éxito.", "Confirmar venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _carrito.Clear();
                lSubtotal.Text = "0";
                cbMetodos.SelectedIndex = -1;
            }
            catch (Exception)
            {
                transaction.Rollback();
                MessageBox.Show("No sé que onda", "Confirmar venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
