namespace Cumbre_Libros
{
    partial class Reporte
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            cbEliminados = new CheckBox();
            dgvVentas = new DataGridView();
            Factura = new DataGridViewImageColumn();
            Anular = new DataGridViewImageColumn();
            chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dtHasta = new DateTimePicker();
            dtDesde = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            lLibro = new Label();
            lTotal = new Label();
            cbUsuarios = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartVentas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbEliminados);
            groupBox1.Controls.Add(dgvVentas);
            groupBox1.Controls.Add(chartVentas);
            groupBox1.Controls.Add(dtHasta);
            groupBox1.Controls.Add(dtDesde);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lLibro);
            groupBox1.Controls.Add(lTotal);
            groupBox1.Controls.Add(cbUsuarios);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(817, 594);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reporte de ventas";
            // 
            // cbEliminados
            // 
            cbEliminados.AutoSize = true;
            cbEliminados.Location = new Point(21, 75);
            cbEliminados.Name = "cbEliminados";
            cbEliminados.Size = new Size(144, 24);
            cbEliminados.TabIndex = 10;
            cbEliminados.Text = "Facturas anuladas";
            cbEliminados.UseVisualStyleBackColor = true;
            cbEliminados.CheckedChanged += cbEliminados_CheckedChanged;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { Factura, Anular });
            dgvVentas.Location = new Point(6, 107);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(805, 176);
            dgvVentas.TabIndex = 9;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
            dgvVentas.DataBindingComplete += dgvVentas_DataBindingComplete;
            // 
            // Factura
            // 
            Factura.HeaderText = "Factura";
            Factura.Image = Properties.Resources.icons8_pdf_241;
            Factura.Name = "Factura";
            // 
            // Anular
            // 
            Anular.HeaderText = "Anular";
            Anular.Image = Properties.Resources.icons8_cancel_24;
            Anular.Name = "Anular";
            // 
            // chartVentas
            // 
            chartArea1.Name = "ChartArea1";
            chartVentas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartVentas.Legends.Add(legend1);
            chartVentas.Location = new Point(6, 289);
            chartVentas.Name = "chartVentas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartVentas.Series.Add(series1);
            chartVentas.Size = new Size(805, 299);
            chartVentas.TabIndex = 8;
            chartVentas.Text = "chart1";
            // 
            // dtHasta
            // 
            dtHasta.Location = new Point(580, 38);
            dtHasta.Name = "dtHasta";
            dtHasta.Size = new Size(200, 27);
            dtHasta.TabIndex = 7;
            dtHasta.ValueChanged += dtHasta_ValueChanged;
            // 
            // dtDesde
            // 
            dtDesde.Location = new Point(303, 38);
            dtDesde.Name = "dtDesde";
            dtDesde.Size = new Size(200, 27);
            dtDesde.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(524, 41);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 5;
            label5.Text = "Hasta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 41);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 4;
            label4.Text = "Desde:";
            // 
            // lLibro
            // 
            lLibro.AutoSize = true;
            lLibro.BackColor = Color.LightSkyBlue;
            lLibro.Location = new Point(413, 76);
            lLibro.Name = "lLibro";
            lLibro.Size = new Size(161, 20);
            lLibro.TabIndex = 3;
            lLibro.Text = "Producto más vendido:";
            // 
            // lTotal
            // 
            lTotal.AutoSize = true;
            lTotal.BackColor = Color.LightSkyBlue;
            lTotal.Location = new Point(223, 76);
            lTotal.Name = "lTotal";
            lTotal.Size = new Size(45, 20);
            lTotal.TabIndex = 2;
            lTotal.Text = "Total:";
            // 
            // cbUsuarios
            // 
            cbUsuarios.FormattingEnabled = true;
            cbUsuarios.Location = new Point(82, 38);
            cbUsuarios.Name = "cbUsuarios";
            cbUsuarios.Size = new Size(135, 28);
            cbUsuarios.TabIndex = 1;
            cbUsuarios.SelectedIndexChanged += cbUsuarios_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Vendedor:";
            // 
            // Reporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "Reporte";
            Size = new Size(820, 600);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lLibro;
        private Label lTotal;
        private ComboBox cbUsuarios;
        private Label label1;
        private DateTimePicker dtHasta;
        private DateTimePicker dtDesde;
        private Label label5;
        private Label label4;
        private DataGridView dgvVentas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private CheckBox cbEliminados;
        private DataGridViewImageColumn Factura;
        private DataGridViewImageColumn Anular;
    }
}
