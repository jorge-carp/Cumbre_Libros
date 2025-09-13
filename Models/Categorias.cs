using System;
using System.Collections.Generic;

namespace Cumbre_Libros.Models;

public partial class Categorias
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool? Eliminado { get; set; }

    public virtual ICollection<Libros> Libros { get; set; } = new List<Libros>();
}
