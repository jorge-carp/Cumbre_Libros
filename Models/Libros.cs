using System;
using System.Collections.Generic;

namespace Cumbre_Libros.Models;

public partial class Libros
{
    public int Isbn { get; set; }

    public int? IdAutor { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdEditorial { get; set; }

    public string Titulo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int? Edicion { get; set; }

    public double? Precio { get; set; }

    public int? Stock { get; set; }

    public bool? Eliminado { get; set; }

    public virtual Autores? IdAutorNavigation { get; set; }

    public virtual Categorias? IdCategoriaNavigation { get; set; }

    public virtual Editoriales? IdEditorialNavigation { get; set; }

    public virtual ICollection<VentasDetalle> VentasDetalles { get; set; } = new List<VentasDetalle>();
}
