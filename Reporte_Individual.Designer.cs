namespace Cumbre_Libros
{
    partial class Reporte_Individual
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dgvVentas = new DataGridView();
            Factura = new DataGridViewImageColumn();
            Anular = new DataGridViewImageColumn();
            lLibro = new Label();
            lTotal = new Label();
            cbEliminados = new CheckBox();
            dtHasta = new DateTimePicker();
            dtDesde = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chartVentas);
            groupBox1.Controls.Add(dgvVentas);
            groupBox1.Controls.Add(lLibro);
            groupBox1.Controls.Add(lTotal);
            groupBox1.Controls.Add(cbEliminados);
            groupBox1.Controls.Add(dtHasta);
            groupBox1.Controls.Add(dtDesde);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(814, 594);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reporte de Ventas";
            // 
            // chartVentas
            // 
            chartArea3.Name = "ChartArea1";
            chartVentas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartVentas.Legends.Add(legend3);
            chartVentas.Location = new Point(6, 289);
            chartVentas.Name = "chartVentas";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartVentas.Series.Add(series3);
            chartVentas.Size = new Size(805, 299);
            chartVentas.TabIndex = 8;
            chartVentas.Text = "chart1";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { Factura, Anular });
            dgvVentas.Location = new Point(6, 107);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(805, 176);
            dgvVentas.TabIndex = 7;
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
            // lLibro
            // 
            lLibro.AutoSize = true;
            lLibro.BackColor = Color.LightSkyBlue;
            lLibro.Location = new Point(404, 76);
            lLibro.Name = "lLibro";
            lLibro.Size = new Size(161, 20);
            lLibro.TabIndex = 6;
            lLibro.Text = "Producto más vendido:";
            // 
            // lTotal
            // 
            lTotal.AutoSize = true;
            lTotal.BackColor = Color.LightSkyBlue;
            lTotal.ForeColor = SystemColors.ControlText;
            lTotal.Location = new Point(236, 76);
            lTotal.Name = "lTotal";
            lTotal.Size = new Size(45, 20);
            lTotal.TabIndex = 5;
            lTotal.Text = "Total:";
            // 
            // cbEliminados
            // 
            cbEliminados.AutoSize = true;
            cbEliminados.Location = new Point(21, 75);
            cbEliminados.Name = "cbEliminados";
            cbEliminados.Size = new Size(144, 24);
            cbEliminados.TabIndex = 4;
            cbEliminados.Text = "Facturas anuladas";
            cbEliminados.UseVisualStyleBackColor = true;
            cbEliminados.CheckedChanged += cbEliminados_CheckedChanged;
            // 
            // dtHasta
            // 
            dtHasta.Location = new Point(438, 36);
            dtHasta.Name = "dtHasta";
            dtHasta.Size = new Size(200, 27);
            dtHasta.TabIndex = 3;
            dtHasta.ValueChanged += dtHasta_ValueChanged;
            // 
            // dtDesde
            // 
            dtDesde.Location = new Point(149, 36);
            dtDesde.Name = "dtDesde";
            dtDesde.Size = new Size(200, 27);
            dtDesde.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 41);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Hasta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 41);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Desde:";
            // 
            // Reporte_Individual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "Reporte_Individual";
            Size = new Size(820, 600);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker dtHasta;
        private DateTimePicker dtDesde;
        private Label lLibro;
        private Label lTotal;
        private CheckBox cbEliminados;
        private DataGridView dgvVentas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private DataGridViewImageColumn Factura;
        private DataGridViewImageColumn Anular;
    }
}
