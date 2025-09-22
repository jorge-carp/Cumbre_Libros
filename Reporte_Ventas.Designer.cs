namespace Cumbre_Libros
{
    partial class Reporte_Ventas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            gbReporteVentas = new GroupBox();
            dtDesde = new DateTimePicker();
            bBuscar = new Button();
            lBuscarDNI = new Label();
            lHasta = new Label();
            dtHasta = new DateTimePicker();
            dataGridView1 = new DataGridView();
            id_venta = new DataGridViewTextBoxColumn();
            dni_vendedor = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            metodo_pago = new DataGridViewTextBoxColumn();
            totalVentas = new Panel();
            lTotal = new Label();
            tTotalVentas = new TextBox();
            bDescargar = new Button();
            gbReporteVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            totalVentas.SuspendLayout();
            SuspendLayout();
            // 
            // gbReporteVentas
            // 
            gbReporteVentas.BackColor = Color.LightSkyBlue;
            gbReporteVentas.Controls.Add(dtHasta);
            gbReporteVentas.Controls.Add(lHasta);
            gbReporteVentas.Controls.Add(dtDesde);
            gbReporteVentas.Controls.Add(bBuscar);
            gbReporteVentas.Controls.Add(lBuscarDNI);
            gbReporteVentas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbReporteVentas.Location = new Point(57, 40);
            gbReporteVentas.Name = "gbReporteVentas";
            gbReporteVentas.Size = new Size(466, 116);
            gbReporteVentas.TabIndex = 7;
            gbReporteVentas.TabStop = false;
            gbReporteVentas.Text = "Reporte de Ventas";
            // 
            // dtDesde
            // 
            dtDesde.Format = DateTimePickerFormat.Short;
            dtDesde.Location = new Point(66, 29);
            dtDesde.Name = "dtDesde";
            dtDesde.Size = new Size(128, 29);
            dtDesde.TabIndex = 4;
            // 
            // bBuscar
            // 
            bBuscar.Enabled = false;
            bBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bBuscar.Location = new Point(66, 77);
            bBuscar.Name = "bBuscar";
            bBuscar.Size = new Size(82, 27);
            bBuscar.TabIndex = 2;
            bBuscar.Text = "Buscar";
            bBuscar.UseVisualStyleBackColor = true;
            // 
            // lBuscarDNI
            // 
            lBuscarDNI.AutoSize = true;
            lBuscarDNI.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lBuscarDNI.Location = new Point(6, 34);
            lBuscarDNI.Name = "lBuscarDNI";
            lBuscarDNI.Size = new Size(54, 20);
            lBuscarDNI.TabIndex = 0;
            lBuscarDNI.Text = "Desde:";
            // 
            // lHasta
            // 
            lHasta.AutoSize = true;
            lHasta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lHasta.Location = new Point(217, 36);
            lHasta.Name = "lHasta";
            lHasta.Size = new Size(50, 20);
            lHasta.TabIndex = 5;
            lHasta.Text = "Hasta:";
            // 
            // dtHasta
            // 
            dtHasta.Format = DateTimePickerFormat.Short;
            dtHasta.Location = new Point(278, 29);
            dtHasta.Name = "dtHasta";
            dtHasta.Size = new Size(127, 29);
            dtHasta.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_venta, dni_vendedor, producto, cantidad, precio, fecha, metodo_pago });
            dataGridView1.Location = new Point(29, 198);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(740, 332);
            dataGridView1.TabIndex = 8;
            // 
            // id_venta
            // 
            id_venta.HeaderText = "ID Venta";
            id_venta.Name = "id_venta";
            // 
            // dni_vendedor
            // 
            dni_vendedor.HeaderText = "DNI Vendedor";
            dni_vendedor.Name = "dni_vendedor";
            // 
            // producto
            // 
            producto.HeaderText = "Titulo del Libro";
            producto.Name = "producto";
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha Venta";
            fecha.Name = "fecha";
            // 
            // metodo_pago
            // 
            metodo_pago.HeaderText = "Metodo de Pago";
            metodo_pago.Name = "metodo_pago";
            // 
            // totalVentas
            // 
            totalVentas.Controls.Add(bDescargar);
            totalVentas.Controls.Add(tTotalVentas);
            totalVentas.Controls.Add(lTotal);
            totalVentas.Location = new Point(57, 536);
            totalVentas.Name = "totalVentas";
            totalVentas.Size = new Size(390, 61);
            totalVentas.TabIndex = 9;
            // 
            // lTotal
            // 
            lTotal.AutoSize = true;
            lTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lTotal.Location = new Point(6, 23);
            lTotal.Name = "lTotal";
            lTotal.Size = new Size(92, 20);
            lTotal.TabIndex = 1;
            lTotal.Text = "Total Ventas:";
            // 
            // tTotalVentas
            // 
            tTotalVentas.Location = new Point(104, 20);
            tTotalVentas.Name = "tTotalVentas";
            tTotalVentas.ReadOnly = true;
            tTotalVentas.Size = new Size(100, 23);
            tTotalVentas.TabIndex = 2;
            // 
            // bDescargar
            // 
            bDescargar.Enabled = false;
            bDescargar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bDescargar.Location = new Point(237, 16);
            bDescargar.Name = "bDescargar";
            bDescargar.Size = new Size(137, 27);
            bDescargar.TabIndex = 3;
            bDescargar.Text = "Descargar PDF";
            bDescargar.UseVisualStyleBackColor = true;
            // 
            // Reporte_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(totalVentas);
            Controls.Add(dataGridView1);
            Controls.Add(gbReporteVentas);
            Name = "Reporte_Ventas";
            Size = new Size(784, 613);
            gbReporteVentas.ResumeLayout(false);
            gbReporteVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            totalVentas.ResumeLayout(false);
            totalVentas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbReporteVentas;
        private DateTimePicker dtDesde;
        private Button bEliminar;
        private Button bBuscar;
        private Label lBuscarDNI;
        private DateTimePicker dtHasta;
        private Label lHasta;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_venta;
        private DataGridViewTextBoxColumn dni_vendedor;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn metodo_pago;
        private Panel totalVentas;
        private TextBox tTotalVentas;
        private Label lTotal;
        private Button bDescargar;
    }
}
