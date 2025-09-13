using System;
using System.Collections.Generic;

namespace Cumbre_Libros.Models;

public partial class Usuarios
{
    public int Id { get; set; }

    public int? IdRol { get; set; }

    public string Apellido { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Telefono { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public bool? Eliminado { get; set; }

    public virtual Roles? IdRolNavigation { get; set; }

    public virtual ICollection<VentasCabecera> VentasCabeceras { get; set; } = new List<VentasCabecera>();
}
