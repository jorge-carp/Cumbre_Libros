using System;
using System.Collections.Generic;

namespace Cumbre_Libros.Models;

public partial class Editoriale
{
    public int Id { get; set; }

    public int IdPaises { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool? Eliminado { get; set; }

    public virtual Paise IdPaisesNavigation { get; set; } = null!;

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
