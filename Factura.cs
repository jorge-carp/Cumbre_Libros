using Cumbre_Libros.Models;
using Microsoft.EntityFrameworkCore;
using PuppeteerSharp;
using PuppeteerSharp.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cumbre_Libros
{
    internal class Factura
    {
        private CumbreContext _context;
        private BindingList<VentasDetalle> _carrito;
        private VentasCabecera _venta;
        private VentasCabecera? _n_credito;

        public Factura(CumbreContext context, BindingList<VentasDetalle> carrito, VentasCabecera venta, VentasCabecera? n_credito = null)
        {
            _context = context;
            _carrito = carrito;
            _venta = venta;
            _n_credito = n_credito;
        }

        public async Task GenerarFactura()
        {
            await new BrowserFetcher().DownloadAsync();

            using var browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true });

            string workingDir = AppDomain.CurrentDomain.BaseDirectory;
            string basePath = Path.Combine(Directory.GetParent(workingDir).Parent.Parent.Parent.FullName, "Templates");
            string htmlPath = Path.Combine(basePath, "invoice.html");
            var template = File.ReadAllText(htmlPath);

            // Convert resource logo to Base64
            string logoBase64 = "data:image/png;base64," + ImageToBase64(Properties.Resources.logo);

            // Build the item table
            var vendedor = _context.Usuarios.First(u => u.Id == _venta.IdUsuario);

            template = template
                .Replace("{{LogoBase64}}", logoBase64)
                .Replace("{{Seller}}", vendedor.Apellido + " " + vendedor.Nombre)
                .Replace("{{Metodo_pago}}", _context.MetodosPagos.First(p => _venta.IdMetodoPago == p.Id).Descripcion);

            var itemsHtml = new StringBuilder();
            if (_n_credito != null)
            {
                for (int i = 0; i < _carrito.Count; i++)
                {
                    itemsHtml.AppendLine($"<tr>\r\n" +
                        $"<td class=\"border-b py-3 pl-3\">{i + 1}</td>\r\n" +
                        $"<td class=\"border-b py-3 pl-2\">{_carrito[i].IdProductoNavigation.Titulo}</td>\r\n" +
                        $"<td class=\"border-b py-3 pl-2 text-right\">${_carrito[i].Precio.ToString("N2")}</td>\r\n" +
                        $"<td class=\"border-b py-3 pl-2 text-center\">-{_carrito[i].Cantidad}</td>\r\n" +
                        $"<td class=\"border-b py-3 pl-2 text-right\">-${_carrito[i].Total.ToString("N2")}</td>\r\n" +
                        $"</tr>");
                }

                template = template
                    .Replace("{{Number}}", _n_credito.Id.ToString("00000"))
                    .Replace("{{Date}}", DateOnly.FromDateTime(_n_credito.Fecha).ToString("dd/MM/yyyy") + "<br>" +
                        TimeOnly.FromDateTime(_n_credito.Fecha).ToString("HH:mm:ss"))
                    .Replace("{{Destino}}", "Detalle del Documento")
                    .Replace("{{Det_documento}}", $"<p>Factura n°: {_venta.Id.ToString("00000")}</p>\n" +
                        $"<p>Fecha de emisión: {_venta.Fecha.ToString("dd/MM/yyyy HH:mm:ss")}</p>")
                    .Replace("{{Items}}", itemsHtml.ToString())
                    .Replace("{{Subtotal}}", "-$" + _venta.TotalVenta.ToString("N2"))
                    .Replace("{{Impuestos}}", "-$0.00")
                    .Replace("{{Total}}", "-$" + _venta.TotalVenta.ToString("N2"));
            }
            else
            {
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
                    .Replace("{{Number}}", _venta.Id.ToString("00000"))
                    .Replace("{{Date}}", DateOnly.FromDateTime(_venta.Fecha).ToString("dd/MM/yyyy") + "<br>" +
                        TimeOnly.FromDateTime(_venta.Fecha).ToString("HH:mm:ss"))
                    .Replace("{{Destino}}", "Consumidor Final")
                    .Replace("{{Det_documento}}", "<p></p>\n<p></p>")
                    .Replace("{{Items}}", itemsHtml.ToString())
                    .Replace("{{Subtotal}}", "$" + _venta.TotalVenta.ToString("N2"))
                    .Replace("{{Impuestos}}", "$0.00")
                    .Replace("{{Total}}", "$" + _venta.TotalVenta.ToString("N2"));
            }

            var page = await browser.NewPageAsync();
            await page.SetContentAsync(template);

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
                },
                DisplayHeaderFooter = false,
            });

            Process.Start(new ProcessStartInfo
            {
                FileName = "invoice.pdf",
                UseShellExecute = true
            });
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
}
