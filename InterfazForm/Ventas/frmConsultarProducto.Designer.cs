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
            btnAgregarProducto = new Button();
            btnCancelar = new Button();
            lblCantidadProducto = new Label();
            txtCantidadProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(17, 20);
            dgvProductos.Margin = new Padding(4, 5, 4, 5);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(806, 452);
            dgvProductos.TabIndex = 2;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(583, 538);
            btnAgregarProducto.Margin = new Padding(4, 3, 4, 3);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(117, 37);
            btnAgregarProducto.TabIndex = 3;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(709, 538);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(117, 37);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblCantidadProducto
            // 
            lblCantidadProducto.AutoSize = true;
            lblCantidadProducto.Location = new Point(17, 490);
            lblCantidadProducto.Margin = new Padding(4, 0, 4, 0);
            lblCantidadProducto.Name = "lblCantidadProducto";
            lblCantidadProducto.Size = new Size(87, 25);
            lblCantidadProducto.TabIndex = 5;
            lblCantidadProducto.Text = "Cantidad:";
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.Location = new Point(109, 482);
            txtCantidadProducto.Margin = new Padding(4, 5, 4, 5);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(141, 31);
            txtCantidadProducto.TabIndex = 6;
            // 
            // frmConsultarProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 593);
            Controls.Add(txtCantidadProducto);
            Controls.Add(lblCantidadProducto);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregarProducto);
            Controls.Add(dgvProductos);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmConsultarProducto";
            Text = "Selección de Productos";
            Load += frmConsultarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnAgregarProducto;
        private Button btnCancelar;
        private Label lblCantidadProducto;
        private TextBox txtCantidadProducto;
    }
}