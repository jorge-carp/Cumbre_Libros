namespace Cumbre_Libros
{
    partial class Administrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pLateral = new Panel();
            bLogout = new Button();
            bBackup = new Button();
            bReporte_ventas = new Button();
            bReportes_personal = new Button();
            bVendedores = new Button();
            bProductos = new Button();
            pCentral = new Panel();
            pLateral.SuspendLayout();
            SuspendLayout();
            // 
            // pLateral
            // 
            pLateral.BackColor = Color.SkyBlue;
            pLateral.Controls.Add(bLogout);
            pLateral.Controls.Add(bBackup);
            pLateral.Controls.Add(bReporte_ventas);
            pLateral.Controls.Add(bReportes_personal);
            pLateral.Controls.Add(bVendedores);
            pLateral.Controls.Add(bProductos);
            pLateral.Location = new Point(14, 14);
            pLateral.Margin = new Padding(4, 3, 4, 3);
            pLateral.Name = "pLateral";
            pLateral.Size = new Size(96, 620);
            pLateral.TabIndex = 0;
            // 
            // bLogout
            // 
            bLogout.BackColor = Color.White;
            bLogout.FlatAppearance.BorderSize = 0;
            bLogout.FlatAppearance.MouseOverBackColor = Color.White;
            bLogout.FlatStyle = FlatStyle.Flat;
            bLogout.Image = Properties.Resources.icons8_logout_48;
            bLogout.ImageAlign = ContentAlignment.TopCenter;
            bLogout.Location = new Point(4, 533);
            bLogout.Margin = new Padding(4, 3, 4, 3);
            bLogout.Name = "bLogout";
            bLogout.Size = new Size(89, 83);
            bLogout.TabIndex = 5;
            bLogout.Text = "Salir";
            bLogout.TextAlign = ContentAlignment.BottomCenter;
            bLogout.UseVisualStyleBackColor = false;
            bLogout.Click += bLogout_Click;
            bLogout.MouseEnter += bLogout_MouseEnter;
            bLogout.MouseLeave += bLogout_MouseLeave;
            // 
            // bBackup
            // 
            bBackup.BackColor = Color.White;
            bBackup.FlatAppearance.BorderSize = 0;
            bBackup.FlatAppearance.MouseOverBackColor = Color.White;
            bBackup.FlatStyle = FlatStyle.Flat;
            bBackup.Image = Properties.Resources.icons8_database_48;
            bBackup.ImageAlign = ContentAlignment.TopCenter;
            bBackup.Location = new Point(4, 387);
            bBackup.Margin = new Padding(4, 3, 4, 3);
            bBackup.Name = "bBackup";
            bBackup.Size = new Size(89, 83);
            bBackup.TabIndex = 4;
            bBackup.Text = "Backup";
            bBackup.TextAlign = ContentAlignment.BottomCenter;
            bBackup.UseVisualStyleBackColor = false;
            bBackup.MouseEnter += bBackup_MouseEnter;
            bBackup.MouseLeave += bBackup_MouseLeave;
            // 
            // bReporte_ventas
            // 
            bReporte_ventas.BackColor = Color.White;
            bReporte_ventas.FlatAppearance.BorderColor = Color.White;
            bReporte_ventas.FlatAppearance.BorderSize = 0;
            bReporte_ventas.FlatAppearance.MouseOverBackColor = Color.White;
            bReporte_ventas.FlatStyle = FlatStyle.Flat;
            bReporte_ventas.Image = Properties.Resources.icons8_stocks_growth_48;
            bReporte_ventas.ImageAlign = ContentAlignment.TopCenter;
            bReporte_ventas.Location = new Point(4, 285);
            bReporte_ventas.Margin = new Padding(4, 3, 4, 3);
            bReporte_ventas.Name = "bReporte_ventas";
            bReporte_ventas.Size = new Size(89, 95);
            bReporte_ventas.TabIndex = 3;
            bReporte_ventas.Text = "Reporte de ventas";
            bReporte_ventas.TextAlign = ContentAlignment.BottomCenter;
            bReporte_ventas.UseVisualStyleBackColor = false;
            bReporte_ventas.MouseEnter += bReporte_ventas_MouseEnter;
            bReporte_ventas.MouseLeave += bReporte_ventas_MouseLeave;
            // 
            // bReportes_personal
            // 
            bReportes_personal.BackColor = Color.White;
            bReportes_personal.FlatAppearance.BorderColor = Color.White;
            bReportes_personal.FlatAppearance.BorderSize = 0;
            bReportes_personal.FlatAppearance.MouseOverBackColor = Color.White;
            bReportes_personal.FlatStyle = FlatStyle.Flat;
            bReportes_personal.Image = Properties.Resources.icons8_analytics_48;
            bReportes_personal.ImageAlign = ContentAlignment.TopCenter;
            bReportes_personal.Location = new Point(4, 183);
            bReportes_personal.Margin = new Padding(4, 3, 4, 3);
            bReportes_personal.Name = "bReportes_personal";
            bReportes_personal.Size = new Size(89, 95);
            bReportes_personal.TabIndex = 2;
            bReportes_personal.Text = "Reporte de personal";
            bReportes_personal.TextAlign = ContentAlignment.BottomCenter;
            bReportes_personal.UseVisualStyleBackColor = false;
            bReportes_personal.MouseEnter += bReportes_personal_MouseEnter;
            bReportes_personal.MouseLeave += bReportes_personal_MouseLeave;
            // 
            // bVendedores
            // 
            bVendedores.BackColor = Color.White;
            bVendedores.FlatAppearance.BorderSize = 0;
            bVendedores.FlatAppearance.MouseOverBackColor = Color.White;
            bVendedores.FlatStyle = FlatStyle.Flat;
            bVendedores.Image = Properties.Resources.icons8_account_male_48;
            bVendedores.ImageAlign = ContentAlignment.TopCenter;
            bVendedores.Location = new Point(4, 93);
            bVendedores.Margin = new Padding(4, 3, 4, 3);
            bVendedores.Name = "bVendedores";
            bVendedores.Size = new Size(89, 83);
            bVendedores.TabIndex = 1;
            bVendedores.Text = "Vendedores";
            bVendedores.TextAlign = ContentAlignment.BottomCenter;
            bVendedores.UseVisualStyleBackColor = false;
            bVendedores.MouseEnter += bVendedores_MouseEnter;
            bVendedores.MouseLeave += bVendedores_MouseLeave;
            // 
            // bProductos
            // 
            bProductos.BackColor = Color.White;
            bProductos.FlatAppearance.BorderColor = Color.White;
            bProductos.FlatAppearance.BorderSize = 0;
            bProductos.FlatAppearance.MouseOverBackColor = Color.White;
            bProductos.FlatStyle = FlatStyle.Flat;
            bProductos.Image = Properties.Resources.icons8_book_48;
            bProductos.ImageAlign = ContentAlignment.TopCenter;
            bProductos.Location = new Point(4, 3);
            bProductos.Margin = new Padding(4, 3, 4, 3);
            bProductos.Name = "bProductos";
            bProductos.Size = new Size(89, 83);
            bProductos.TabIndex = 0;
            bProductos.Text = "Productos";
            bProductos.TextAlign = ContentAlignment.BottomCenter;
            bProductos.UseVisualStyleBackColor = false;
            bProductos.MouseEnter += bProductos_MouseEnter;
            bProductos.MouseLeave += bProductos_MouseLeave;
            // 
            // pCentral
            // 
            pCentral.BackColor = Color.WhiteSmoke;
            pCentral.Location = new Point(117, 17);
            pCentral.Margin = new Padding(4, 3, 4, 3);
            pCentral.Name = "pCentral";
            pCentral.Size = new Size(784, 613);
            pCentral.TabIndex = 1;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(915, 647);
            Controls.Add(pCentral);
            Controls.Add(pLateral);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Administrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cumbre Libros";
            pLateral.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLateral;
        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bVendedores;
        private System.Windows.Forms.Button bReportes_personal;
        private System.Windows.Forms.Button bReporte_ventas;
        private System.Windows.Forms.Button bBackup;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.Panel pCentral;
    }
}