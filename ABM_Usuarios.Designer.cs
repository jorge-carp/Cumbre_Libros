namespace Cumbre_Libros
{
    partial class ABM_Usuarios
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
                db.Dispose();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbBuscar = new GroupBox();
            bEliminar = new Button();
            bModificar = new Button();
            cbBuscar = new ComboBox();
            lBuscarDNI = new Label();
            gbDatos = new GroupBox();
            cbRol = new ComboBox();
            lPerfil = new Label();
            tPassword = new TextBox();
            tNombreUsuario = new TextBox();
            tTelefono = new TextBox();
            tEmail = new TextBox();
            tNombre = new TextBox();
            tApellido = new TextBox();
            tDNI = new TextBox();
            lPassword = new Label();
            lNombreUsuario = new Label();
            lEmail = new Label();
            lTelefono = new Label();
            lNombre = new Label();
            lApellido = new Label();
            lDNI = new Label();
            bGuardar = new Button();
            bLimpiar = new Button();
            gbBuscar.SuspendLayout();
            gbDatos.SuspendLayout();
            SuspendLayout();
            // 
            // gbBuscar
            // 
            gbBuscar.BackColor = Color.LightSkyBlue;
            gbBuscar.Controls.Add(bEliminar);
            gbBuscar.Controls.Add(bModificar);
            gbBuscar.Controls.Add(cbBuscar);
            gbBuscar.Controls.Add(lBuscarDNI);
            gbBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbBuscar.Location = new Point(62, 49);
            gbBuscar.Name = "gbBuscar";
            gbBuscar.Size = new Size(525, 71);
            gbBuscar.TabIndex = 0;
            gbBuscar.TabStop = false;
            gbBuscar.Text = "Buscar Usuarios";
            // 
            // bEliminar
            // 
            bEliminar.Enabled = false;
            bEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bEliminar.Location = new Point(434, 32);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(82, 27);
            bEliminar.TabIndex = 3;
            bEliminar.Text = "Eliminar";
            bEliminar.UseVisualStyleBackColor = true;
            bEliminar.Click += bEliminar_Click;
            // 
            // bModificar
            // 
            bModificar.Enabled = false;
            bModificar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bModificar.Location = new Point(346, 32);
            bModificar.Name = "bModificar";
            bModificar.Size = new Size(82, 27);
            bModificar.TabIndex = 2;
            bModificar.Text = "Modificar";
            bModificar.UseVisualStyleBackColor = true;
            bModificar.Click += bModificar_Click;
            // 
            // cbBuscar
            // 
            cbBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Location = new Point(127, 30);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(213, 29);
            cbBuscar.TabIndex = 1;
            cbBuscar.SelectionChangeCommitted += cbBuscar_SelectionChangeCommitted;
            // 
            // lBuscarDNI
            // 
            lBuscarDNI.AutoSize = true;
            lBuscarDNI.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lBuscarDNI.Location = new Point(6, 34);
            lBuscarDNI.Name = "lBuscarDNI";
            lBuscarDNI.Size = new Size(115, 20);
            lBuscarDNI.TabIndex = 0;
            lBuscarDNI.Text = "DNI del usuario:";
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(bLimpiar);
            gbDatos.Controls.Add(cbRol);
            gbDatos.Controls.Add(lPerfil);
            gbDatos.Controls.Add(tPassword);
            gbDatos.Controls.Add(tNombreUsuario);
            gbDatos.Controls.Add(tTelefono);
            gbDatos.Controls.Add(tEmail);
            gbDatos.Controls.Add(tNombre);
            gbDatos.Controls.Add(tApellido);
            gbDatos.Controls.Add(tDNI);
            gbDatos.Controls.Add(lPassword);
            gbDatos.Controls.Add(lNombreUsuario);
            gbDatos.Controls.Add(lEmail);
            gbDatos.Controls.Add(lTelefono);
            gbDatos.Controls.Add(lNombre);
            gbDatos.Controls.Add(lApellido);
            gbDatos.Controls.Add(lDNI);
            gbDatos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbDatos.Location = new Point(62, 126);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(671, 456);
            gbDatos.TabIndex = 1;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos:";
            // 
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(278, 279);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(218, 29);
            cbRol.TabIndex = 15;
            // 
            // lPerfil
            // 
            lPerfil.AutoSize = true;
            lPerfil.Location = new Point(127, 282);
            lPerfil.Name = "lPerfil";
            lPerfil.Size = new Size(48, 21);
            lPerfil.TabIndex = 14;
            lPerfil.Text = "Perfil:";
            // 
            // tPassword
            // 
            tPassword.Location = new Point(278, 374);
            tPassword.Name = "tPassword";
            tPassword.Size = new Size(218, 29);
            tPassword.TabIndex = 13;
            // 
            // tNombreUsuario
            // 
            tNombreUsuario.Location = new Point(278, 326);
            tNombreUsuario.Name = "tNombreUsuario";
            tNombreUsuario.Size = new Size(218, 29);
            tNombreUsuario.TabIndex = 12;
            // 
            // tTelefono
            // 
            tTelefono.Location = new Point(278, 232);
            tTelefono.Name = "tTelefono";
            tTelefono.Size = new Size(218, 29);
            tTelefono.TabIndex = 11;
            // 
            // tEmail
            // 
            tEmail.Location = new Point(278, 187);
            tEmail.Name = "tEmail";
            tEmail.Size = new Size(218, 29);
            tEmail.TabIndex = 10;
            // 
            // tNombre
            // 
            tNombre.Location = new Point(278, 142);
            tNombre.Name = "tNombre";
            tNombre.Size = new Size(218, 29);
            tNombre.TabIndex = 9;
            // 
            // tApellido
            // 
            tApellido.Location = new Point(278, 96);
            tApellido.Name = "tApellido";
            tApellido.Size = new Size(218, 29);
            tApellido.TabIndex = 8;
            // 
            // tDNI
            // 
            tDNI.Location = new Point(278, 49);
            tDNI.Name = "tDNI";
            tDNI.Size = new Size(218, 29);
            tDNI.TabIndex = 7;
            // 
            // lPassword
            // 
            lPassword.AutoSize = true;
            lPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lPassword.Location = new Point(127, 378);
            lPassword.Name = "lPassword";
            lPassword.Size = new Size(86, 20);
            lPassword.TabIndex = 6;
            lPassword.Text = "Contraseña:";
            // 
            // lNombreUsuario
            // 
            lNombreUsuario.AutoSize = true;
            lNombreUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lNombreUsuario.Location = new Point(127, 330);
            lNombreUsuario.Name = "lNombreUsuario";
            lNombreUsuario.Size = new Size(140, 20);
            lNombreUsuario.TabIndex = 5;
            lNombreUsuario.Text = "Nombre de usuario:";
            // 
            // lEmail
            // 
            lEmail.AutoSize = true;
            lEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lEmail.Location = new Point(127, 191);
            lEmail.Name = "lEmail";
            lEmail.Size = new Size(55, 20);
            lEmail.TabIndex = 4;
            lEmail.Text = "E-mail:";
            // 
            // lTelefono
            // 
            lTelefono.AutoSize = true;
            lTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lTelefono.Location = new Point(127, 236);
            lTelefono.Name = "lTelefono";
            lTelefono.Size = new Size(70, 20);
            lTelefono.TabIndex = 3;
            lTelefono.Text = "Teléfono:";
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lNombre.Location = new Point(127, 146);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(67, 20);
            lNombre.TabIndex = 2;
            lNombre.Text = "Nombre:";
            // 
            // lApellido
            // 
            lApellido.AutoSize = true;
            lApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lApellido.Location = new Point(127, 100);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(69, 20);
            lApellido.TabIndex = 1;
            lApellido.Text = "Apellido:";
            // 
            // lDNI
            // 
            lDNI.AutoSize = true;
            lDNI.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lDNI.Location = new Point(127, 53);
            lDNI.Name = "lDNI";
            lDNI.Size = new Size(38, 20);
            lDNI.TabIndex = 0;
            lDNI.Text = "DNI:";
            // 
            // bGuardar
            // 
            bGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bGuardar.Location = new Point(616, 81);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(82, 27);
            bGuardar.TabIndex = 4;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            // 
            // bLimpiar
            // 
            bLimpiar.Location = new Point(536, 421);
            bLimpiar.Name = "bLimpiar";
            bLimpiar.Size = new Size(129, 29);
            bLimpiar.TabIndex = 16;
            bLimpiar.Text = "Limpiar campos";
            bLimpiar.UseVisualStyleBackColor = true;
            bLimpiar.Click += this.bLimpiar_Click;
            // 
            // ABM_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bGuardar);
            Controls.Add(gbDatos);
            Controls.Add(gbBuscar);
            Name = "ABM_Usuarios";
            Size = new Size(784, 613);
            gbBuscar.ResumeLayout(false);
            gbBuscar.PerformLayout();
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbBuscar;
        private ComboBox cbBuscar;
        private Label lBuscarDNI;
        private GroupBox gbDatos;
        private Label lDNI;
        private Label lPassword;
        private Label lNombreUsuario;
        private Label lEmail;
        private Label lTelefono;
        private Label lNombre;
        private Label lApellido;
        private ComboBox cbRol;
        private Label lPerfil;
        private TextBox tPassword;
        private TextBox tNombreUsuario;
        private TextBox tTelefono;
        private TextBox tEmail;
        private TextBox tNombre;
        private TextBox tApellido;
        private TextBox tDNI;
        private Button bModificar;
        private Button bEliminar;
        private Button bGuardar;
        private Button bLimpiar;
    }
}
