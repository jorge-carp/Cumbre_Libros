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

            using var db = new CumbreContext();

            var user = db.Usuarios.SingleOrDefault(u => u.NombreUsuario == tUsuario.Text);

            if (user != null && PasswordHelper.VerifyPassword(tPassword.Text, user.Pass, out string? upgradedHash))
            {
                if (upgradedHash != null)
                {
                    user.Pass = upgradedHash;
                    db.SaveChanges();
                }

                this.Hide();
                tUsuario.Text = "";
                tPassword.Text = "";

                switch (user.IdRol)
                {
                    case 1:
                        Administrador admin = new Administrador(user.Nombre);
                        admin.ShowDialog();
                        break;

                    case 2:
                        Gerente gerente = new Gerente(user.Nombre);
                        gerente.ShowDialog();
                        break;

                    case 3:
                        Vendedor vendedor = new Vendedor(user.Nombre);
                        vendedor.ShowDialog();
                        break;

                    default:
                        break;
                }

                this.Show();
            }
            else
                MessageBox.Show("Usuario o Contraseña Incorrectos Intente De Nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
