using System;
using System.Collections.Generic;

namespace Cumbre_Libros.Models;

public partial class VentasCabecera
{
    public int Id { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdMetodoPago { get; set; }

    public DateTime? Fecha { get; set; }

    public double? TotalVenta { get; set; }

    public virtual MetodosPago? IdMetodoPagoNavigation { get; set; }

    public virtual Usuarios? IdUsuarioNavigation { get; set; }

    public virtual ICollection<VentasDetalle> VentasDetalles { get; set; } = new List<VentasDetalle>();
}
