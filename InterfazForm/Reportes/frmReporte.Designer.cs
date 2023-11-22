namespace InterfazForm.Reportes
{
    partial class frmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte));
            lblNombreReporte = new Label();
            dgvReporte = new DataGridView();
            btnImprimir = new Button();
            brtSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombreReporte
            // 
            lblNombreReporte.AutoSize = true;
            lblNombreReporte.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreReporte.Location = new Point(44, 42);
            lblNombreReporte.Margin = new Padding(4, 0, 4, 0);
            lblNombreReporte.Name = "lblNombreReporte";
            lblNombreReporte.Size = new Size(334, 40);
            lblNombreReporte.TabIndex = 1;
            lblNombreReporte.Text = "NOMBRE DEL REPORTE";
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(44, 113);
            dgvReporte.Margin = new Padding(4, 5, 4, 5);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 62;
            dgvReporte.RowTemplate.Height = 25;
            dgvReporte.Size = new Size(879, 522);
            dgvReporte.TabIndex = 2;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(626, 678);
            btnImprimir.Margin = new Padding(4, 5, 4, 5);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(144, 50);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // brtSalir
            // 
            brtSalir.Location = new Point(779, 678);
            brtSalir.Margin = new Padding(4, 5, 4, 5);
            brtSalir.Name = "brtSalir";
            brtSalir.Size = new Size(144, 50);
            brtSalir.TabIndex = 4;
            brtSalir.Text = "Salir";
            brtSalir.UseVisualStyleBackColor = true;
            brtSalir.Click += brtSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 652);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 77);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // frmReporte
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 755);
            Controls.Add(pictureBox1);
            Controls.Add(brtSalir);
            Controls.Add(btnImprimir);
            Controls.Add(dgvReporte);
            Controls.Add(lblNombreReporte);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmReporte";
            Text = "frmReporte";
            Load += frmReporte_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombreReporte;
        private DataGridView dgvReporte;
        private Button btnImprimir;
        private Button brtSalir;
        private PictureBox pictureBox1;
    }
}