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

            // vendedor: maria
            // contraseña: 1234

            using (var db = new CumbreContext())
            {
                Usuarios usuario = (from user in db.Usuarios
                                    where user.NombreUsuario == tUsuario.Text
                                    where user.Pass == tPassword.Text
                                    select user).First();

                if (usuario != null)
                {
                    switch (usuario.IdRol)
                    {
                        case 1:
                            Administrador admin = new Administrador();
                            admin.ShowDialog();
                            break;

                        case 2:
                            Vendedor vendedor = new Vendedor();
                            vendedor.ShowDialog();
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos Intente De Nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
