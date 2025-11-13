using System;
using System.Collections.Generic;

namespace Cumbre_Libros.Models;

public partial class Autore
{
    public int Id { get; set; }

    public string Apellido { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Eliminado { get; set; }

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
