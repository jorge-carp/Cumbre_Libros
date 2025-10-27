namespace Cumbre_Libros
{
    partial class Caja
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dgvLibros = new DataGridView();
            Agregar = new DataGridViewImageColumn();
            cbGenero = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            tBuscar = new TextBox();
            groupBox2 = new GroupBox();
            cbMetodos = new ComboBox();
            label4 = new Label();
            lSubtotal = new Label();
            label3 = new Label();
            bConfirmar = new Button();
            dgvCarrito = new DataGridView();
            Sumar = new DataGridViewImageColumn();
            Restar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvLibros);
            groupBox1.Controls.Add(cbGenero);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tBuscar);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(814, 302);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Libros";
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Columns.AddRange(new DataGridViewColumn[] { Agregar });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvLibros.DefaultCellStyle = dataGridViewCellStyle10;
            dgvLibros.Location = new Point(6, 61);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(802, 235);
            dgvLibros.TabIndex = 5;
            dgvLibros.CellContentClick += dgvLibros_CellContentClick;
            // 
            // Agregar
            // 
            Agregar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Agregar.HeaderText = "Añadir";
            Agregar.Image = Properties.Resources.icons8_add_24;
            Agregar.Name = "Agregar";
            Agregar.Width = 48;
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(340, 26);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(148, 29);
            cbGenero.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(274, 30);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 2;
            label2.Text = "Género:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "Buscar:";
            // 
            // tBuscar
            // 
            tBuscar.Location = new Point(67, 26);
            tBuscar.Name = "tBuscar";
            tBuscar.Size = new Size(179, 29);
            tBuscar.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbMetodos);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lSubtotal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(bConfirmar);
            groupBox2.Controls.Add(dgvCarrito);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(3, 311);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(814, 286);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Carrito";
            // 
            // cbMetodos
            // 
            cbMetodos.FormattingEnabled = true;
            cbMetodos.Location = new Point(632, 98);
            cbMetodos.Name = "cbMetodos";
            cbMetodos.Size = new Size(159, 29);
            cbMetodos.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(619, 61);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 9;
            label4.Text = "Método de pago:";
            // 
            // lSubtotal
            // 
            lSubtotal.AutoSize = true;
            lSubtotal.Location = new Point(708, 166);
            lSubtotal.Name = "lSubtotal";
            lSubtotal.Size = new Size(0, 21);
            lSubtotal.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(631, 166);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 7;
            label3.Text = "Subtotal:";
            // 
            // bConfirmar
            // 
            bConfirmar.Font = new Font("Segoe UI", 10F);
            bConfirmar.Image = Properties.Resources.icons8_add_shopping_cart_36;
            bConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            bConfirmar.Location = new Point(649, 219);
            bConfirmar.Name = "bConfirmar";
            bConfirmar.Size = new Size(113, 41);
            bConfirmar.TabIndex = 6;
            bConfirmar.Text = "Confirmar";
            bConfirmar.TextAlign = ContentAlignment.MiddleRight;
            bConfirmar.UseVisualStyleBackColor = true;
            bConfirmar.Click += bConfirmar_Click;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { Sumar, Restar, Eliminar });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvCarrito.DefaultCellStyle = dataGridViewCellStyle12;
            dgvCarrito.Location = new Point(6, 28);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.Size = new Size(607, 252);
            dgvCarrito.TabIndex = 0;
            dgvCarrito.CellContentClick += dgvCarrito_CellContentClick;
            dgvCarrito.CellFormatting += dgvCarrito_CellFormatting;
            // 
            // Sumar
            // 
            Sumar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Sumar.HeaderText = "Sumar";
            Sumar.Image = Properties.Resources.icons8_plus_24;
            Sumar.Name = "Sumar";
            Sumar.Width = 47;
            // 
            // Restar
            // 
            Restar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Restar.HeaderText = "Restar";
            Restar.Image = Properties.Resources.icons8_minus_24;
            Restar.Name = "Restar";
            Restar.Width = 45;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.icons8_remove_24;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 56;
            // 
            // Caja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Caja";
            Size = new Size(820, 600);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tBuscar;
        private Label label2;
        private Label label1;
        private DataGridView dgvLibros;
        private ComboBox cbGenero;
        private Button bConfirmar;
        private DataGridView dgvCarrito;
        private DataGridViewImageColumn Agregar;
        private DataGridViewImageColumn Sumar;
        private DataGridViewImageColumn Restar;
        private DataGridViewImageColumn Eliminar;
        private Label lSubtotal;
        private Label label3;
        private ComboBox cbMetodos;
        private Label label4;
    }
}
