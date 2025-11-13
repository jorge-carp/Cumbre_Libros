using System;
using System.Collections.Generic;

namespace Cumbre_Libros.Models;

public partial class MetodosPago
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool Eliminado { get; set; }

    public virtual ICollection<VentasCabecera> VentasCabeceras { get; set; } = new List<VentasCabecera>();
}
