using Cumbre_Libros.Models;
using PuppeteerSharp;
using PuppeteerSharp.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public Factura(CumbreContext context, BindingList<VentasDetalle> carrito, VentasCabecera venta)
        {
            _context = context;
            _carrito = carrito;
            _venta = venta;
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
                .Replace("{{Date}}", _venta.Fecha.ToString("d", CultureInfo.InvariantCulture))
                .Replace("{{Number}}", _venta.Id.ToString("00000"))
                .Replace("{{Items}}", itemsHtml.ToString())
                .Replace("{{Subtotal}}", _venta.TotalVenta.ToString("N2"))
                .Replace("{{Total}}", _venta.TotalVenta.ToString("N2"))
                .Replace("{{Metodo_pago}}", _context.MetodosPagos.First(p => _venta.IdMetodoPago == p.Id).Descripcion);

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
}
