namespace Cumbre_Libros
{
    partial class Login
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
            this.lUsuario = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.bInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Location = new System.Drawing.Point(53, 43);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(46, 13);
            this.lUsuario.TabIndex = 0;
            this.lUsuario.Text = "Usuario:";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(53, 86);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(64, 13);
            this.lPassword.TabIndex = 1;
            this.lPassword.Text = "Contraseña:";
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(119, 40);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(100, 20);
            this.tUsuario.TabIndex = 2;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(119, 83);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(100, 20);
            this.tPassword.TabIndex = 3;
            // 
            // bInicio
            // 
            this.bInicio.Location = new System.Drawing.Point(102, 126);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(78, 23);
            this.bInicio.TabIndex = 4;
            this.bInicio.Text = "Iniciar Sesión";
            this.bInicio.UseVisualStyleBackColor = true;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.bInicio);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lUsuario);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cumbre Libros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button bInicio;
    }
}

