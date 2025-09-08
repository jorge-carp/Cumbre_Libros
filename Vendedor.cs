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
        public Vendedor()
        {
            InitializeComponent();
        }

        private void bReporte_ventas_MouseEnter(object sender, EventArgs e)
        {
            bReporte_ventas.Image = Properties.Resources.icons8_stocks_growth;
        }

        private void bReporte_ventas_MouseLeave(object sender, EventArgs e)
        {
            bReporte_ventas.Image = Properties.Resources.icons8_stocks_growth_48;
        }

        private void bLogout_MouseEnter(object sender, EventArgs e)
        {
            bLogout.Image = Properties.Resources.icons8_logout;
        }

        private void bLogout_MouseLeave(object sender, EventArgs e)
        {
            bLogout.Image = Properties.Resources.icons8_logout_48;
        }

        private void bVenta_MouseEnter(object sender, EventArgs e)
        {
            bVenta.Image = Properties.Resources.icons8_estimate;
        }

        private void bVenta_MouseLeave(object sender, EventArgs e)
        {
            bVenta.Image = Properties.Resources.icons8_estimate_48;
        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
