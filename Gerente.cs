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
    public partial class Gerente : Form
    {
        public Gerente(string nombre)
        {
            InitializeComponent();

            lNombre.Text = nombre;
        }

        private void bVendedores_MouseLeave(object sender, EventArgs e)
        {
            bVendedores.Image = Properties.Resources.icons8_account_male_48;
        }

        private void bVendedores_MouseEnter(object sender, EventArgs e)
        {
            bVendedores.Image = Properties.Resources.icons8_account_male;
        }

        private void bLogout_MouseEnter(object sender, EventArgs e)
        {
            bLogout.Image = Properties.Resources.icons8_logout;
        }

        private void bLogout_MouseLeave(object sender, EventArgs e)
        {
            bLogout.Image = Properties.Resources.icons8_logout_48;
        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bVendedores_Click(object sender, EventArgs e)
        {

        }

        private void bProductos_Click(object sender, EventArgs e)
        {

        }

        private void bProductos_MouseEnter(object sender, EventArgs e)
        {
            bProductos.Image = Properties.Resources.icons8_book;
        }

        private void bProductos_MouseLeave(object sender, EventArgs e)
        {
            bProductos.Image = Properties.Resources.icons8_book_48;
        }

        private void bVentas_Click(object sender, EventArgs e)
        {

        }

        private void bVentas_MouseEnter(object sender, EventArgs e)
        {
            bVentas.Image = Properties.Resources.icons8_stocks_growth;
        }

        private void bVentas_MouseLeave(object sender, EventArgs e)
        {
            bVentas.Image = Properties.Resources.icons8_stocks_growth_48;
        }
    }
}
