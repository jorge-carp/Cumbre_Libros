namespace Cumbre_Libros
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lUsuario = new Label();
            lPassword = new Label();
            tUsuario = new TextBox();
            tPassword = new TextBox();
            bInicio = new Button();
            checkBox1 = new CheckBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lUsuario
            // 
            lUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lUsuario.Image = Properties.Resources.icons8_profile_24;
            lUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            lUsuario.Location = new Point(39, 118);
            lUsuario.Margin = new Padding(4, 0, 4, 0);
            lUsuario.MaximumSize = new Size(200, 200);
            lUsuario.Name = "lUsuario";
            lUsuario.Size = new Size(30, 36);
            lUsuario.TabIndex = 0;
            lUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lPassword
            // 
            lPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lPassword.Image = Properties.Resources.icons8_lock_24;
            lPassword.ImageAlign = ContentAlignment.MiddleLeft;
            lPassword.Location = new Point(39, 172);
            lPassword.Margin = new Padding(4, 0, 4, 0);
            lPassword.Name = "lPassword";
            lPassword.Size = new Size(30, 28);
            lPassword.TabIndex = 1;
            lPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tUsuario
            // 
            tUsuario.Location = new Point(77, 127);
            tUsuario.Margin = new Padding(4, 3, 4, 3);
            tUsuario.Name = "tUsuario";
            tUsuario.Size = new Size(116, 23);
            tUsuario.TabIndex = 2;
            // 
            // tPassword
            // 
            tPassword.Location = new Point(77, 177);
            tPassword.Margin = new Padding(4, 3, 4, 3);
            tPassword.Name = "tPassword";
            tPassword.Size = new Size(116, 23);
            tPassword.TabIndex = 3;
            tPassword.UseSystemPasswordChar = true;
            // 
            // bInicio
            // 
            bInicio.Image = Properties.Resources.icons8_login_36;
            bInicio.ImageAlign = ContentAlignment.MiddleLeft;
            bInicio.Location = new Point(39, 222);
            bInicio.Margin = new Padding(4, 3, 4, 3);
            bInicio.Name = "bInicio";
            bInicio.Size = new Size(92, 39);
            bInicio.TabIndex = 4;
            bInicio.Text = "Ingresar";
            bInicio.TextAlign = ContentAlignment.MiddleRight;
            bInicio.UseVisualStyleBackColor = true;
            bInicio.Click += bInicio_Click;
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.AutoSize = true;
            checkBox1.Image = Properties.Resources.icons8_hide_24;
            checkBox1.Location = new Point(200, 172);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(30, 30);
            checkBox1.TabIndex = 5;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icons8_cancel_36;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(139, 222);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(76, 39);
            button1.TabIndex = 6;
            button1.Text = "Salir";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(39, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 83);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 8;
            label1.Text = "Sistema de gestión";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 285);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(bInicio);
            Controls.Add(tPassword);
            Controls.Add(tUsuario);
            Controls.Add(lPassword);
            Controls.Add(lUsuario);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cumbre Libros";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button bInicio;
        private CheckBox checkBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
