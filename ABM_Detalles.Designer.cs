namespace Cumbre_Libros
{
    partial class ABM_Detalles
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
            gbDatos = new GroupBox();
            cbEliminados = new CheckBox();
            dgvDetalles = new DataGridView();
            Eliminar = new DataGridViewCheckBoxColumn();
            Restaurar = new DataGridViewCheckBoxColumn();
            bGuardar = new Button();
            bCancelar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 45);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.logo_2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(cbEliminados);
            gbDatos.Controls.Add(dgvDetalles);
            gbDatos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbDatos.Location = new Point(12, 51);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(529, 387);
            gbDatos.TabIndex = 1;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos:";
            // 
            // cbEliminados
            // 
            cbEliminados.AutoSize = true;
            cbEliminados.Location = new Point(15, 26);
            cbEliminados.Name = "cbEliminados";
            cbEliminados.Size = new Size(101, 24);
            cbEliminados.TabIndex = 1;
            cbEliminados.Text = "Eliminados";
            cbEliminados.UseVisualStyleBackColor = true;
            cbEliminados.CheckedChanged += cbEliminados_CheckedChanged;
            // 
            // dgvDetalles
            // 
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { Eliminar, Restaurar });
            dgvDetalles.Location = new Point(6, 56);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowHeadersVisible = false;
            dgvDetalles.Size = new Size(517, 344);
            dgvDetalles.TabIndex = 0;
            dgvDetalles.CellValueChanged += dgvDetalles_CellValueChanged;
            dgvDetalles.CurrentCellDirtyStateChanged += dgvDetalles_CurrentCellDirtyStateChanged;
            dgvDetalles.DataBindingComplete += dgvDetalles_DataBindingComplete;
            dgvDetalles.DefaultValuesNeeded += dgvDetalles_DefaultValuesNeeded;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 69;
            // 
            // Restaurar
            // 
            Restaurar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Restaurar.HeaderText = "Restaurar";
            Restaurar.Name = "Restaurar";
            Restaurar.Visible = false;
            // 
            // bGuardar
            // 
            bGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bGuardar.Image = Properties.Resources.icons8_save_36;
            bGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            bGuardar.Location = new Point(168, 457);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(97, 41);
            bGuardar.TabIndex = 2;
            bGuardar.Text = "Guardar";
            bGuardar.TextAlign = ContentAlignment.MiddleRight;
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            // 
            // bCancelar
            // 
            bCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bCancelar.Image = Properties.Resources.icons8_cancel_36;
            bCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            bCancelar.Location = new Point(285, 457);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(100, 41);
            bCancelar.TabIndex = 3;
            bCancelar.Text = "Cancelar";
            bCancelar.TextAlign = ContentAlignment.MiddleRight;
            bCancelar.UseVisualStyleBackColor = true;
            bCancelar.Click += bCancelar_Click;
            // 
            // ABM_Detalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 500);
            Controls.Add(bCancelar);
            Controls.Add(bGuardar);
            Controls.Add(gbDatos);
            Controls.Add(panel1);
            Name = "ABM_Detalles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABM_Detalles";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private GroupBox gbDatos;
        private DataGridView dgvDetalles;
        private CheckBox cbEliminados;
        private Button bGuardar;
        private Button bCancelar;
        private DataGridViewCheckBoxColumn Eliminar;
        private DataGridViewCheckBoxColumn Restaurar;
    }
}