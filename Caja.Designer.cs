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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dgvLibros = new DataGridView();
            Agregar = new DataGridViewImageColumn();
            cbGenero = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            tBuscar = new TextBox();
            groupBox2 = new GroupBox();
            bConfirmar = new Button();
            dgvCarrito = new DataGridView();
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
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Columns.AddRange(new DataGridViewColumn[] { Agregar });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvLibros.DefaultCellStyle = dataGridViewCellStyle1;
            dgvLibros.Location = new Point(6, 61);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(802, 235);
            dgvLibros.TabIndex = 5;
            // 
            // Agregar
            // 
            Agregar.HeaderText = "Añadir";
            Agregar.Image = Properties.Resources.icons8_add_24;
            Agregar.Name = "Agregar";
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
            // bConfirmar
            // 
            bConfirmar.Font = new Font("Segoe UI", 10F);
            bConfirmar.Image = Properties.Resources.icons8_add_shopping_cart_36;
            bConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            bConfirmar.Location = new Point(340, 245);
            bConfirmar.Name = "bConfirmar";
            bConfirmar.Size = new Size(113, 41);
            bConfirmar.TabIndex = 6;
            bConfirmar.Text = "Confirmar";
            bConfirmar.TextAlign = ContentAlignment.MiddleRight;
            bConfirmar.UseVisualStyleBackColor = true;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCarrito.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCarrito.Location = new Point(6, 28);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.Size = new Size(802, 213);
            dgvCarrito.TabIndex = 0;
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
    }
}
