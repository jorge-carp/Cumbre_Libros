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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void bVendedores_MouseLeave(object sender, EventArgs e)
        {
            bVendedores.Image = Properties.Resources.icons8_account_male_48;
        }

        private void bVendedores_MouseEnter(object sender, EventArgs e)
        {
            bVendedores.Image = Properties.Resources.icons8_account_male;
        }

        private void bProductos_MouseEnter(object sender, EventArgs e)
        {
            bProductos.Image = Properties.Resources.icons8_book;
        }

        private void bProductos_MouseLeave(object sender, EventArgs e)
        {
            bProductos.Image = Properties.Resources.icons8_book_48;
        }

        private void bReportes_personal_MouseEnter(object sender, EventArgs e)
        {
            bReportes_personal.Image = Properties.Resources.icons8_analytics;
        }

        private void bReportes_personal_MouseLeave(object sender, EventArgs e)
        {
            bReportes_personal.Image = Properties.Resources.icons8_analytics_48;
        }

        private void bReporte_ventas_MouseEnter(object sender, EventArgs e)
        {
            bReporte_ventas.Image = Properties.Resources.icons8_stocks_growth;
        }

        private void bReporte_ventas_MouseLeave(object sender, EventArgs e)
        {
            bReporte_ventas.Image = Properties.Resources.icons8_stocks_growth_48;
        }

        private void bBackup_MouseEnter(object sender, EventArgs e)
        {
            bBackup.Image = Properties.Resources.icons8_database;
        }

        private void bBackup_MouseLeave(object sender, EventArgs e)
        {
            bBackup.Image = Properties.Resources.icons8_database_48;
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
    }
}
