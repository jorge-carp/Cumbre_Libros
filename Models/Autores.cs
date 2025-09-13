using System;
using System.Collections.Generic;

namespace Cumbre_Libros.Models;

public partial class Autores
{
    public int Id { get; set; }

    public string Apellido { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool? Eliminado { get; set; }

    public virtual ICollection<Libros> Libros { get; set; } = new List<Libros>();
}
