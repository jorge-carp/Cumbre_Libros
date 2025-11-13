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
    public partial class Backup : UserControl
    {
        public Backup()
        {
            InitializeComponent();

            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.LastExportPath))
            {
                lPath.Text = "Último backup: " + Properties.Settings.Default.LastExportPath;
            }
            if (Properties.Settings.Default.LastExportDate != DateTime.MinValue)
            {
                lDate.Text = "Fecha: " + Properties.Settings.Default.LastExportDate;
            }
        }

        private void bExportar_Click(object sender, EventArgs e)
        {
            string workingDir = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(Directory.GetParent(workingDir).Parent.Parent.Parent.FullName, "cumbre.db");

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Exportar Base de Datos";
                sfd.Filter = "SQLite Database (*.db)|*.db";
                var fecha = DateTime.Now;

                sfd.FileName = $"Backup_cumbre_{fecha:ddMMyyyy_HHmmss}.db";
                Properties.Settings.Default.LastExportPath = sfd.FileName;
                Properties.Settings.Default.LastExportDate = fecha;
                Properties.Settings.Default.Save();

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Copy(filePath, sfd.FileName, overwrite: true);
                        MessageBox.Show("Base de Datos exportada exitosamente.", "Exportar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        lPath.Text = "Último backup: " + Properties.Settings.Default.LastExportPath;
                        lDate.Text = "Fecha: " + Properties.Settings.Default.LastExportDate;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exportando la base de datos:\n{ex.Message}", "Exportar",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
