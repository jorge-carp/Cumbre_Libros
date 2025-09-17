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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Cumbre_Libros
{
    public partial class ABM_Usuarios : UserControl
    {
        private readonly CumbreContext db = new CumbreContext();

        public ABM_Usuarios()
        {
            InitializeComponent();

            var dni_usuarios = db.Usuarios.Select(u => u.Dni); // .Where(u => u.Eliminado != false)
            var roles = db.Roles.Select(r => r.Descripcion);
            
            cbBuscar.DataSource = dni_usuarios.ToList();
            cbBuscar.SelectedIndex = -1;
            cbRol.DataSource = roles.ToList();
            cbRol.SelectedIndex = -1;
        }

        private void cbBuscar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string? DNI_usuario = cbBuscar.SelectedItem?.ToString();

            if (DNI_usuario != null)
            {
                bModificar.Enabled = true;
                bEliminar.Enabled = true;

                var usuario = db.Usuarios.Single(u => u.Dni == int.Parse(DNI_usuario));

                tDNI.Text = usuario.Dni.ToString();
                tApellido.Text = usuario.Apellido;
                tNombre.Text = usuario.Nombre;
                tEmail.Text = usuario.Email;
                tTelefono.Text = usuario.Telefono.ToString();
                cbRol.SelectedIndex = usuario.IdRol - 1;
                tNombreUsuario.Text = usuario.NombreUsuario;
                tPassword.Text = usuario.Pass;

                foreach (var tb in gbDatos.Controls.OfType<System.Windows.Forms.TextBox>())
                    tb.ReadOnly = true;

                cbRol.Enabled = false;
            }
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            foreach (var tb in gbDatos.Controls.OfType<System.Windows.Forms.TextBox>())
                tb.ReadOnly = false;

            cbRol.Enabled = true;
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            string? DNI_usuario = cbBuscar.SelectedItem?.ToString();

            if (DNI_usuario != null)
            {
                var usuario = db.Usuarios.Single(u => u.Dni == int.Parse(DNI_usuario));

                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar el usuario?",
                                                         "Confirmar eliminación",
                                                         MessageBoxButtons.YesNoCancel,
                                                         MessageBoxIcon.Warning,
                                                         MessageBoxDefaultButton.Button2);

                if (respuesta == DialogResult.Yes)
                {
                    using var transaction = db.Database.BeginTransaction();

                    try
                    {
                        usuario.Eliminado = true;

                        tDNI.Text = "";
                        tApellido.Text = "";
                        tNombre.Text = "";
                        tEmail.Text = "";
                        tTelefono.Text = "";
                        cbRol.SelectedIndex = -1;
                        tNombreUsuario.Text = "";
                        tPassword.Text = "";

                        db.SaveChanges();
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
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (tDNI.Text == "" || tApellido.Text == "" || tNombre.Text == "" || tEmail.Text == "" ||
                tNombreUsuario.Text == "" || tPassword.Text == "" || tTelefono.Text == "" || cbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos.", "Creación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (tDNI.Text.Length > 8)
            {
                MessageBox.Show("Ingrese un DNI válido.", "Creación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using var transaction = db.Database.BeginTransaction();
 
            try
            {
                Usuarios nuevo_usuario = new Usuarios
                {
                    Dni = int.Parse(tDNI.Text),
                    Apellido = tApellido.Text,
                    Nombre = tNombre.Text,
                    Email = tEmail.Text,
                    Telefono = int.Parse(tTelefono.Text),
                    IdRol = cbRol.SelectedIndex,
                    NombreUsuario = tNombreUsuario.Text,
                    Pass = tPassword.Text,
                };

                db.Usuarios.Add(nuevo_usuario);

                db.SaveChanges();
                transaction.Commit();
                MessageBox.Show("El usuario se ha creado con éxito.", "Creación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                var dni_usuarios = db.Usuarios.Select(u => u.Dni);
                cbBuscar.DataSource = dni_usuarios.ToList();
                cbBuscar.SelectedIndex = -1;
                
            }
            catch (DbUpdateException)
            {
                transaction.Rollback();
                MessageBox.Show("El usuario ya se encuentra en la base de datos.", "Creación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            tDNI.Text = "";
            tApellido.Text = "";
            tNombre.Text = "";
            tEmail.Text = "";
            tTelefono.Text = "";
            cbRol.SelectedIndex = -1;
            tNombreUsuario.Text = "";
            tPassword.Text = "";

            foreach (var tb in gbDatos.Controls.OfType<System.Windows.Forms.TextBox>())
                tb.ReadOnly = false;

            cbRol.Enabled = true;
        }
    }
}
