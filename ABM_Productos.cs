using Cumbre_Libros.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cumbre_Libros
{
    public partial class ABM_Productos : UserControl
    {
        private CumbreContext _context = new CumbreContext();
        private BindingSource _libros = new BindingSource();

        public class LibrosView
        {
            public long ISBN { get; set; }
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public string Categoria { get; set; }
            public string Editorial { get; set; }
            public string Idioma { get; set; }
            public string Fecha_publicacion { get; set; }
            public double precio { get; set; }
            public int stock { get; set; }
        }

        public ABM_Productos()
        {
            InitializeComponent();

            LoadData();

            dataGridView1.Columns["Editar"].DisplayIndex = dataGridView1.ColumnCount - 1;
            dataGridView1.Columns["Eliminar"].DisplayIndex = dataGridView1.ColumnCount - 1;
        }

        private void LoadData()
        {
            List<LibrosView> libros = _context.Libros
                .Include(l => l.IdAutorNavigation)
                .Include(l => l.IdCategoriaNavigation)
                .Include(l => l.IdEditorialNavigation)
                .Include(l => l.IdIdiomaNavigation)
                .Select(l => new LibrosView
                {
                    ISBN = l.Isbn,
                    Titulo = l.Titulo,
                    Autor = l.IdAutorNavigation.Nombre + " " + l.IdAutorNavigation.Apellido,
                    Categoria = l.IdCategoriaNavigation.Descripcion,
                    Editorial = l.IdEditorialNavigation.Descripcion,
                    Idioma = l.IdIdiomaNavigation.Descripcion,
                    Fecha_publicacion = l.FechaPublicacion.ToString("d/M/yyyy", CultureInfo.InvariantCulture),
                    precio = l.Precio,
                    stock = l.Stock,
                })
                .ToList();

            _libros.DataSource = libros;
            dataGridView1.DataSource = _libros;
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            var crear_libro = new Editar_Producto(_context, null);
            crear_libro.ShowDialog();

            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                var edit_producto = new Editar_Producto(_context, (long)dataGridView1.Rows[e.RowIndex].Cells["ISBN"].Value);
                edit_producto.ShowDialog();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar el libro?",
                                                         "Confirmar eliminación",
                                                         MessageBoxButtons.YesNoCancel,
                                                         MessageBoxIcon.Warning,
                                                         MessageBoxDefaultButton.Button2);

                if (respuesta == DialogResult.Yes)
                {
                    using var transaction = _context.Database.BeginTransaction();

                    try
                    {
                        Libro libro = _context.Libros
                            .First(l => l.Isbn == (long)dataGridView1.Rows[e.RowIndex].Cells["ISBN"].Value);
                        libro.Eliminado = true;

                        _context.SaveChanges();
                        transaction.Commit();

                        MessageBox.Show("El libro se ha eliminado con éxito.", "Eliminación de producto",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show("El libro no se pudo eliminar.", "Eliminación de producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            LoadData();
        }
    }
}
