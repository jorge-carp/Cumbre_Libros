using Cumbre_Libros.Models;
using Equin.ApplicationFramework;
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
    public partial class ABM_Detalles : Form
    {
        private CumbreContext _context;
        private Button _sender;
        private IBindingListView _view;

        public ABM_Detalles(CumbreContext context, Button sender)
        {
            InitializeComponent();

            _context = context;
            _sender = sender;

            switch (_sender.Name)
            {
                case "bEditorial":
                    _context.Editoriales.Load();
                    _view = new BindingListView<Editoriale>(_context.Editoriales.Local.ToBindingList());
                    ((BindingListView<Editoriale>)_view).ApplyFilter(e => !e.Eliminado);
                    dgvDetalles.DataSource = _view;

                    dgvDetalles.Columns["IdPaisesNavigation"].Visible = false;
                    dgvDetalles.Columns["IdPaises"].Visible = false;

                    dgvDetalles.Columns["Descripcion"].DisplayIndex = 0;
                    dgvDetalles.Columns["Descripcion"].HeaderText = "Nombre";
                    dgvDetalles.Columns["Libros"].Visible = false;

                    var combo = new DataGridViewComboBoxColumn
                    {
                        Name = "Paises",
                        DataPropertyName = "IdPaises",
                        DataSource = _context.Paises.ToList(),
                        DisplayMember = "Descripcion",
                        ValueMember = "Id",
                        HeaderText = "País",
                        DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
                    };

                    int index = dgvDetalles.Columns["IdPaises"].DisplayIndex;
                    dgvDetalles.Columns.Remove("IdPaises");
                    dgvDetalles.Columns.Insert(index, combo);
                    break;

                case "bCategoria":
                    _context.Categorias.Load();
                    _view = new BindingListView<Categoria>(_context.Categorias.Local.ToBindingList());
                    ((BindingListView<Categoria>)_view).ApplyFilter(c => !c.Eliminado);
                    dgvDetalles.DataSource = _view;

                    dgvDetalles.Columns["Descripcion"].DisplayIndex = 0;
                    dgvDetalles.Columns["Descripcion"].HeaderText = "Nombre";
                    dgvDetalles.Columns["Libros"].Visible = false;
                    break;

                case "bAutor":
                    _context.Autores.Load();
                    _view = new BindingListView<Autore>(_context.Autores.Local.ToBindingList());
                    ((BindingListView<Autore>)_view).ApplyFilter(a => !a.Eliminado);
                    dgvDetalles.DataSource = _view;

                    dgvDetalles.Columns["Libros"].Visible = false;
                    break;

                case "bIdioma":
                    _context.Idiomas.Load();
                    _view = new BindingListView<Idioma>(_context.Idiomas.Local.ToBindingList());
                    ((BindingListView<Idioma>)_view).ApplyFilter(i => !i.Eliminado);
                    dgvDetalles.DataSource = _view;

                    dgvDetalles.Columns["Libros"].Visible = false;
                    dgvDetalles.Columns["Descripcion"].HeaderText = "Nombre";
                    break;

                default:
                    break;
            }

            dgvDetalles.Columns["Id"].Visible = false;
            dgvDetalles.Columns["Eliminado"].Visible = false;
        }

        private void dgvDetalles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDetalles.Columns["Eliminar"].DisplayIndex = dgvDetalles.ColumnCount - 1;
            dgvDetalles.Columns["Restaurar"].DisplayIndex = dgvDetalles.ColumnCount - 1;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            using var transaction = _context.Database.BeginTransaction();

            dgvDetalles.EndEdit();

            try
            {
                _context.SaveChanges();
                transaction.Commit();
                MessageBox.Show("Los cambios se han guardado con éxito.", "Guardar cambios",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                transaction.Rollback();
                MessageBox.Show("Los campos están incompletos o no son válidos.", "Guardar cambios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbEliminados_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEliminados.Checked)
            {
                switch (_sender.Name)
                {
                    case "bEditorial":
                        ((BindingListView<Editoriale>)_view).RemoveFilter();
                        ((BindingListView<Editoriale>)_view).ApplyFilter(e => e.Eliminado);
                        break;
                    case "bCategoria":
                        ((BindingListView<Categoria>)_view).RemoveFilter();
                        ((BindingListView<Categoria>)_view).ApplyFilter(c => c.Eliminado);
                        break;
                    case "bAutor":
                        ((BindingListView<Autore>)_view).RemoveFilter();
                        ((BindingListView<Autore>)_view).ApplyFilter(a => a.Eliminado);
                        break;
                    case "bIdioma":
                        ((BindingListView<Idioma>)_view).RemoveFilter();
                        ((BindingListView<Idioma>)_view).ApplyFilter(i => i.Eliminado);
                        break;
                    default:
                        break;
                }
                dgvDetalles.Columns["Eliminar"].Visible = false;
                dgvDetalles.Columns["Restaurar"].Visible = true;
            }
            else
            {
                switch (_sender.Name)
                {
                    case "bEditorial":
                        ((BindingListView<Editoriale>)_view).RemoveFilter();
                        ((BindingListView<Editoriale>)_view).ApplyFilter(e => !e.Eliminado);
                        break;
                    case "bCategoria":
                        ((BindingListView<Categoria>)_view).RemoveFilter();
                        ((BindingListView<Categoria>)_view).ApplyFilter(c => !c.Eliminado);
                        break;
                    case "bAutor":
                        ((BindingListView<Autore>)_view).RemoveFilter();
                        ((BindingListView<Autore>)_view).ApplyFilter(a => !a.Eliminado);
                        break;
                    case "bIdioma":
                        ((BindingListView<Idioma>)_view).RemoveFilter();
                        ((BindingListView<Idioma>)_view).ApplyFilter(i => !i.Eliminado);
                        break;
                    default:
                        break;
                }
                dgvDetalles.Columns["Eliminar"].Visible = true;
                dgvDetalles.Columns["Restaurar"].Visible = false;
            }
        }

        private void dgvDetalles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var view = dgvDetalles.Rows[e.RowIndex].DataBoundItem;

            if (dgvDetalles.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                switch (_sender.Name)
                {
                    case "bEditorial":
                        var editorial = view.GetType().GetProperty("Object")?.GetValue(view) as Editoriale;
                        if (editorial != null)
                        {
                            editorial.Eliminado = true;
                            MessageBox.Show("La editorial ha sido eliminada.");
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar la editorial.");
                        }
                        break;

                    case "bAutor":
                        var autor = view.GetType().GetProperty("Object")?.GetValue(view) as Autore;

                        if (autor != null)
                        {
                            autor.Eliminado = true;
                            MessageBox.Show("El autor ha sido eliminado.");
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar al autor.");
                        }
                        break;

                    case "bIdioma":
                        var idioma = view.GetType().GetProperty("Object")?.GetValue(view) as Idioma;

                        if (idioma != null)
                        {
                            idioma.Eliminado = true;
                            MessageBox.Show("El idioma ha sido eliminado.");
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el idioma.");
                        }
                        break;

                    case "bCategoria":
                        var categoria = view.GetType().GetProperty("Object")?.GetValue(view) as Categoria;

                        if (categoria != null)
                        {
                            categoria.Eliminado = true;
                            MessageBox.Show("La categoría ha sido eliminada.");
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar la categoría.");
                        }
                        break;

                    default:
                        break;
                }

            }
            else if (dgvDetalles.Columns[e.ColumnIndex].Name == "Restaurar")
            {
                switch (_sender.Name)
                {
                    case "bEditorial":
                        var editorial = view.GetType().GetProperty("Object")?.GetValue(view) as Editoriale;
                        if (editorial != null)
                        {
                            editorial.Eliminado = false;
                            MessageBox.Show("La editorial ha sido restaurada.");
                        }
                        else
                        {
                            MessageBox.Show("Error al restaurar la editorial.");
                        }
                        break;

                    case "bIdioma":
                        var idioma = view.GetType().GetProperty("Object")?.GetValue(view) as Idioma;
                        if (idioma != null)
                        {
                            idioma.Eliminado = false;
                            MessageBox.Show("El idioma ha sido restaurado.");
                        }
                        else
                        {
                            MessageBox.Show("Error al restaurar el idioma.");
                        }
                        break;

                    case "bCategoria":
                        var categoria = view.GetType().GetProperty("Object")?.GetValue(view) as Categoria;
                        if (categoria != null)
                        {
                            categoria.Eliminado = false;
                            MessageBox.Show("La categoría ha sido restaurada.");
                        }
                        else
                        {
                            MessageBox.Show("Error al restaurar la categoría.");
                        }
                        break;

                    case "bAutor":
                        var autor = view.GetType().GetProperty("Object")?.GetValue(view) as Autore;
                        if (autor != null)
                        {
                            autor.Eliminado = false;
                            MessageBox.Show("El autor ha sido restaurado.");
                        }
                        else
                        {
                            MessageBox.Show("Error al restaurar el autor.");
                        }
                        break;
                    default:
                        break;
                }

            }
        }

        private void dgvDetalles_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDetalles.IsCurrentCellDirty && dgvDetalles.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvDetalles.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
