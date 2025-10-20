using System;
using System.Collections.Generic;

namespace Cumbre_Libros.Models;

public partial class Idioma
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool Eliminado { get; set; } = false;

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
