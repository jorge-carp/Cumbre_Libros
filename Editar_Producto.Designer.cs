namespace Cumbre_Libros
{
    partial class Editar_Producto
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
            bIdioma = new Button();
            cbIdioma = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            bEditorial = new Button();
            bCategoria = new Button();
            bAutor = new Button();
            bRestar = new Button();
            bSumar = new Button();
            bCancelar = new Button();
            bGuardar = new Button();
            label9 = new Label();
            cbEditorial = new ComboBox();
            label8 = new Label();
            cbCategoria = new ComboBox();
            label7 = new Label();
            cbAutor = new ComboBox();
            tPrecio = new TextBox();
            label6 = new Label();
            tStock = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tDescripcion = new TextBox();
            label3 = new Label();
            tTitulo = new TextBox();
            label2 = new Label();
            tISBN = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 45);
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
            groupBox1.Controls.Add(bIdioma);
            groupBox1.Controls.Add(cbIdioma);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(bEditorial);
            groupBox1.Controls.Add(bCategoria);
            groupBox1.Controls.Add(bAutor);
            groupBox1.Controls.Add(bRestar);
            groupBox1.Controls.Add(bSumar);
            groupBox1.Controls.Add(bCancelar);
            groupBox1.Controls.Add(bGuardar);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cbEditorial);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbCategoria);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbAutor);
            groupBox1.Controls.Add(tPrecio);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tStock);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tDescripcion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tTitulo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tISBN);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(605, 452);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // bIdioma
            // 
            bIdioma.FlatStyle = FlatStyle.Flat;
            bIdioma.ForeColor = SystemColors.Control;
            bIdioma.Image = Properties.Resources.icons8_add_24;
            bIdioma.Location = new Point(472, 227);
            bIdioma.Name = "bIdioma";
            bIdioma.Size = new Size(27, 26);
            bIdioma.TabIndex = 29;
            bIdioma.UseVisualStyleBackColor = true;
            bIdioma.Click += bIdioma_Click;
            // 
            // cbIdioma
            // 
            cbIdioma.FormattingEnabled = true;
            cbIdioma.Location = new Point(345, 227);
            cbIdioma.Name = "cbIdioma";
            cbIdioma.Size = new Size(121, 28);
            cbIdioma.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "d/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(417, 268);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 27);
            dateTimePicker1.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(280, 273);
            label10.Name = "label10";
            label10.Size = new Size(131, 20);
            label10.TabIndex = 26;
            label10.Text = "Fecha publicación:";
            // 
            // bEditorial
            // 
            bEditorial.FlatStyle = FlatStyle.Flat;
            bEditorial.ForeColor = SystemColors.Control;
            bEditorial.Image = Properties.Resources.icons8_add_24;
            bEditorial.Location = new Point(481, 103);
            bEditorial.Name = "bEditorial";
            bEditorial.Size = new Size(27, 26);
            bEditorial.TabIndex = 25;
            bEditorial.UseVisualStyleBackColor = true;
            bEditorial.Click += bEditorial_Click;
            // 
            // bCategoria
            // 
            bCategoria.FlatStyle = FlatStyle.Flat;
            bCategoria.ForeColor = SystemColors.Control;
            bCategoria.Image = Properties.Resources.icons8_add_24;
            bCategoria.Location = new Point(490, 184);
            bCategoria.Name = "bCategoria";
            bCategoria.Size = new Size(27, 26);
            bCategoria.TabIndex = 24;
            bCategoria.UseVisualStyleBackColor = true;
            bCategoria.Click += bCategoria_Click;
            // 
            // bAutor
            // 
            bAutor.FlatStyle = FlatStyle.Flat;
            bAutor.ForeColor = SystemColors.Control;
            bAutor.Image = Properties.Resources.icons8_add_24;
            bAutor.Location = new Point(463, 144);
            bAutor.Name = "bAutor";
            bAutor.Size = new Size(27, 26);
            bAutor.TabIndex = 23;
            bAutor.UseVisualStyleBackColor = true;
            bAutor.Click += bAutor_Click;
            // 
            // bRestar
            // 
            bRestar.FlatStyle = FlatStyle.Flat;
            bRestar.ForeColor = SystemColors.Control;
            bRestar.Image = Properties.Resources.icons8_minus_24;
            bRestar.Location = new Point(466, 312);
            bRestar.Name = "bRestar";
            bRestar.Size = new Size(24, 24);
            bRestar.TabIndex = 21;
            bRestar.UseVisualStyleBackColor = true;
            bRestar.Click += bRestar_Click;
            // 
            // bSumar
            // 
            bSumar.FlatStyle = FlatStyle.Flat;
            bSumar.ForeColor = SystemColors.Control;
            bSumar.Image = Properties.Resources.icons8_plus_24;
            bSumar.Location = new Point(440, 312);
            bSumar.Name = "bSumar";
            bSumar.Size = new Size(24, 24);
            bSumar.TabIndex = 20;
            bSumar.UseVisualStyleBackColor = true;
            bSumar.Click += bSumar_Click;
            // 
            // bCancelar
            // 
            bCancelar.Image = Properties.Resources.icons8_cancel_36;
            bCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            bCancelar.Location = new Point(327, 406);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(108, 40);
            bCancelar.TabIndex = 19;
            bCancelar.Text = "Cancelar";
            bCancelar.TextAlign = ContentAlignment.MiddleRight;
            bCancelar.UseVisualStyleBackColor = true;
            bCancelar.Click += bCancelar_Click;
            // 
            // bGuardar
            // 
            bGuardar.Image = Properties.Resources.icons8_save_36;
            bGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            bGuardar.Location = new Point(196, 406);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(103, 40);
            bGuardar.TabIndex = 18;
            bGuardar.Text = "Guardar";
            bGuardar.TextAlign = ContentAlignment.MiddleRight;
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(280, 106);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 17;
            label9.Text = "Editorial:";
            // 
            // cbEditorial
            // 
            cbEditorial.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbEditorial.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbEditorial.FormattingEnabled = true;
            cbEditorial.Location = new Point(354, 103);
            cbEditorial.Name = "cbEditorial";
            cbEditorial.Size = new Size(121, 28);
            cbEditorial.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(280, 187);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 15;
            label8.Text = "Categoría:";
            // 
            // cbCategoria
            // 
            cbCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(363, 184);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(121, 28);
            cbCategoria.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(280, 147);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 13;
            label7.Text = "Autor:";
            // 
            // cbAutor
            // 
            cbAutor.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbAutor.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbAutor.FormattingEnabled = true;
            cbAutor.Location = new Point(336, 144);
            cbAutor.Name = "cbAutor";
            cbAutor.Size = new Size(121, 28);
            cbAutor.TabIndex = 12;
            // 
            // tPrecio
            // 
            tPrecio.Location = new Point(336, 357);
            tPrecio.Name = "tPrecio";
            tPrecio.Size = new Size(100, 27);
            tPrecio.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(280, 360);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 10;
            label6.Text = "Precio:";
            // 
            // tStock
            // 
            tStock.Location = new Point(334, 311);
            tStock.Name = "tStock";
            tStock.Size = new Size(100, 27);
            tStock.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 314);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 8;
            label5.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 230);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 6;
            label4.Text = "Idioma:";
            // 
            // tDescripcion
            // 
            tDescripcion.Location = new Point(15, 88);
            tDescripcion.Multiline = true;
            tDescripcion.Name = "tDescripcion";
            tDescripcion.Size = new Size(257, 301);
            tDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 65);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 4;
            label3.Text = "Descripción:";
            // 
            // tTitulo
            // 
            tTitulo.Location = new Point(336, 62);
            tTitulo.Name = "tTitulo";
            tTitulo.Size = new Size(148, 27);
            tTitulo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 65);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Título:";
            // 
            // tISBN
            // 
            tISBN.Location = new Point(71, 30);
            tISBN.Name = "tISBN";
            tISBN.Size = new Size(174, 27);
            tISBN.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "ISBN:";
            // 
            // Editar_Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 513);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Editar_Producto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Producto";
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
        private TextBox tISBN;
        private Label label1;
        private TextBox tPrecio;
        private Label label6;
        private TextBox tStock;
        private Label label5;
        private Label label4;
        private TextBox tDescripcion;
        private Label label3;
        private TextBox tTitulo;
        private Label label2;
        private Label label7;
        private ComboBox cbAutor;
        private Label label9;
        private ComboBox cbEditorial;
        private Label label8;
        private ComboBox cbCategoria;
        private Button bCancelar;
        private Button bGuardar;
        private Button bRestar;
        private Button bSumar;
        private Button bAutor;
        private Button bEditorial;
        private Button bCategoria;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private ComboBox cbIdioma;
        private Button bIdioma;
    }
}