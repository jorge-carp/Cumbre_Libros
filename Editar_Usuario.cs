using Cumbre_Libros.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cumbre_Libros
{
    public partial class Editar_Usuario : Form
    {
        private Usuario _usuario;
        private CumbreContext _context;
        private bool _modificacion = false;
        private bool _activar = false;


        public Editar_Usuario(CumbreContext context, Usuario usuario)
        {
            InitializeComponent();

            var roles = context.Roles.Select(r => r.Descripcion);

            cbPerfil.DataSource = roles.ToList();
            cbPerfil.SelectedIndex = -1;

            if (usuario != null)
            {
                _modificacion = true;
                tDNI.Text = usuario.Dni.ToString();
                tApellido.Text = usuario.Apellido;
                tNombre.Text = usuario.Nombre;
                tTelefono.Text = usuario.Telefono.ToString();
                tEmail.Text = usuario.Email;
                cbPerfil.SelectedIndex = usuario.IdRol - 1;
                tNombreUsuario.Text = usuario.NombreUsuario;

                if (usuario.Eliminado == true)
                {
                    checkBox2.Visible = true;
                }
            }
            else
            {
                checkBox1.Visible = false;
                tPassword.ReadOnly = false;
                tConfirmarPassword.ReadOnly = false;
            }

            _context = context;
            _usuario = usuario;
        }

        private bool checkEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            var valid = true;
            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }

            return valid;
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (_usuario != null)
            {
                if (string.IsNullOrWhiteSpace(tDNI.Text) || string.IsNullOrWhiteSpace(tApellido.Text) ||
                    string.IsNullOrWhiteSpace(tNombre.Text) || string.IsNullOrWhiteSpace(tEmail.Text) ||
                    string.IsNullOrWhiteSpace(tNombreUsuario.Text) || string.IsNullOrWhiteSpace(tTelefono.Text) ||
                    cbPerfil.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe completar los campos.", "Modificación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!checkEmail(tEmail.Text))
                {
                    MessageBox.Show("El email ingresado no es válido.", "Modificación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (tPassword.Text != tConfirmarPassword.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Modificación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tDNI.Text) || string.IsNullOrWhiteSpace(tApellido.Text) ||
                    string.IsNullOrWhiteSpace(tNombre.Text) || string.IsNullOrWhiteSpace(tEmail.Text) ||
                    string.IsNullOrWhiteSpace(tConfirmarPassword.Text) || string.IsNullOrWhiteSpace(tNombreUsuario.Text) ||
                    string.IsNullOrWhiteSpace(tTelefono.Text) || string.IsNullOrWhiteSpace(tPassword.Text) ||
                    cbPerfil.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe completar todos los campos.", "Creación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!checkEmail(tEmail.Text))
                {
                    MessageBox.Show("El email ingresado no es válido.", "Creación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (tPassword.Text != tConfirmarPassword.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Creación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                _usuario = new Usuario();
            }

            using var transaction = _context.Database.BeginTransaction();

            try
            {
                _usuario.Dni = int.Parse(tDNI.Text);
                _usuario.Apellido = tApellido.Text;
                _usuario.Nombre = tNombre.Text;
                _usuario.Email = tEmail.Text;
                _usuario.Telefono = int.Parse(tTelefono.Text);
                _usuario.IdRol = cbPerfil.SelectedIndex + 1;
                _usuario.NombreUsuario = tNombreUsuario.Text;
                _usuario.PlainPassword = tPassword.Text;

                if (_activar)
                    _usuario.Eliminado = false;

                if (_modificacion)
                {
                    _context.SaveChanges();
                    transaction.Commit();
                    MessageBox.Show("El usuario se ha modificado con éxito.", "Modificación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    _context.Usuarios.Add(_usuario);
                    _context.SaveChanges();
                    transaction.Commit();
                    MessageBox.Show("El usuario se ha creado con éxito.", "Creación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (DbUpdateException)
            {
                transaction.Rollback();
                if (_modificacion)
                    MessageBox.Show("Error al modificar el usuario.", "Modificación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Error al crear el usuario.", "Creación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tPassword.ReadOnly = false;
                tConfirmarPassword.ReadOnly = false;
            }
            else
            {
                tPassword.Text = "";
                tConfirmarPassword.Text = "";
                tPassword.ReadOnly = true;
                tConfirmarPassword.ReadOnly = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                _activar = true;
            }
            else
            {
                _activar = false;
            }
        }

        private void tApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
