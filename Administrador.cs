using Cumbre_Libros.Models;
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
        public Administrador(int ID)
        {
            InitializeComponent();

            var context = new CumbreContext();

            lNombre.Text = context.Usuarios.Find(ID).Nombre;
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

        private void bUsuarios_Click(object sender, EventArgs e)
        {
            var panel_usuarios = new ABM_Usuarios { Dock = DockStyle.Fill };

            pCentral.Controls.Clear();
            pCentral.Controls.Add(panel_usuarios);
        }

        private void bUsuarios_MouseEnter(object sender, EventArgs e)
        {
            bUsuarios.Image = Properties.Resources.icons8_account_male;
        }

        private void bUsuarios_MouseLeave(object sender, EventArgs e)
        {
            bUsuarios.Image = Properties.Resources.icons8_account_male_48;
        }
    }
}
