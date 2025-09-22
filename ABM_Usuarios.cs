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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cumbre_Libros
{
    public partial class ABM_Usuarios : UserControl
    {
        private CumbreContext _context;
        private BindingSource usuariosBindingSource = new BindingSource();

        public ABM_Usuarios()
        {
            InitializeComponent();

            _context = new CumbreContext();

            _context.Usuarios.Load();
            usuariosBindingSource.DataSource = _context.Usuarios.Local.ToBindingList();
            dataGridView1.DataSource = usuariosBindingSource;

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Pass"].Visible = false;
            dataGridView1.Columns["PlainPassword"].Visible = false;
            dataGridView1.Columns["IdRolNavigation"].Visible = false;
            dataGridView1.Columns["VentasCabeceras"].Visible = false;
            dataGridView1.Columns["Eliminado"].Visible = false;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns["Editar"].DisplayIndex = dataGridView1.ColumnCount - 1;
            dataGridView1.Columns["Eliminar"].DisplayIndex = dataGridView1.ColumnCount - 1;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                usuariosBindingSource.DataSource =
                    new BindingList<Usuario>(_context.Usuarios.Local.Where(u => u.Eliminado).ToList());

                dataGridView1.Columns["Eliminar"].Visible = false;
            }
            else
            {
                usuariosBindingSource.DataSource =
                    new BindingList<Usuario>(_context.Usuarios.Local.Where(u => !u.Eliminado).ToList());

                dataGridView1.Columns["Eliminar"].Visible = true;
            }

            dataGridView1.DataSource = usuariosBindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                var edit_usuario = new Editar_Usuario(_context,
                    _context.Usuarios.First(u => u.NombreUsuario == dataGridView1.Rows[e.RowIndex].Cells["NombreUsuario"].Value));

                edit_usuario.ShowDialog();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar el usuario?",
                                                         "Confirmar eliminación",
                                                         MessageBoxButtons.YesNoCancel,
                                                         MessageBoxIcon.Warning,
                                                         MessageBoxDefaultButton.Button2);

                if (respuesta == DialogResult.Yes)
                {
                    using var transaction = _context.Database.BeginTransaction();

                    try
                    {
                        Usuario usuario = _context.Usuarios
                            .First(u => u.NombreUsuario == dataGridView1.Rows[e.RowIndex].Cells["NombreUsuario"].Value);
                        usuario.Eliminado = true;

                        _context.SaveChanges();
                        transaction.Commit();

                        MessageBox.Show("El usuario se ha eliminado con éxito.", "Eliminación de usuario",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show("El usuario no se pudo eliminar.", "Eliminación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            checkBox1_CheckedChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var crear_usuario = new Editar_Usuario(_context, null);
            crear_usuario.ShowDialog();
        }
    }
}
