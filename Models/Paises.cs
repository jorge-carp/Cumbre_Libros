using System;
using System.Collections.Generic;

namespace Cumbre_Libros.Models;

public partial class Paises
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool? Eliminado { get; set; }

    public virtual ICollection<Editoriales> Editoriales { get; set; } = new List<Editoriales>();
}
