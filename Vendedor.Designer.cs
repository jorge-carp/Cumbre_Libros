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
            pLateral = new Panel();
            bLogout = new Button();
            bReporte_ventas = new Button();
            bVenta = new Button();
            pCentral = new Panel();
            pLateral.SuspendLayout();
            SuspendLayout();
            // 
            // pLateral
            // 
            pLateral.BackColor = Color.SkyBlue;
            pLateral.Controls.Add(bLogout);
            pLateral.Controls.Add(bReporte_ventas);
            pLateral.Controls.Add(bVenta);
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
            // bReporte_ventas
            // 
            bReporte_ventas.BackColor = Color.White;
            bReporte_ventas.FlatAppearance.BorderColor = Color.White;
            bReporte_ventas.FlatAppearance.BorderSize = 0;
            bReporte_ventas.FlatAppearance.MouseOverBackColor = Color.White;
            bReporte_ventas.FlatStyle = FlatStyle.Flat;
            bReporte_ventas.Image = Properties.Resources.icons8_stocks_growth_48;
            bReporte_ventas.ImageAlign = ContentAlignment.TopCenter;
            bReporte_ventas.Location = new Point(3, 82);
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
            // bVenta
            // 
            bVenta.BackColor = Color.White;
            bVenta.FlatAppearance.BorderColor = Color.White;
            bVenta.FlatAppearance.BorderSize = 0;
            bVenta.FlatAppearance.MouseOverBackColor = Color.White;
            bVenta.FlatStyle = FlatStyle.Flat;
            bVenta.Image = Properties.Resources.icons8_estimate_48;
            bVenta.ImageAlign = ContentAlignment.TopCenter;
            bVenta.Location = new Point(4, 3);
            bVenta.Margin = new Padding(4, 3, 4, 3);
            bVenta.Name = "bVenta";
            bVenta.Size = new Size(89, 73);
            bVenta.TabIndex = 0;
            bVenta.Text = "Caja";
            bVenta.TextAlign = ContentAlignment.BottomCenter;
            bVenta.UseVisualStyleBackColor = false;
            bVenta.MouseEnter += bVenta_MouseEnter;
            bVenta.MouseLeave += bVenta_MouseLeave;
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
            // Vendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(915, 647);
            Controls.Add(pCentral);
            Controls.Add(pLateral);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Vendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cumbre Libros";
            pLateral.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLateral;
        private System.Windows.Forms.Button bVenta;
        private System.Windows.Forms.Button bReporte_ventas;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.Panel pCentral;
    }
}