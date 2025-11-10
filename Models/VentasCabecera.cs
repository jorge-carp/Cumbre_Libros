using System;
using System.Collections.Generic;

namespace Cumbre_Libros.Models;

public partial class VentasCabecera
{
    public int Id { get; set; }

    public int IdUsuario { get; set; }

    public int IdMetodoPago { get; set; }

    public DateTime Fecha { get; set; }

    public double TotalVenta { get; set; }

    public bool Eliminado { get; set; }

    public virtual MetodosPago IdMetodoPagoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<VentasDetalle> VentasDetalles { get; set; } = new List<VentasDetalle>();
}
