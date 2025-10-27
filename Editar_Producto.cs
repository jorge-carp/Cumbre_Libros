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

        private void bSumar_Click(object sender, EventArgs e)
        {
            if (tStock.Text == "")
                tStock.Text = "1";
            else
                tStock.Text = (int.Parse(tStock.Text) + 1).ToString();
        }

        private void bRestar_Click(object sender, EventArgs e)
        {
            if (tStock.Text != "1")
                tStock.Text = (int.Parse(tStock.Text) - 1).ToString();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            var transaction = _ctxt.Database.BeginTransaction();

            Libro nuevo_libro = new Libro
            {
                Isbn = long.Parse(tISBN.Text),
                Titulo = tTitulo.Text,
                Descripcion = tDescripcion.Text,
                Precio = double.Parse(tPrecio.Text),
                Stock = int.Parse(tStock.Text),
                IdAutor = cbAutor.SelectedIndex + 1,
                IdCategoria = cbCategoria.SelectedIndex + 1,
                IdEditorial = cbEditorial.SelectedIndex + 1,
                IdIdioma = cbIdioma.SelectedIndex + 1,
                FechaPublicacion = DateOnly.FromDateTime(dateTimePicker1.Value),
            };

            try
            {
                if (_ISBN == null)
                {
                    _ctxt.Libros.Add(nuevo_libro);

                    _ctxt.SaveChanges();
                    transaction.Commit();
                    MessageBox.Show("Producto añadido correctamente.", "Añadir producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var libro_existente = _ctxt.Libros.First(l => l.Isbn == _ISBN);
                    libro_existente.Isbn = nuevo_libro.Isbn;
                    libro_existente.Titulo = nuevo_libro.Titulo;
                    libro_existente.Descripcion = nuevo_libro.Descripcion;
                    libro_existente.Precio = nuevo_libro.Precio;
                    libro_existente.Stock = nuevo_libro.Stock;
                    libro_existente.IdAutor = nuevo_libro.IdAutor;
                    libro_existente.IdCategoria = nuevo_libro.IdCategoria;
                    libro_existente.IdEditorial = nuevo_libro.IdEditorial;
                    libro_existente.IdIdioma = nuevo_libro.IdIdioma;
                    libro_existente.FechaPublicacion = nuevo_libro.FechaPublicacion;
                    _ctxt.Libros.Update(libro_existente);

                    _ctxt.SaveChanges();
                    transaction.Commit();
                    MessageBox.Show("Producto modificado correctamente.", "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            catch (Exception)
            {
                transaction.Rollback();
                MessageBox.Show("Error al guardar el producto. Verifique que los datos sean correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
