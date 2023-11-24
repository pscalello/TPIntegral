namespace InterfazForm.Ventas
{
    partial class frmConsultarCliente
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
            dgvClientes = new DataGridView();
            btnSeleccionar = new Button();
            btnCancelar = new Button();
            logoCarga = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoCarga).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(17, 20);
            dgvClientes.Margin = new Padding(4, 5, 4, 5);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(847, 445);
            dgvClientes.TabIndex = 10;
            dgvClientes.DoubleClick += dgvClientes_DoubleClick;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(621, 480);
            btnSeleccionar.Margin = new Padding(4, 3, 4, 3);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(117, 37);
            btnSeleccionar.TabIndex = 11;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(747, 480);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(117, 37);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // logoCarga
            // 
            logoCarga.Image = Properties.Resources.icnLogoCarga;
            logoCarga.Location = new Point(569, 480);
            logoCarga.Margin = new Padding(4, 5, 4, 5);
            logoCarga.Name = "logoCarga";
            logoCarga.Size = new Size(44, 51);
            logoCarga.TabIndex = 17;
            logoCarga.TabStop = false;
            // 
            // frmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 537);
            Controls.Add(logoCarga);
            Controls.Add(btnCancelar);
            Controls.Add(btnSeleccionar);
            Controls.Add(dgvClientes);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmConsultarCliente";
            Text = "Selección de Cliente";
            Load += frmConsultarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoCarga).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnSeleccionar;
        private Button btnCancelar;
        private PictureBox logoCarga;
    }
}