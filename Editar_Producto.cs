using Cumbre_Libros.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cumbre_Libros
{
    public partial class Editar_Producto : Form
    {
        private CumbreContext _ctxt;
        private long? _ISBN;

        public Editar_Producto(CumbreContext _context, long? ISBN)
        {
            InitializeComponent();

            _ISBN = ISBN;
            _ctxt = _context;

            LoadData();
        }

        private void LoadData()
        {
            cbAutor.DataSource = _ctxt.Autores.Select(a => a.Nombre + " " + a.Apellido).ToList();
            cbCategoria.DataSource = _ctxt.Categorias.Select(c => c.Descripcion).ToList();
            cbEditorial.DataSource = _ctxt.Editoriales.Select(e => e.Descripcion).ToList();
            cbIdioma.DataSource = _ctxt.Idiomas.Select(i => i.Descripcion).ToList();

            if (_ISBN != null)
            {
                var libro = _ctxt.Libros.First(l => l.Isbn == _ISBN);

                tISBN.Text = libro.Isbn.ToString();
                tTitulo.Text = libro.Titulo;
                tDescripcion.Text = libro.Descripcion;
                tPrecio.Text = libro.Precio.ToString();
                tStock.Text = libro.Stock.ToString();
                cbAutor.SelectedIndex = libro.IdAutor - 1;
                cbCategoria.SelectedIndex = libro.IdCategoria - 1;
                cbEditorial.SelectedIndex = libro.IdEditorial - 1;
                cbIdioma.SelectedIndex = libro.IdIdioma - 1;
                dateTimePicker1.Value = libro.FechaPublicacion.ToDateTime(TimeOnly.MinValue);
            }
            else
            {
                this.Text = "Añadir Producto";
                cbAutor.SelectedIndex = -1;
                cbCategoria.SelectedIndex = -1;
                cbEditorial.SelectedIndex = -1;
                cbIdioma.SelectedIndex = -1;
            }
        }

        private void bEditorial_Click(object sender, EventArgs e)
        {
            var ABM_editorial = new ABM_Detalles(_ctxt, (Button)sender);
            ABM_editorial.ShowDialog();

            LoadData();
        }

        private void bAutor_Click(object sender, EventArgs e)
        {
            var ABM_autor = new ABM_Detalles(_ctxt, (Button)sender);
            ABM_autor.ShowDialog();

            LoadData();
        }

        private void bCategoria_Click(object sender, EventArgs e)
        {
            var ABM_categoria = new ABM_Detalles(_ctxt, (Button)sender);
            ABM_categoria.ShowDialog();

            LoadData();
        }

        private void bIdioma_Click(object sender, EventArgs e)
        {
            var ABM_idioma = new ABM_Detalles(_ctxt, (Button)sender);
            ABM_idioma.ShowDialog();

            LoadData();
        }
    }
}
