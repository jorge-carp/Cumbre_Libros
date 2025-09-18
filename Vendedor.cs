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
    public partial class Vendedor : Form
    {
        public Vendedor(string nombre)
        {
            InitializeComponent();

            lNombre.Text = nombre;
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

        private void bCaja_Click(object sender, EventArgs e)
        {

        }

        private void bCaja_MouseEnter(object sender, EventArgs e)
        {
            bCaja.Image = Properties.Resources.icons8_estimate;
        }

        private void bCaja_MouseLeave(object sender, EventArgs e)
        {
            bCaja.Image = Properties.Resources.icons8_estimate_48;
        }

        private void bReporte_Click(object sender, EventArgs e)
        {

        }

        private void bReporte_MouseEnter(object sender, EventArgs e)
        {
            bReporte.Image = Properties.Resources.icons8_stocks_growth;
        }

        private void bReporte_MouseLeave(object sender, EventArgs e)
        {
            bReporte.Image = Properties.Resources.icons8_stocks_growth_48;
        }
    }
}
