namespace Cumbre_Libros
{
    partial class Vendedor
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
            this.pCentral = new System.Windows.Forms.Panel();
            this.bLogout = new System.Windows.Forms.Button();
            this.bReporte_ventas = new System.Windows.Forms.Button();
            this.bVenta = new System.Windows.Forms.Button();
            this.pLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLateral
            // 
            this.pLateral.BackColor = System.Drawing.Color.SkyBlue;
            this.pLateral.Controls.Add(this.bLogout);
            this.pLateral.Controls.Add(this.bReporte_ventas);
            this.pLateral.Controls.Add(this.bVenta);
            this.pLateral.Location = new System.Drawing.Point(12, 12);
            this.pLateral.Name = "pLateral";
            this.pLateral.Size = new System.Drawing.Size(82, 537);
            this.pLateral.TabIndex = 0;
            // 
            // pCentral
            // 
            this.pCentral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pCentral.Location = new System.Drawing.Point(100, 15);
            this.pCentral.Name = "pCentral";
            this.pCentral.Size = new System.Drawing.Size(672, 531);
            this.pCentral.TabIndex = 1;
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
            // bReporte_ventas
            // 
            this.bReporte_ventas.BackColor = System.Drawing.Color.White;
            this.bReporte_ventas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bReporte_ventas.FlatAppearance.BorderSize = 0;
            this.bReporte_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bReporte_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReporte_ventas.Image = global::Cumbre_Libros.Properties.Resources.icons8_stocks_growth_48;
            this.bReporte_ventas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bReporte_ventas.Location = new System.Drawing.Point(3, 81);
            this.bReporte_ventas.Name = "bReporte_ventas";
            this.bReporte_ventas.Size = new System.Drawing.Size(76, 82);
            this.bReporte_ventas.TabIndex = 3;
            this.bReporte_ventas.Text = "Reporte de ventas";
            this.bReporte_ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bReporte_ventas.UseVisualStyleBackColor = false;
            this.bReporte_ventas.MouseEnter += new System.EventHandler(this.bReporte_ventas_MouseEnter);
            this.bReporte_ventas.MouseLeave += new System.EventHandler(this.bReporte_ventas_MouseLeave);
            // 
            // bVenta
            // 
            this.bVenta.BackColor = System.Drawing.Color.White;
            this.bVenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bVenta.FlatAppearance.BorderSize = 0;
            this.bVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVenta.Image = global::Cumbre_Libros.Properties.Resources.icons8_estimate_48;
            this.bVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bVenta.Location = new System.Drawing.Point(3, 3);
            this.bVenta.Name = "bVenta";
            this.bVenta.Size = new System.Drawing.Size(76, 72);
            this.bVenta.TabIndex = 0;
            this.bVenta.Text = "Productos";
            this.bVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bVenta.UseVisualStyleBackColor = false;
            this.bVenta.MouseEnter += new System.EventHandler(this.bVenta_MouseEnter);
            this.bVenta.MouseLeave += new System.EventHandler(this.bVenta_MouseLeave);
            // 
            // Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pCentral);
            this.Controls.Add(this.pLateral);
            this.Name = "Vendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cumbre Libros";
            this.pLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLateral;
        private System.Windows.Forms.Button bVenta;
        private System.Windows.Forms.Button bReporte_ventas;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.Panel pCentral;
    }
}