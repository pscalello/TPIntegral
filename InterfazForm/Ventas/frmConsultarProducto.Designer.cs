namespace InterfazForm.Ventas
{
    partial class frmConsultarProducto
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
            dgvProductos = new DataGridView();
            btnSeleccionarProducto = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 12);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(564, 271);
            dgvProductos.TabIndex = 2;
            // 
            // btnSeleccionarProducto
            // 
            btnSeleccionarProducto.Location = new Point(406, 294);
            btnSeleccionarProducto.Margin = new Padding(3, 2, 3, 2);
            btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            btnSeleccionarProducto.Size = new Size(82, 22);
            btnSeleccionarProducto.TabIndex = 3;
            btnSeleccionarProducto.Text = "Seleccionar";
            btnSeleccionarProducto.UseVisualStyleBackColor = true;
            btnSeleccionarProducto.Click += btnSeleccionarProducto_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(494, 294);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmConsultarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 328);
            Controls.Add(btnCancelar);
            Controls.Add(btnSeleccionarProducto);
            Controls.Add(dgvProductos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmConsultarProducto";
            Text = "frmConsultarProducto";
            Load += frmConsultarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnSeleccionarProducto;
        private Button btnCancelar;
    }
}