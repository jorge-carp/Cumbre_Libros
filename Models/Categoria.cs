using System;
using System.Collections.Generic;

namespace Cumbre_Libros.Models;

public partial class Categoria
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool Eliminado { get; set; }

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
