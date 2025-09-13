using System;
using System.Collections.Generic;

namespace Cumbre_Libros.Models;

public partial class VentasDetalle
{
    public int Id { get; set; }

    public int? IdVenta { get; set; }

    public int? IdProducto { get; set; }

    public int? Cantidad { get; set; }

    public double? Precio { get; set; }

    public double? Total { get; set; }

    public virtual Libros? IdProductoNavigation { get; set; }

    public virtual VentasCabecera? IdVentaNavigation { get; set; }
}
