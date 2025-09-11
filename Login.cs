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

            if (tUsuario.Text == "martin" && tPassword.Text == "1234")
            {
                Administrador admin = new Administrador();
                admin.ShowDialog();
            }
            else if (tUsuario.Text == "maria" && tPassword.Text == "1234")
            {
                Vendedor vendedor = new Vendedor();
                vendedor.ShowDialog();
            }
        }
    }
}
