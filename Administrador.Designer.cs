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
            this.pLateral = new System.Windows.Forms.Panel();
            this.bLogout = new System.Windows.Forms.Button();
            this.bBackup = new System.Windows.Forms.Button();
            this.bReporte_ventas = new System.Windows.Forms.Button();
            this.bReportes_personal = new System.Windows.Forms.Button();
            this.bVendedores = new System.Windows.Forms.Button();
            this.bProductos = new System.Windows.Forms.Button();
            this.pCentral = new System.Windows.Forms.Panel();
            this.pLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLateral
            // 
            this.pLateral.BackColor = System.Drawing.Color.SkyBlue;
            this.pLateral.Controls.Add(this.bLogout);
            this.pLateral.Controls.Add(this.bBackup);
            this.pLateral.Controls.Add(this.bReporte_ventas);
            this.pLateral.Controls.Add(this.bReportes_personal);
            this.pLateral.Controls.Add(this.bVendedores);
            this.pLateral.Controls.Add(this.bProductos);
            this.pLateral.Location = new System.Drawing.Point(12, 12);
            this.pLateral.Name = "pLateral";
            this.pLateral.Size = new System.Drawing.Size(82, 537);
            this.pLateral.TabIndex = 0;
            // 
            // bLogout
            // 
            this.bLogout.BackColor = System.Drawing.Color.White;
            this.bLogout.FlatAppearance.BorderSize = 0;
            this.bLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogout.Image = global::Cumbre_Libros.Properties.Resources.icons8_logout_48;
            this.bLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bLogout.Location = new System.Drawing.Point(3, 462);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(76, 72);
            this.bLogout.TabIndex = 5;
            this.bLogout.Text = "Salir";
            this.bLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bLogout.UseVisualStyleBackColor = false;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            this.bLogout.MouseEnter += new System.EventHandler(this.bLogout_MouseEnter);
            this.bLogout.MouseLeave += new System.EventHandler(this.bLogout_MouseLeave);
            // 
            // bBackup
            // 
            this.bBackup.BackColor = System.Drawing.Color.White;
            this.bBackup.FlatAppearance.BorderSize = 0;
            this.bBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBackup.Image = global::Cumbre_Libros.Properties.Resources.icons8_database_48;
            this.bBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bBackup.Location = new System.Drawing.Point(3, 335);
            this.bBackup.Name = "bBackup";
            this.bBackup.Size = new System.Drawing.Size(76, 72);
            this.bBackup.TabIndex = 4;
            this.bBackup.Text = "Backup";
            this.bBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bBackup.UseVisualStyleBackColor = false;
            this.bBackup.MouseEnter += new System.EventHandler(this.bBackup_MouseEnter);
            this.bBackup.MouseLeave += new System.EventHandler(this.bBackup_MouseLeave);
            // 
            // bReporte_ventas
            // 
            this.bReporte_ventas.BackColor = System.Drawing.Color.White;
            this.bReporte_ventas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bReporte_ventas.FlatAppearance.BorderSize = 0;
            this.bReporte_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bReporte_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReporte_ventas.Image = global::Cumbre_Libros.Properties.Resources.icons8_stocks_growth_48;
            this.bReporte_ventas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bReporte_ventas.Location = new System.Drawing.Point(3, 247);
            this.bReporte_ventas.Name = "bReporte_ventas";
            this.bReporte_ventas.Size = new System.Drawing.Size(76, 82);
            this.bReporte_ventas.TabIndex = 3;
            this.bReporte_ventas.Text = "Reporte de ventas";
            this.bReporte_ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bReporte_ventas.UseVisualStyleBackColor = false;
            this.bReporte_ventas.MouseEnter += new System.EventHandler(this.bReporte_ventas_MouseEnter);
            this.bReporte_ventas.MouseLeave += new System.EventHandler(this.bReporte_ventas_MouseLeave);
            // 
            // bReportes_personal
            // 
            this.bReportes_personal.BackColor = System.Drawing.Color.White;
            this.bReportes_personal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bReportes_personal.FlatAppearance.BorderSize = 0;
            this.bReportes_personal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bReportes_personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReportes_personal.Image = global::Cumbre_Libros.Properties.Resources.icons8_analytics_48;
            this.bReportes_personal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bReportes_personal.Location = new System.Drawing.Point(3, 159);
            this.bReportes_personal.Name = "bReportes_personal";
            this.bReportes_personal.Size = new System.Drawing.Size(76, 82);
            this.bReportes_personal.TabIndex = 2;
            this.bReportes_personal.Text = "Reporte de personal";
            this.bReportes_personal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bReportes_personal.UseVisualStyleBackColor = false;
            this.bReportes_personal.MouseEnter += new System.EventHandler(this.bReportes_personal_MouseEnter);
            this.bReportes_personal.MouseLeave += new System.EventHandler(this.bReportes_personal_MouseLeave);
            // 
            // bVendedores
            // 
            this.bVendedores.BackColor = System.Drawing.Color.White;
            this.bVendedores.FlatAppearance.BorderSize = 0;
            this.bVendedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVendedores.Image = global::Cumbre_Libros.Properties.Resources.icons8_account_male_48;
            this.bVendedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bVendedores.Location = new System.Drawing.Point(3, 81);
            this.bVendedores.Name = "bVendedores";
            this.bVendedores.Size = new System.Drawing.Size(76, 72);
            this.bVendedores.TabIndex = 1;
            this.bVendedores.Text = "Vendedores";
            this.bVendedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bVendedores.UseVisualStyleBackColor = false;
            this.bVendedores.MouseEnter += new System.EventHandler(this.bVendedores_MouseEnter);
            this.bVendedores.MouseLeave += new System.EventHandler(this.bVendedores_MouseLeave);
            // 
            // bProductos
            // 
            this.bProductos.BackColor = System.Drawing.Color.White;
            this.bProductos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bProductos.FlatAppearance.BorderSize = 0;
            this.bProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProductos.Image = global::Cumbre_Libros.Properties.Resources.icons8_book_48;
            this.bProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bProductos.Location = new System.Drawing.Point(3, 3);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(76, 72);
            this.bProductos.TabIndex = 0;
            this.bProductos.Text = "Productos";
            this.bProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bProductos.UseVisualStyleBackColor = false;
            this.bProductos.MouseEnter += new System.EventHandler(this.bProductos_MouseEnter);
            this.bProductos.MouseLeave += new System.EventHandler(this.bProductos_MouseLeave);
            // 
            // pCentral
            // 
            this.pCentral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pCentral.Location = new System.Drawing.Point(100, 15);
            this.pCentral.Name = "pCentral";
            this.pCentral.Size = new System.Drawing.Size(672, 531);
            this.pCentral.TabIndex = 1;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pCentral);
            this.Controls.Add(this.pLateral);
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.pLateral.ResumeLayout(false);
            this.ResumeLayout(false);

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