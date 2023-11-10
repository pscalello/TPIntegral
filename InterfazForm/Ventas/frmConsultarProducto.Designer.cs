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
            dgvProductos.Location = new Point(75, 26);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(645, 361);
            dgvProductos.TabIndex = 2;
            // 
            // btnSeleccionarProducto
            // 
            btnSeleccionarProducto.Location = new Point(97, 403);
            btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            btnSeleccionarProducto.Size = new Size(94, 29);
            btnSeleccionarProducto.TabIndex = 3;
            btnSeleccionarProducto.Text = "Seleccionar";
            btnSeleccionarProducto.UseVisualStyleBackColor = true;
            btnSeleccionarProducto.Click += btnSeleccionarProducto_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(597, 400);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmConsultarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnSeleccionarProducto);
            Controls.Add(dgvProductos);
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