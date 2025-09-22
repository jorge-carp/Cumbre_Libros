using System;
using System.Collections.Generic;

namespace Cumbre_Libros.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool? Eliminado { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
