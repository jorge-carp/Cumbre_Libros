namespace Cumbre_Libros
{
    partial class ABM_Vendedores
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
                _context?.Dispose();
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
            dgvVendedores = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            cbEliminados = new CheckBox();
            bAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).BeginInit();
            SuspendLayout();
            // 
            // dgvVendedores
            // 
            dgvVendedores.AllowUserToAddRows = false;
            dgvVendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedores.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            dgvVendedores.Location = new Point(19, 73);
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.Size = new Size(781, 507);
            dgvVendedores.TabIndex = 0;
            dgvVendedores.CellContentClick += dgvVendedores_CellContentClick;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = Properties.Resources.icons8_edit_24;
            Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.icons8_remove_24;
            Eliminar.Name = "Eliminar";
            // 
            // cbEliminados
            // 
            cbEliminados.AutoSize = true;
            cbEliminados.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEliminados.Location = new Point(35, 43);
            cbEliminados.Name = "cbEliminados";
            cbEliminados.Size = new Size(101, 24);
            cbEliminados.TabIndex = 1;
            cbEliminados.Text = "Eliminados";
            cbEliminados.UseVisualStyleBackColor = true;
            cbEliminados.CheckedChanged += cbEliminados_CheckedChanged;
            // 
            // bAgregar
            // 
            bAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bAgregar.Image = Properties.Resources.icons8_add_361;
            bAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            bAgregar.Location = new Point(700, 29);
            bAgregar.Name = "bAgregar";
            bAgregar.Size = new Size(90, 38);
            bAgregar.TabIndex = 2;
            bAgregar.Text = "Añadir";
            bAgregar.TextAlign = ContentAlignment.MiddleRight;
            bAgregar.UseVisualStyleBackColor = true;
            bAgregar.Click += bAgregar_Click;
            // 
            // ABM_Vendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bAgregar);
            Controls.Add(cbEliminados);
            Controls.Add(dgvVendedores);
            Name = "ABM_Vendedores";
            Size = new Size(820, 600);
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVendedores;
        private CheckBox cbEliminados;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
        private Button bAgregar;
    }
}
