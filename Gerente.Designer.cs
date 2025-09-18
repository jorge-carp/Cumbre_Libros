namespace Cumbre_Libros
{
    partial class Gerente
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
            bVentas = new Button();
            bLogout = new Button();
            bProductos = new Button();
            bVendedores = new Button();
            pCentral = new Panel();
            lNombre = new Label();
            lBienvenida = new Label();
            pictureBox2 = new PictureBox();
            pSuperior = new Panel();
            pictureBox1 = new PictureBox();
            pLateral.SuspendLayout();
            pCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pLateral
            // 
            pLateral.BackColor = Color.SteelBlue;
            pLateral.Controls.Add(bVentas);
            pLateral.Controls.Add(bLogout);
            pLateral.Controls.Add(bProductos);
            pLateral.Controls.Add(bVendedores);
            pLateral.Location = new Point(0, 46);
            pLateral.Margin = new Padding(4, 3, 4, 3);
            pLateral.Name = "pLateral";
            pLateral.Size = new Size(95, 600);
            pLateral.TabIndex = 0;
            // 
            // bVentas
            // 
            bVentas.BackColor = Color.White;
            bVentas.FlatAppearance.BorderSize = 0;
            bVentas.FlatAppearance.MouseOverBackColor = Color.White;
            bVentas.FlatStyle = FlatStyle.Flat;
            bVentas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bVentas.Image = Properties.Resources.icons8_stocks_growth_48;
            bVentas.ImageAlign = ContentAlignment.TopCenter;
            bVentas.Location = new Point(5, 177);
            bVentas.Margin = new Padding(4, 3, 4, 3);
            bVentas.Name = "bVentas";
            bVentas.Size = new Size(85, 90);
            bVentas.TabIndex = 6;
            bVentas.Text = "Reporte de Ventas";
            bVentas.TextAlign = ContentAlignment.BottomCenter;
            bVentas.UseVisualStyleBackColor = false;
            bVentas.Click += bVentas_Click;
            bVentas.MouseEnter += bVentas_MouseEnter;
            bVentas.MouseLeave += bVentas_MouseLeave;
            // 
            // bLogout
            // 
            bLogout.BackColor = Color.White;
            bLogout.FlatAppearance.BorderSize = 0;
            bLogout.FlatAppearance.MouseOverBackColor = Color.White;
            bLogout.FlatStyle = FlatStyle.Flat;
            bLogout.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bLogout.Image = Properties.Resources.icons8_logout_48;
            bLogout.ImageAlign = ContentAlignment.TopCenter;
            bLogout.Location = new Point(5, 515);
            bLogout.Margin = new Padding(4, 3, 4, 3);
            bLogout.Name = "bLogout";
            bLogout.Size = new Size(85, 80);
            bLogout.TabIndex = 5;
            bLogout.Text = "Salir";
            bLogout.TextAlign = ContentAlignment.BottomCenter;
            bLogout.UseVisualStyleBackColor = false;
            bLogout.Click += bLogout_Click;
            bLogout.MouseEnter += bLogout_MouseEnter;
            bLogout.MouseLeave += bLogout_MouseLeave;
            // 
            // bProductos
            // 
            bProductos.BackColor = Color.White;
            bProductos.FlatAppearance.BorderSize = 0;
            bProductos.FlatAppearance.MouseOverBackColor = Color.White;
            bProductos.FlatStyle = FlatStyle.Flat;
            bProductos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bProductos.Image = Properties.Resources.icons8_book_48;
            bProductos.ImageAlign = ContentAlignment.TopCenter;
            bProductos.Location = new Point(5, 91);
            bProductos.Margin = new Padding(4, 3, 4, 3);
            bProductos.Name = "bProductos";
            bProductos.Size = new Size(85, 80);
            bProductos.TabIndex = 4;
            bProductos.Text = "Productos";
            bProductos.TextAlign = ContentAlignment.BottomCenter;
            bProductos.UseVisualStyleBackColor = false;
            bProductos.Click += bProductos_Click;
            bProductos.MouseEnter += bProductos_MouseEnter;
            bProductos.MouseLeave += bProductos_MouseLeave;
            // 
            // bVendedores
            // 
            bVendedores.BackColor = Color.White;
            bVendedores.FlatAppearance.BorderSize = 0;
            bVendedores.FlatAppearance.MouseOverBackColor = Color.White;
            bVendedores.FlatStyle = FlatStyle.Flat;
            bVendedores.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bVendedores.Image = Properties.Resources.icons8_account_male_48;
            bVendedores.ImageAlign = ContentAlignment.TopCenter;
            bVendedores.Location = new Point(5, 5);
            bVendedores.Margin = new Padding(4, 3, 4, 3);
            bVendedores.Name = "bVendedores";
            bVendedores.Size = new Size(86, 80);
            bVendedores.TabIndex = 1;
            bVendedores.Text = "Vendedores";
            bVendedores.TextAlign = ContentAlignment.BottomCenter;
            bVendedores.UseVisualStyleBackColor = false;
            bVendedores.Click += bVendedores_Click;
            bVendedores.MouseEnter += bVendedores_MouseEnter;
            bVendedores.MouseLeave += bVendedores_MouseLeave;
            // 
            // pCentral
            // 
            pCentral.BackColor = Color.WhiteSmoke;
            pCentral.Controls.Add(lNombre);
            pCentral.Controls.Add(lBienvenida);
            pCentral.Controls.Add(pictureBox2);
            pCentral.Location = new Point(95, 46);
            pCentral.Margin = new Padding(4, 3, 4, 3);
            pCentral.Name = "pCentral";
            pCentral.Size = new Size(820, 600);
            pCentral.TabIndex = 1;
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.BackColor = Color.WhiteSmoke;
            lNombre.Font = new Font("Segoe Script", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lNombre.ForeColor = Color.DodgerBlue;
            lNombre.Location = new Point(433, 290);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(0, 58);
            lNombre.TabIndex = 2;
            // 
            // lBienvenida
            // 
            lBienvenida.AutoSize = true;
            lBienvenida.Font = new Font("Segoe Script", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lBienvenida.Location = new Point(176, 290);
            lBienvenida.Name = "lBienvenida";
            lBienvenida.Size = new Size(251, 58);
            lBienvenida.TabIndex = 1;
            lBienvenida.Text = "Bienvenido";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_upscaled;
            pictureBox2.Location = new Point(223, 147);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(350, 127);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pSuperior
            // 
            pSuperior.BackColor = Color.SteelBlue;
            pSuperior.Controls.Add(pictureBox1);
            pSuperior.Location = new Point(0, 0);
            pSuperior.Name = "pSuperior";
            pSuperior.Size = new Size(915, 45);
            pSuperior.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 45);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Gerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(915, 647);
            Controls.Add(pSuperior);
            Controls.Add(pCentral);
            Controls.Add(pLateral);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Gerente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cumbre Libros";
            pLateral.ResumeLayout(false);
            pCentral.ResumeLayout(false);
            pCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLateral;
        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.Panel pCentral;
        private Panel pSuperior;
        private PictureBox pictureBox1;
        private Button bVendedores;
        private PictureBox pictureBox2;
        private Label lNombre;
        private Label lBienvenida;
        private Button bVentas;
    }
}