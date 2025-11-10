using Cumbre_Libros.Models;
using Microsoft.EntityFrameworkCore;

namespace Cumbre_Libros
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            // Los usuarios para login son:
            // administrador: martin
            // contraseña: 1234

            // gerente: jorge
            // contraseña: 1234

            // vendedor: maria
            // contraseña: 1234

            Usuario? user;
            bool pass_ok = false;
            using (var db = new CumbreContext())
            {
                user = db.Usuarios.SingleOrDefault(u => u.NombreUsuario == tUsuario.Text);

                if (user != null && PasswordHelper.VerifyPassword(tPassword.Text, user.Pass, out string? upgradedHash))
                {
                    if (upgradedHash != null)
                    {
                        user.Pass = upgradedHash;
                        db.SaveChanges();
                    }
                    pass_ok = true;
                }
            }

            if (user != null && pass_ok)
            {
                this.Hide();
                tUsuario.Text = "";
                tPassword.Text = "";
                switch (user.IdRol)
                {
                    case 1:
                        Administrador admin = new Administrador(user.Id);
                        admin.ShowDialog();
                        break;
                    case 2:
                        Gerente gerente = new Gerente(user.Id);
                        gerente.ShowDialog();
                        break;
                    case 3:
                        Vendedor vendedor = new Vendedor(user.Id);
                        vendedor.ShowDialog();
                        break;
                    default:
                        break;
                }
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos, intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tPassword.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bInicio_Click(sender, e);
        }

        private void tPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bInicio_Click(sender, e);
        }
    }
}
