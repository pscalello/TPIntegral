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
            lblNombreReporte = new Label();
            dgvReporte = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // lblNombreReporte
            // 
            lblNombreReporte.AutoSize = true;
            lblNombreReporte.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreReporte.Location = new Point(31, 25);
            lblNombreReporte.Name = "lblNombreReporte";
            lblNombreReporte.Size = new Size(218, 25);
            lblNombreReporte.TabIndex = 1;
            lblNombreReporte.Text = "NOMBRE DEL REPORTE";
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(31, 68);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowTemplate.Height = 25;
            dgvReporte.Size = new Size(615, 313);
            dgvReporte.TabIndex = 2;
            // 
            // frmReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 453);
            Controls.Add(dgvReporte);
            Controls.Add(lblNombreReporte);
            Name = "frmReporte";
            Text = "frmReporte";
            Load += frmReporte_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombreReporte;
        private DataGridView dgvReporte;
    }
}