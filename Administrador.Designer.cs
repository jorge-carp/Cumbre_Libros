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
            bUsuarios = new Button();
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
            pLateral.Controls.Add(bLogout);
            pLateral.Controls.Add(bBackup);
            pLateral.Controls.Add(bUsuarios);
            pLateral.Location = new Point(0, 46);
            pLateral.Margin = new Padding(4, 3, 4, 3);
            pLateral.Name = "pLateral";
            pLateral.Size = new Size(95, 600);
            pLateral.TabIndex = 0;
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
            // bBackup
            // 
            bBackup.BackColor = Color.White;
            bBackup.FlatAppearance.BorderSize = 0;
            bBackup.FlatAppearance.MouseOverBackColor = Color.White;
            bBackup.FlatStyle = FlatStyle.Flat;
            bBackup.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bBackup.Image = Properties.Resources.icons8_database_48;
            bBackup.ImageAlign = ContentAlignment.TopCenter;
            bBackup.Location = new Point(5, 91);
            bBackup.Margin = new Padding(4, 3, 4, 3);
            bBackup.Name = "bBackup";
            bBackup.Size = new Size(85, 80);
            bBackup.TabIndex = 4;
            bBackup.Text = "Backup";
            bBackup.TextAlign = ContentAlignment.BottomCenter;
            bBackup.UseVisualStyleBackColor = false;
            bBackup.MouseEnter += bBackup_MouseEnter;
            bBackup.MouseLeave += bBackup_MouseLeave;
            // 
            // bUsuarios
            // 
            bUsuarios.BackColor = Color.White;
            bUsuarios.FlatAppearance.BorderSize = 0;
            bUsuarios.FlatAppearance.MouseOverBackColor = Color.White;
            bUsuarios.FlatStyle = FlatStyle.Flat;
            bUsuarios.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bUsuarios.Image = Properties.Resources.icons8_account_male_48;
            bUsuarios.ImageAlign = ContentAlignment.TopCenter;
            bUsuarios.Location = new Point(5, 5);
            bUsuarios.Margin = new Padding(4, 3, 4, 3);
            bUsuarios.Name = "bUsuarios";
            bUsuarios.Size = new Size(85, 80);
            bUsuarios.TabIndex = 1;
            bUsuarios.Text = "Usuarios";
            bUsuarios.TextAlign = ContentAlignment.BottomCenter;
            bUsuarios.UseVisualStyleBackColor = false;
            bUsuarios.Click += bUsuarios_Click;
            bUsuarios.MouseEnter += bUsuarios_MouseEnter;
            bUsuarios.MouseLeave += bUsuarios_MouseLeave;
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
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(915, 647);
            Controls.Add(pSuperior);
            Controls.Add(pCentral);
            Controls.Add(pLateral);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Administrador";
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
        private System.Windows.Forms.Button bBackup;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.Panel pCentral;
        private Panel pSuperior;
        private PictureBox pictureBox1;
        private Button bUsuarios;
        private PictureBox pictureBox2;
        private Label lNombre;
        private Label lBienvenida;
    }
}