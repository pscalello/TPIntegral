namespace InterfazForm.Ventas
{
    partial class frmAltaVenta
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
            dgvVenta = new DataGridView();
            label1 = new Label();
            dtiFechaVenta = new DateTimePicker();
            label2 = new Label();
            txtCliente = new TextBox();
            btnSeleccionarCliente = new Button();
            btnAgregarProducto = new Button();
            btnEliminarProducto = new Button();
            btnConfirmarVenta = new Button();
            btnCancelarVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            SuspendLayout();
            // 
            // dgvVenta
            // 
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(27, 120);
            dgvVenta.Margin = new Padding(3, 4, 3, 4);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.RowHeadersWidth = 51;
            dgvVenta.RowTemplate.Height = 25;
            dgvVenta.Size = new Size(858, 412);
            dgvVenta.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 27);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Fecha:";
            // 
            // dtiFechaVenta
            // 
            dtiFechaVenta.Format = DateTimePickerFormat.Custom;
            dtiFechaVenta.Location = new Point(109, 22);
            dtiFechaVenta.Name = "dtiFechaVenta";
            dtiFechaVenta.Size = new Size(124, 27);
            dtiFechaVenta.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 65);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(109, 65);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(229, 27);
            txtCliente.TabIndex = 4;
            // 
            // btnSeleccionarCliente
            // 
            btnSeleccionarCliente.Location = new Point(351, 65);
            btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            btnSeleccionarCliente.Size = new Size(94, 29);
            btnSeleccionarCliente.TabIndex = 5;
            btnSeleccionarCliente.Text = "Seleccionar";
            btnSeleccionarCliente.UseVisualStyleBackColor = true;
            btnSeleccionarCliente.Click += btnSeleccionarCliente_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(27, 544);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(149, 29);
            btnAgregarProducto.TabIndex = 6;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(199, 544);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(139, 29);
            btnEliminarProducto.TabIndex = 7;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.Location = new Point(648, 559);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(126, 29);
            btnConfirmarVenta.TabIndex = 8;
            btnConfirmarVenta.Text = "Confirmar Venta";
            btnConfirmarVenta.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.Location = new Point(780, 559);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(94, 29);
            btnCancelarVenta.TabIndex = 9;
            btnCancelarVenta.Text = "Cancelar";
            btnCancelarVenta.UseVisualStyleBackColor = true;
            // 
            // frmAltaVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnCancelarVenta);
            Controls.Add(btnConfirmarVenta);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnSeleccionarCliente);
            Controls.Add(txtCliente);
            Controls.Add(label2);
            Controls.Add(dtiFechaVenta);
            Controls.Add(label1);
            Controls.Add(dgvVenta);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAltaVenta";
            Text = "frmAltaVenta";
            Activated += frmAltaVenta_Activated;
            Load += frmAltaVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVenta;
        private Label label1;
        private DateTimePicker dtiFechaVenta;
        private Label label2;
        private TextBox txtCliente;
        private Button btnSeleccionarCliente;
        private Button btnAgregarProducto;
        private Button btnEliminarProducto;
        private Button btnConfirmarVenta;
        private Button btnCancelarVenta;
    }
}