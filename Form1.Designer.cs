namespace Cumbre_Libros
{
    partial class Form1
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
            this.PMenuLat = new System.Windows.Forms.Panel();
            this.BSalir = new System.Windows.Forms.Button();
            this.BReportes = new System.Windows.Forms.Button();
            this.BProductos = new System.Windows.Forms.Button();
            this.BVendedores = new System.Windows.Forms.Button();
            this.BVentas = new System.Windows.Forms.Button();
            this.BBackup = new System.Windows.Forms.Button();
            this.BUsuarios = new System.Windows.Forms.Button();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.PMenuLat.SuspendLayout();
            this.SuspendLayout();
            // 
            // PMenuLat
            // 
            this.PMenuLat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PMenuLat.Controls.Add(this.BSalir);
            this.PMenuLat.Controls.Add(this.BReportes);
            this.PMenuLat.Controls.Add(this.BProductos);
            this.PMenuLat.Controls.Add(this.BVendedores);
            this.PMenuLat.Controls.Add(this.BVentas);
            this.PMenuLat.Controls.Add(this.BBackup);
            this.PMenuLat.Controls.Add(this.BUsuarios);
            this.PMenuLat.Dock = System.Windows.Forms.DockStyle.Left;
            this.PMenuLat.Location = new System.Drawing.Point(0, 0);
            this.PMenuLat.Name = "PMenuLat";
            this.PMenuLat.Size = new System.Drawing.Size(124, 561);
            this.PMenuLat.TabIndex = 0;
            this.PMenuLat.Paint += new System.Windows.Forms.PaintEventHandler(this.PMenuLat_Paint);
            // 
            // BSalir
            // 
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.Location = new System.Drawing.Point(0, 466);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(127, 70);
            this.BSalir.TabIndex = 6;
            this.BSalir.UseVisualStyleBackColor = true;
            // 
            // BReportes
            // 
            this.BReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BReportes.Location = new System.Drawing.Point(0, 390);
            this.BReportes.Name = "BReportes";
            this.BReportes.Size = new System.Drawing.Size(124, 78);
            this.BReportes.TabIndex = 5;
            this.BReportes.UseVisualStyleBackColor = true;
            this.BReportes.Click += new System.EventHandler(this.BReportes_Click);
            // 
            // BProductos
            // 
            this.BProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BProductos.Location = new System.Drawing.Point(0, 308);
            this.BProductos.Name = "BProductos";
            this.BProductos.Size = new System.Drawing.Size(124, 85);
            this.BProductos.TabIndex = 4;
            this.BProductos.UseVisualStyleBackColor = true;
            // 
            // BVendedores
            // 
            this.BVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BVendedores.Location = new System.Drawing.Point(0, 154);
            this.BVendedores.Name = "BVendedores";
            this.BVendedores.Size = new System.Drawing.Size(124, 80);
            this.BVendedores.TabIndex = 3;
            this.BVendedores.UseVisualStyleBackColor = true;
            // 
            // BVentas
            // 
            this.BVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BVentas.Location = new System.Drawing.Point(0, 231);
            this.BVentas.Name = "BVentas";
            this.BVentas.Size = new System.Drawing.Size(124, 80);
            this.BVentas.TabIndex = 2;
            this.BVentas.UseVisualStyleBackColor = true;
            // 
            // BBackup
            // 
            this.BBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBackup.Location = new System.Drawing.Point(0, 78);
            this.BBackup.Name = "BBackup";
            this.BBackup.Size = new System.Drawing.Size(124, 82);
            this.BBackup.TabIndex = 1;
            this.BBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BBackup.UseVisualStyleBackColor = true;
            this.BBackup.Click += new System.EventHandler(this.BBackup_Click);
            // 
            // BUsuarios
            // 
            this.BUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUsuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.BUsuarios.Location = new System.Drawing.Point(0, 0);
            this.BUsuarios.Name = "BUsuarios";
            this.BUsuarios.Size = new System.Drawing.Size(124, 81);
            this.BUsuarios.TabIndex = 0;
            this.BUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BUsuarios.UseVisualStyleBackColor = true;
            // 
            // PContenedor
            // 
            this.PContenedor.BackColor = System.Drawing.Color.Transparent;
            this.PContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PContenedor.Location = new System.Drawing.Point(124, 0);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(660, 561);
            this.PContenedor.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.PMenuLat);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PMenuLat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PMenuLat;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BReportes;
        private System.Windows.Forms.Button BProductos;
        private System.Windows.Forms.Button BVendedores;
        private System.Windows.Forms.Button BVentas;
        private System.Windows.Forms.Button BBackup;
        private System.Windows.Forms.Button BUsuarios;
        private System.Windows.Forms.Panel PContenedor;
    }
}

