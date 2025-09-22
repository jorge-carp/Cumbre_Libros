namespace Cumbre_Libros
{
    partial class ABM_Productos
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
            bGuardar = new Button();
            gbDatosProd = new GroupBox();
            bLimpiar = new Button();
            cbCategoria = new ComboBox();
            lCategoria = new Label();
            tStock = new TextBox();
            tPrecio = new TextBox();
            tEdicion = new TextBox();
            tEditorial = new TextBox();
            tAutor = new TextBox();
            tDescripcion = new TextBox();
            tTitulo = new TextBox();
            lStock = new Label();
            lPrecio = new Label();
            lEditorial = new Label();
            lEdicion = new Label();
            lAutor = new Label();
            lDescripcion = new Label();
            lTitulo = new Label();
            gbBuscarProd = new GroupBox();
            bEliminar = new Button();
            bModificar = new Button();
            cbBuscar = new ComboBox();
            lBuscarProd = new Label();
            gbDatosProd.SuspendLayout();
            gbBuscarProd.SuspendLayout();
            SuspendLayout();
            // 
            // bGuardar
            // 
            bGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bGuardar.Location = new Point(611, 72);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(82, 27);
            bGuardar.TabIndex = 7;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = true;
            // 
            // gbDatosProd
            // 
            gbDatosProd.Controls.Add(bLimpiar);
            gbDatosProd.Controls.Add(cbCategoria);
            gbDatosProd.Controls.Add(lCategoria);
            gbDatosProd.Controls.Add(tStock);
            gbDatosProd.Controls.Add(tPrecio);
            gbDatosProd.Controls.Add(tEdicion);
            gbDatosProd.Controls.Add(tEditorial);
            gbDatosProd.Controls.Add(tAutor);
            gbDatosProd.Controls.Add(tDescripcion);
            gbDatosProd.Controls.Add(tTitulo);
            gbDatosProd.Controls.Add(lStock);
            gbDatosProd.Controls.Add(lPrecio);
            gbDatosProd.Controls.Add(lEditorial);
            gbDatosProd.Controls.Add(lEdicion);
            gbDatosProd.Controls.Add(lAutor);
            gbDatosProd.Controls.Add(lDescripcion);
            gbDatosProd.Controls.Add(lTitulo);
            gbDatosProd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbDatosProd.Location = new Point(57, 117);
            gbDatosProd.Name = "gbDatosProd";
            gbDatosProd.Size = new Size(671, 456);
            gbDatosProd.TabIndex = 6;
            gbDatosProd.TabStop = false;
            gbDatosProd.Text = "Datos:";
            // 
            // bLimpiar
            // 
            bLimpiar.Location = new Point(507, 403);
            bLimpiar.Name = "bLimpiar";
            bLimpiar.Size = new Size(129, 29);
            bLimpiar.TabIndex = 16;
            bLimpiar.Text = "Limpiar campos";
            bLimpiar.UseVisualStyleBackColor = true;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(278, 279);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(218, 29);
            cbCategoria.TabIndex = 15;
            // 
            // lCategoria
            // 
            lCategoria.AutoSize = true;
            lCategoria.Location = new Point(127, 282);
            lCategoria.Name = "lCategoria";
            lCategoria.Size = new Size(80, 21);
            lCategoria.TabIndex = 14;
            lCategoria.Text = "Categoria:";
            // 
            // tStock
            // 
            tStock.Location = new Point(476, 326);
            tStock.Name = "tStock";
            tStock.Size = new Size(82, 29);
            tStock.TabIndex = 13;
            // 
            // tPrecio
            // 
            tPrecio.Location = new Point(278, 326);
            tPrecio.Name = "tPrecio";
            tPrecio.Size = new Size(83, 29);
            tPrecio.TabIndex = 12;
            // 
            // tEdicion
            // 
            tEdicion.Location = new Point(278, 232);
            tEdicion.Name = "tEdicion";
            tEdicion.Size = new Size(218, 29);
            tEdicion.TabIndex = 11;
            // 
            // tEditorial
            // 
            tEditorial.Location = new Point(278, 187);
            tEditorial.Name = "tEditorial";
            tEditorial.Size = new Size(218, 29);
            tEditorial.TabIndex = 10;
            // 
            // tAutor
            // 
            tAutor.Location = new Point(278, 142);
            tAutor.Name = "tAutor";
            tAutor.Size = new Size(218, 29);
            tAutor.TabIndex = 9;
            // 
            // tDescripcion
            // 
            tDescripcion.Location = new Point(278, 96);
            tDescripcion.Name = "tDescripcion";
            tDescripcion.Size = new Size(218, 29);
            tDescripcion.TabIndex = 8;
            // 
            // tTitulo
            // 
            tTitulo.Location = new Point(278, 49);
            tTitulo.Name = "tTitulo";
            tTitulo.Size = new Size(218, 29);
            tTitulo.TabIndex = 7;
            // 
            // lStock
            // 
            lStock.AutoSize = true;
            lStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lStock.Location = new Point(405, 330);
            lStock.Name = "lStock";
            lStock.Size = new Size(48, 20);
            lStock.TabIndex = 6;
            lStock.Text = "Stock:";
            // 
            // lPrecio
            // 
            lPrecio.AutoSize = true;
            lPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lPrecio.Location = new Point(127, 330);
            lPrecio.Name = "lPrecio";
            lPrecio.Size = new Size(53, 20);
            lPrecio.TabIndex = 5;
            lPrecio.Text = "Precio:";
            // 
            // lEditorial
            // 
            lEditorial.AutoSize = true;
            lEditorial.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lEditorial.Location = new Point(127, 191);
            lEditorial.Name = "lEditorial";
            lEditorial.Size = new Size(68, 20);
            lEditorial.TabIndex = 4;
            lEditorial.Text = "Editorial:";
            // 
            // lEdicion
            // 
            lEdicion.AutoSize = true;
            lEdicion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lEdicion.Location = new Point(127, 236);
            lEdicion.Name = "lEdicion";
            lEdicion.Size = new Size(61, 20);
            lEdicion.TabIndex = 3;
            lEdicion.Text = "Edicion:";
            // 
            // lAutor
            // 
            lAutor.AutoSize = true;
            lAutor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lAutor.Location = new Point(127, 146);
            lAutor.Name = "lAutor";
            lAutor.Size = new Size(49, 20);
            lAutor.TabIndex = 2;
            lAutor.Text = "Autor:";
            // 
            // lDescripcion
            // 
            lDescripcion.AutoSize = true;
            lDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lDescripcion.Location = new Point(127, 100);
            lDescripcion.Name = "lDescripcion";
            lDescripcion.Size = new Size(83, 20);
            lDescripcion.TabIndex = 1;
            lDescripcion.Text = "Desripcion:";
            // 
            // lTitulo
            // 
            lTitulo.AutoSize = true;
            lTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lTitulo.Location = new Point(127, 53);
            lTitulo.Name = "lTitulo";
            lTitulo.Size = new Size(50, 20);
            lTitulo.TabIndex = 0;
            lTitulo.Text = "Titulo:";
            // 
            // gbBuscarProd
            // 
            gbBuscarProd.BackColor = Color.LightSkyBlue;
            gbBuscarProd.Controls.Add(bEliminar);
            gbBuscarProd.Controls.Add(bModificar);
            gbBuscarProd.Controls.Add(cbBuscar);
            gbBuscarProd.Controls.Add(lBuscarProd);
            gbBuscarProd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbBuscarProd.Location = new Point(57, 40);
            gbBuscarProd.Name = "gbBuscarProd";
            gbBuscarProd.Size = new Size(525, 71);
            gbBuscarProd.TabIndex = 5;
            gbBuscarProd.TabStop = false;
            gbBuscarProd.Text = "Buscar Producto";
            // 
            // bEliminar
            // 
            bEliminar.Enabled = false;
            bEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bEliminar.Location = new Point(434, 32);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(82, 27);
            bEliminar.TabIndex = 3;
            bEliminar.Text = "Eliminar";
            bEliminar.UseVisualStyleBackColor = true;
            // 
            // bModificar
            // 
            bModificar.Enabled = false;
            bModificar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bModificar.Location = new Point(346, 32);
            bModificar.Name = "bModificar";
            bModificar.Size = new Size(82, 27);
            bModificar.TabIndex = 2;
            bModificar.Text = "Modificar";
            bModificar.UseVisualStyleBackColor = true;
            // 
            // cbBuscar
            // 
            cbBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Location = new Point(127, 30);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(213, 29);
            cbBuscar.TabIndex = 1;
            // 
            // lBuscarProd
            // 
            lBuscarProd.AutoSize = true;
            lBuscarProd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lBuscarProd.Location = new Point(6, 34);
            lBuscarProd.Name = "lBuscarProd";
            lBuscarProd.Size = new Size(116, 20);
            lBuscarProd.TabIndex = 0;
            lBuscarProd.Text = "ID del Producto:";
            // 
            // ABM_Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bGuardar);
            Controls.Add(gbDatosProd);
            Controls.Add(gbBuscarProd);
            Name = "ABM_Productos";
            Size = new Size(784, 613);
            gbDatosProd.ResumeLayout(false);
            gbDatosProd.PerformLayout();
            gbBuscarProd.ResumeLayout(false);
            gbBuscarProd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button bGuardar;
        private GroupBox gbDatosProd;
        private Button bLimpiar;
        private ComboBox cbCategoria;
        private Label lCategoria;
        private TextBox tStock;
        private TextBox tPrecio;
        private TextBox tEdicion;
        private TextBox tEditorial;
        private TextBox tAutor;
        private TextBox tDescripcion;
        private TextBox tTitulo;
        private Label lStock;
        private Label lPrecio;
        private Label lEditorial;
        private Label lEdicion;
        private Label lAutor;
        private Label lDescripcion;
        private Label lTitulo;
        private GroupBox gbBuscarProd;
        private Button bEliminar;
        private Button bModificar;
        private ComboBox cbBuscar;
        private Label lBuscarProd;
    }
}
