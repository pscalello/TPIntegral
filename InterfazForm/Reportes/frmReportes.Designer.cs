namespace InterfazForm.Reportes
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            pictureBox1 = new PictureBox();
            btnReporteStockCtitico = new Button();
            btnReporteVentasPorVendedor = new Button();
            btnReporteProductosMasVendidos = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 46);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnReporteStockCtitico
            // 
            btnReporteStockCtitico.Location = new Point(35, 105);
            btnReporteStockCtitico.Name = "btnReporteStockCtitico";
            btnReporteStockCtitico.Size = new Size(189, 72);
            btnReporteStockCtitico.TabIndex = 14;
            btnReporteStockCtitico.Text = "Stock crítico";
            btnReporteStockCtitico.UseVisualStyleBackColor = true;
            btnReporteStockCtitico.Click += btnReporteStockCtitico_Click;
            // 
            // btnReporteVentasPorVendedor
            // 
            btnReporteVentasPorVendedor.Location = new Point(35, 186);
            btnReporteVentasPorVendedor.Name = "btnReporteVentasPorVendedor";
            btnReporteVentasPorVendedor.Size = new Size(189, 72);
            btnReporteVentasPorVendedor.TabIndex = 15;
            btnReporteVentasPorVendedor.Text = "Ventas por vendedor";
            btnReporteVentasPorVendedor.UseVisualStyleBackColor = true;
            // 
            // btnReporteProductosMasVendidos
            // 
            btnReporteProductosMasVendidos.Location = new Point(35, 267);
            btnReporteProductosMasVendidos.Name = "btnReporteProductosMasVendidos";
            btnReporteProductosMasVendidos.Size = new Size(189, 72);
            btnReporteProductosMasVendidos.TabIndex = 16;
            btnReporteProductosMasVendidos.Text = "Productos más vendido por categoría";
            btnReporteProductosMasVendidos.UseVisualStyleBackColor = true;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 364);
            Controls.Add(btnReporteProductosMasVendidos);
            Controls.Add(btnReporteVentasPorVendedor);
            Controls.Add(btnReporteStockCtitico);
            Controls.Add(pictureBox1);
            Name = "frmReportes";
            Text = "Reportes";
            Load += frmReportes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnReporteStockCtitico;
        private Button btnReporteVentasPorVendedor;
        private Button btnReporteProductosMasVendidos;
    }
}