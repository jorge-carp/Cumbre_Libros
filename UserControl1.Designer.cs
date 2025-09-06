namespace Cumbre_Libros
{
    partial class UCProductos
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
            this.LProductos = new System.Windows.Forms.Label();
            this.PAgregar = new System.Windows.Forms.Panel();
            this.LAgregar = new System.Windows.Forms.Label();
            this.LProducto = new System.Windows.Forms.Label();
            this.LStock = new System.Windows.Forms.Label();
            this.TProducto = new System.Windows.Forms.TextBox();
            this.TStock = new System.Windows.Forms.TextBox();
            this.LDescrip = new System.Windows.Forms.Label();
            this.TDescrip = new System.Windows.Forms.TextBox();
            this.LPrecioVen = new System.Windows.Forms.Label();
            this.TPrecioVen = new System.Windows.Forms.TextBox();
            this.LCant = new System.Windows.Forms.Label();
            this.NCantid = new System.Windows.Forms.NumericUpDown();
            this.BAgregar = new System.Windows.Forms.Button();
            this.LListaDP = new System.Windows.Forms.Label();
            this.PAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NCantid)).BeginInit();
            this.SuspendLayout();
            // 
            // LProductos
            // 
            this.LProductos.AutoSize = true;
            this.LProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProductos.Location = new System.Drawing.Point(90, 22);
            this.LProductos.Name = "LProductos";
            this.LProductos.Size = new System.Drawing.Size(118, 25);
            this.LProductos.TabIndex = 0;
            this.LProductos.Text = "Productos";
            // 
            // PAgregar
            // 
            this.PAgregar.BackColor = System.Drawing.Color.Transparent;
            this.PAgregar.Controls.Add(this.BAgregar);
            this.PAgregar.Controls.Add(this.NCantid);
            this.PAgregar.Controls.Add(this.LCant);
            this.PAgregar.Controls.Add(this.TPrecioVen);
            this.PAgregar.Controls.Add(this.LPrecioVen);
            this.PAgregar.Controls.Add(this.TDescrip);
            this.PAgregar.Controls.Add(this.LDescrip);
            this.PAgregar.Controls.Add(this.TStock);
            this.PAgregar.Controls.Add(this.TProducto);
            this.PAgregar.Controls.Add(this.LStock);
            this.PAgregar.Controls.Add(this.LProducto);
            this.PAgregar.Controls.Add(this.LAgregar);
            this.PAgregar.Location = new System.Drawing.Point(63, 55);
            this.PAgregar.Name = "PAgregar";
            this.PAgregar.Size = new System.Drawing.Size(645, 135);
            this.PAgregar.TabIndex = 1;
            // 
            // LAgregar
            // 
            this.LAgregar.AutoSize = true;
            this.LAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAgregar.Location = new System.Drawing.Point(29, 11);
            this.LAgregar.Name = "LAgregar";
            this.LAgregar.Size = new System.Drawing.Size(129, 16);
            this.LAgregar.TabIndex = 0;
            this.LAgregar.Text = "Agregar Producto";
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProducto.Location = new System.Drawing.Point(29, 45);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(62, 13);
            this.LProducto.TabIndex = 1;
            this.LProducto.Text = "Producto:";
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.Location = new System.Drawing.Point(29, 77);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(44, 13);
            this.LStock.TabIndex = 2;
            this.LStock.Text = "Stock:";
            // 
            // TProducto
            // 
            this.TProducto.Location = new System.Drawing.Point(97, 42);
            this.TProducto.Name = "TProducto";
            this.TProducto.Size = new System.Drawing.Size(117, 20);
            this.TProducto.TabIndex = 3;
            // 
            // TStock
            // 
            this.TStock.Location = new System.Drawing.Point(79, 74);
            this.TStock.Name = "TStock";
            this.TStock.Size = new System.Drawing.Size(66, 20);
            this.TStock.TabIndex = 4;
            // 
            // LDescrip
            // 
            this.LDescrip.AutoSize = true;
            this.LDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescrip.Location = new System.Drawing.Point(237, 45);
            this.LDescrip.Name = "LDescrip";
            this.LDescrip.Size = new System.Drawing.Size(78, 13);
            this.LDescrip.TabIndex = 5;
            this.LDescrip.Text = "Descripcion:";
            // 
            // TDescrip
            // 
            this.TDescrip.Location = new System.Drawing.Point(321, 42);
            this.TDescrip.Multiline = true;
            this.TDescrip.Name = "TDescrip";
            this.TDescrip.Size = new System.Drawing.Size(263, 20);
            this.TDescrip.TabIndex = 6;
            // 
            // LPrecioVen
            // 
            this.LPrecioVen.AutoSize = true;
            this.LPrecioVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioVen.Location = new System.Drawing.Point(191, 77);
            this.LPrecioVen.Name = "LPrecioVen";
            this.LPrecioVen.Size = new System.Drawing.Size(84, 13);
            this.LPrecioVen.TabIndex = 7;
            this.LPrecioVen.Text = "Precio Venta:";
            // 
            // TPrecioVen
            // 
            this.TPrecioVen.Location = new System.Drawing.Point(281, 74);
            this.TPrecioVen.Name = "TPrecioVen";
            this.TPrecioVen.Size = new System.Drawing.Size(91, 20);
            this.TPrecioVen.TabIndex = 8;
            // 
            // LCant
            // 
            this.LCant.AutoSize = true;
            this.LCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCant.Location = new System.Drawing.Point(420, 77);
            this.LCant.Name = "LCant";
            this.LCant.Size = new System.Drawing.Size(61, 13);
            this.LCant.TabIndex = 9;
            this.LCant.Text = "Cantidad:";
            // 
            // NCantid
            // 
            this.NCantid.Location = new System.Drawing.Point(487, 74);
            this.NCantid.Name = "NCantid";
            this.NCantid.Size = new System.Drawing.Size(41, 20);
            this.NCantid.TabIndex = 10;
            // 
            // BAgregar
            // 
            this.BAgregar.Location = new System.Drawing.Point(541, 100);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(75, 23);
            this.BAgregar.TabIndex = 11;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.UseVisualStyleBackColor = true;
            // 
            // LListaDP
            // 
            this.LListaDP.AutoSize = true;
            this.LListaDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaDP.Location = new System.Drawing.Point(92, 221);
            this.LListaDP.Name = "LListaDP";
            this.LListaDP.Size = new System.Drawing.Size(209, 25);
            this.LListaDP.TabIndex = 2;
            this.LListaDP.Text = "Lista de Productos";
            // 
            // UCProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LListaDP);
            this.Controls.Add(this.PAgregar);
            this.Controls.Add(this.LProductos);
            this.Name = "UCProductos";
            this.Size = new System.Drawing.Size(801, 517);
            this.PAgregar.ResumeLayout(false);
            this.PAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NCantid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LProductos;
        private System.Windows.Forms.Panel PAgregar;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.Label LAgregar;
        private System.Windows.Forms.TextBox TStock;
        private System.Windows.Forms.TextBox TProducto;
        private System.Windows.Forms.TextBox TPrecioVen;
        private System.Windows.Forms.Label LPrecioVen;
        private System.Windows.Forms.TextBox TDescrip;
        private System.Windows.Forms.Label LDescrip;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.NumericUpDown NCantid;
        private System.Windows.Forms.Label LCant;
        private System.Windows.Forms.Label LListaDP;
    }
}
