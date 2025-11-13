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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Cumbre_Libros
{
    public partial class ABM_Vendedores : UserControl
    {
        private CumbreContext _context = new CumbreContext();
        private BindingSource usuariosBindingSource = new BindingSource();

        public ABM_Vendedores()
        {
            InitializeComponent();

            _context.Usuarios.Load();
            usuariosBindingSource.DataSource = _context.Usuarios.Local.Where(u => u.IdRol == 3);
            dgvVendedores.DataSource = usuariosBindingSource;

            dgvVendedores.Columns["Id"].Visible = false;
            dgvVendedores.Columns["Pass"].Visible = false;
            dgvVendedores.Columns["PlainPassword"].Visible = false;
            dgvVendedores.Columns["IdRolNavigation"].Visible = false;
            dgvVendedores.Columns["VentasCabeceras"].Visible = false;
            dgvVendedores.Columns["Eliminado"].Visible = false;

            dgvVendedores.RowHeadersVisible = false;

            dgvVendedores.Columns["Editar"].DisplayIndex = dgvVendedores.ColumnCount - 1;
            dgvVendedores.Columns["Eliminar"].DisplayIndex = dgvVendedores.ColumnCount - 1;

            dgvVendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbEliminados_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEliminados.Checked)
            {
                usuariosBindingSource.DataSource = new BindingList<Usuario>(_context.Usuarios.Local.Where(u => u.IdRol == 3 && u.Eliminado).ToList());

                dgvVendedores.Columns["Eliminar"].Visible = false;
            }
            else
            {
                usuariosBindingSource.DataSource = new BindingList<Usuario>(_context.Usuarios.Local.Where(u => u.IdRol == 3 && !u.Eliminado).ToList());

                dgvVendedores.Columns["Eliminar"].Visible = true;
            }

            dgvVendedores.DataSource = usuariosBindingSource;
        }

        private void dgvVendedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvVendedores.Columns[e.ColumnIndex].Name == "Editar")
            {
                var edit_usuario = new Editar_Usuario(_context, _context.Usuarios.First(u => u.NombreUsuario == dgvVendedores.Rows[e.RowIndex].Cells["NombreUsuario"].Value), true);

                edit_usuario.ShowDialog();
            }
            else if (dgvVendedores.Columns[e.ColumnIndex].Name == "Eliminar")
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
                            .First(u => u.NombreUsuario == dgvVendedores.Rows[e.RowIndex].Cells["NombreUsuario"].Value);
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

            cbEliminados_CheckedChanged(sender, e);
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            var crear_usuario = new Editar_Usuario(_context, null, true);
            crear_usuario.ShowDialog();
        }
    }
}
