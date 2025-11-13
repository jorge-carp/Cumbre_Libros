namespace Cumbre_Libros
{
    partial class Backup
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
            bExportar = new Button();
            lPath = new Label();
            lDate = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // bExportar
            // 
            bExportar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bExportar.Image = Properties.Resources.icons8_data_migration_36;
            bExportar.ImageAlign = ContentAlignment.MiddleLeft;
            bExportar.Location = new Point(345, 256);
            bExportar.Name = "bExportar";
            bExportar.Size = new Size(101, 45);
            bExportar.TabIndex = 0;
            bExportar.Text = "Exportar";
            bExportar.TextAlign = ContentAlignment.MiddleRight;
            bExportar.UseVisualStyleBackColor = true;
            bExportar.Click += bExportar_Click;
            // 
            // lPath
            // 
            lPath.AutoSize = true;
            lPath.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lPath.Location = new Point(44, 84);
            lPath.Name = "lPath";
            lPath.Size = new Size(119, 20);
            lPath.TabIndex = 1;
            lPath.Text = "Último backup: -";
            // 
            // lDate
            // 
            lDate.AutoSize = true;
            lDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lDate.Location = new Point(44, 123);
            lDate.Name = "lDate";
            lDate.Size = new Size(60, 20);
            lDate.TabIndex = 2;
            lDate.Text = "Fecha: -";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lPath);
            groupBox1.Controls.Add(lDate);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(65, 307);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(670, 283);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Backup";
            // 
            // Backup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(bExportar);
            Name = "Backup";
            Size = new Size(800, 620);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button bExportar;
        private Label lPath;
        private Label lDate;
        private GroupBox groupBox1;
    }
}
