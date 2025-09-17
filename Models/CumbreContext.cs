using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Cumbre_Libros.Models;

public partial class CumbreContext : DbContext
{
    public CumbreContext()
    {
    }

    public CumbreContext(DbContextOptions<CumbreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autores> Autores { get; set; }

    public virtual DbSet<Categorias> Categorias { get; set; }

    public virtual DbSet<Editoriales> Editoriales { get; set; }

    public virtual DbSet<Libros> Libros { get; set; }

    public virtual DbSet<MetodosPago> MetodosPagos { get; set; }

    public virtual DbSet<Paises> Paises { get; set; }

    public virtual DbSet<Roles> Roles { get; set; }

    public virtual DbSet<Usuarios> Usuarios { get; set; }

    public virtual DbSet<VentasCabecera> VentasCabeceras { get; set; }

    public virtual DbSet<VentasDetalle> VentasDetalles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=cumbre.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autores>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellido).HasColumnName("apellido");
            entity.Property(e => e.Eliminado)
                .HasDefaultValueSql("FALSE")
                .HasColumnType("boolean")
                .HasColumnName("eliminado");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
        });

        modelBuilder.Entity<Categorias>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion).HasColumnName("descripcion");
            entity.Property(e => e.Eliminado)
                .HasDefaultValueSql("FALSE")
                .HasColumnType("boolean")
                .HasColumnName("eliminado");
        });

        modelBuilder.Entity<Editoriales>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion).HasColumnName("descripcion");
            entity.Property(e => e.Eliminado)
                .HasDefaultValueSql("FALSE")
                .HasColumnType("boolean")
                .HasColumnName("eliminado");
            entity.Property(e => e.IdPaises).HasColumnName("ID_paises");

            entity.HasOne(d => d.IdPaisesNavigation).WithMany(p => p.Editoriales).HasForeignKey(d => d.IdPaises);
        });

        modelBuilder.Entity<Libros>(entity =>
        {
            entity.HasKey(e => e.Isbn);

            entity.Property(e => e.Isbn).HasColumnName("ISBN");
            entity.Property(e => e.Descripcion).HasColumnName("descripcion");
            entity.Property(e => e.Edicion).HasColumnName("edicion");
            entity.Property(e => e.Eliminado)
                .HasDefaultValueSql("FALSE")
                .HasColumnType("boolean")
                .HasColumnName("eliminado");
            entity.Property(e => e.IdAutor).HasColumnName("ID_autor");
            entity.Property(e => e.IdCategoria).HasColumnName("ID_categoria");
            entity.Property(e => e.IdEditorial).HasColumnName("ID_editorial");
            entity.Property(e => e.Precio)
                .HasColumnType("float")
                .HasColumnName("precio");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.Titulo).HasColumnName("titulo");

            entity.HasOne(d => d.IdAutorNavigation).WithMany(p => p.Libros).HasForeignKey(d => d.IdAutor);

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Libros).HasForeignKey(d => d.IdCategoria);

            entity.HasOne(d => d.IdEditorialNavigation).WithMany(p => p.Libros).HasForeignKey(d => d.IdEditorial);
        });

        modelBuilder.Entity<MetodosPago>(entity =>
        {
            entity.ToTable("Metodos_pago");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion).HasColumnName("descripcion");
            entity.Property(e => e.Eliminado)
                .HasDefaultValueSql("FALSE")
                .HasColumnType("boolean")
                .HasColumnName("eliminado");
        });

        modelBuilder.Entity<Paises>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion).HasColumnName("descripcion");
            entity.Property(e => e.Eliminado)
                .HasDefaultValueSql("FALSE")
                .HasColumnType("boolean")
                .HasColumnName("eliminado");
        });

        modelBuilder.Entity<Roles>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion).HasColumnName("descripcion");
            entity.Property(e => e.Eliminado)
                .HasDefaultValueSql("FALSE")
                .HasColumnType("boolean")
                .HasColumnName("eliminado");
        });

        modelBuilder.Entity<Usuarios>(entity =>
        {
            entity.HasIndex(e => e.NombreUsuario, "IX_Usuarios_nombre_usuario").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Apellido).HasColumnName("apellido");
            entity.Property(e => e.Dni).HasColumnName("DNI");
            entity.Property(e => e.Eliminado)
                .HasDefaultValueSql("FALSE")
                .HasColumnType("boolean")
                .HasColumnName("eliminado");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.IdRol).HasColumnName("ID_rol");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
            entity.Property(e => e.NombreUsuario).HasColumnName("nombre_usuario");
            entity.Property(e => e.Pass).HasColumnName("pass");
            entity.Property(e => e.Telefono).HasColumnName("telefono");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<VentasCabecera>(entity =>
        {
            entity.ToTable("Ventas_cabecera");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdMetodoPago).HasColumnName("ID_metodo_pago");
            entity.Property(e => e.IdUsuario).HasColumnName("ID_usuario");
            entity.Property(e => e.TotalVenta)
                .HasColumnType("float")
                .HasColumnName("total_venta");

            entity.HasOne(d => d.IdMetodoPagoNavigation).WithMany(p => p.VentasCabeceras).HasForeignKey(d => d.IdMetodoPago);

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.VentasCabeceras).HasForeignKey(d => d.IdUsuario);
        });

        modelBuilder.Entity<VentasDetalle>(entity =>
        {
            entity.ToTable("Ventas_detalle");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdProducto).HasColumnName("ID_producto");
            entity.Property(e => e.IdVenta).HasColumnName("ID_venta");
            entity.Property(e => e.Precio)
                .HasColumnType("float")
                .HasColumnName("precio");
            entity.Property(e => e.Total)
                .HasColumnType("float")
                .HasColumnName("total");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.VentasDetalles).HasForeignKey(d => d.IdProducto);

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.VentasDetalles).HasForeignKey(d => d.IdVenta);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
