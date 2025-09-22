namespace Cumbre_Libros
{
    partial class Editar_Usuario
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label9 = new Label();
            tConfirmarPassword = new TextBox();
            cbPerfil = new ComboBox();
            tPassword = new TextBox();
            tNombreUsuario = new TextBox();
            tTelefono = new TextBox();
            tEmail = new TextBox();
            tNombre = new TextBox();
            tApellido = new TextBox();
            tDNI = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            bGuardar = new Button();
            bCancelar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 45);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tConfirmarPassword);
            groupBox1.Controls.Add(cbPerfil);
            groupBox1.Controls.Add(tPassword);
            groupBox1.Controls.Add(tNombreUsuario);
            groupBox1.Controls.Add(tTelefono);
            groupBox1.Controls.Add(tEmail);
            groupBox1.Controls.Add(tNombre);
            groupBox1.Controls.Add(tApellido);
            groupBox1.Controls.Add(tDNI);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 442);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(171, 413);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(105, 19);
            checkBox2.TabIndex = 20;
            checkBox2.Text = "Activar usuario";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Visible = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(17, 413);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(138, 19);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Modificar contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(7, 379);
            label9.Name = "label9";
            label9.Size = new Size(149, 20);
            label9.TabIndex = 18;
            label9.Text = "Confimar contraseña:";
            // 
            // tConfirmarPassword
            // 
            tConfirmarPassword.Location = new Point(165, 376);
            tConfirmarPassword.Name = "tConfirmarPassword";
            tConfirmarPassword.ReadOnly = true;
            tConfirmarPassword.Size = new Size(121, 23);
            tConfirmarPassword.TabIndex = 17;
            // 
            // cbPerfil
            // 
            cbPerfil.FormattingEnabled = true;
            cbPerfil.Location = new Point(165, 264);
            cbPerfil.Name = "cbPerfil";
            cbPerfil.Size = new Size(121, 23);
            cbPerfil.TabIndex = 16;
            // 
            // tPassword
            // 
            tPassword.Location = new Point(165, 342);
            tPassword.Name = "tPassword";
            tPassword.ReadOnly = true;
            tPassword.Size = new Size(121, 23);
            tPassword.TabIndex = 15;
            // 
            // tNombreUsuario
            // 
            tNombreUsuario.Location = new Point(165, 304);
            tNombreUsuario.Name = "tNombreUsuario";
            tNombreUsuario.Size = new Size(121, 23);
            tNombreUsuario.TabIndex = 14;
            // 
            // tTelefono
            // 
            tTelefono.Location = new Point(165, 227);
            tTelefono.Name = "tTelefono";
            tTelefono.Size = new Size(121, 23);
            tTelefono.TabIndex = 12;
            tTelefono.KeyPress += tTelefono_KeyPress;
            // 
            // tEmail
            // 
            tEmail.Location = new Point(165, 179);
            tEmail.Name = "tEmail";
            tEmail.Size = new Size(121, 23);
            tEmail.TabIndex = 11;
            // 
            // tNombre
            // 
            tNombre.Location = new Point(165, 136);
            tNombre.Name = "tNombre";
            tNombre.Size = new Size(121, 23);
            tNombre.TabIndex = 10;
            tNombre.KeyPress += tNombre_KeyPress;
            // 
            // tApellido
            // 
            tApellido.Location = new Point(165, 88);
            tApellido.Name = "tApellido";
            tApellido.Size = new Size(121, 23);
            tApellido.TabIndex = 9;
            tApellido.KeyPress += tApellido_KeyPress;
            // 
            // tDNI
            // 
            tDNI.Location = new Point(165, 44);
            tDNI.Name = "tDNI";
            tDNI.Size = new Size(121, 23);
            tDNI.TabIndex = 8;
            tDNI.KeyPress += tDNI_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(70, 345);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 7;
            label8.Text = "Contraseña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 307);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 6;
            label7.Text = "Nombre Usuario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(111, 267);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 5;
            label6.Text = "Perfil:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(101, 182);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 4;
            label5.Text = "E-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 230);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Teléfono:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(89, 139);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 91);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 47);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // bGuardar
            // 
            bGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bGuardar.Image = Properties.Resources.icons8_save_48;
            bGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            bGuardar.Location = new Point(69, 508);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(108, 50);
            bGuardar.TabIndex = 2;
            bGuardar.Text = "Guardar";
            bGuardar.TextAlign = ContentAlignment.MiddleRight;
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            // 
            // bCancelar
            // 
            bCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bCancelar.Image = Properties.Resources.icons8_cancel_48;
            bCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            bCancelar.Location = new Point(196, 508);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(112, 50);
            bCancelar.TabIndex = 3;
            bCancelar.Text = "Cancelar";
            bCancelar.TextAlign = ContentAlignment.MiddleRight;
            bCancelar.UseVisualStyleBackColor = true;
            bCancelar.Click += bCancelar_Click;
            // 
            // Editar_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(bCancelar);
            Controls.Add(bGuardar);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Editar_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar_Usuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button bGuardar;
        private Button bCancelar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox tPassword;
        private TextBox tNombreUsuario;
        private TextBox tTelefono;
        private TextBox tEmail;
        private TextBox tNombre;
        private TextBox tApellido;
        private TextBox tDNI;
        private ComboBox cbPerfil;
        private Label label9;
        private TextBox tConfirmarPassword;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}