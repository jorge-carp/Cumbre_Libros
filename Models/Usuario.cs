using System;
using System.Collections.Generic;

namespace Cumbre_Libros.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public int Dni { get; set; }

    public int IdRol { get; set; }

    public string Apellido { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public long Telefono { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Pass { get; set; } = null!;

    [System.ComponentModel.DataAnnotations.Schema.NotMapped]
    public string PlainPassword { get; set; }

    public bool Eliminado { get; set; } = false;

    public virtual Role IdRolNavigation { get; set; } = null!;

    public virtual ICollection<VentasCabecera> VentasCabeceras { get; set; } = new List<VentasCabecera>();
}
