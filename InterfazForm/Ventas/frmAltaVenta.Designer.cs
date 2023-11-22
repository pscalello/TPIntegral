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
            pictureBox1 = new PictureBox();
            txtPromoElectroHogar = new TextBox();
            txtPromoClienteNuevo = new TextBox();
            txtMontoFinal = new TextBox();
            txtMontoTotal = new TextBox();
            lblMontoTotal = new Label();
            lblPromoElectroHogar = new Label();
            lblPromoClienteNuevo = new Label();
            lblMontoFinal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvVenta
            // 
            dgvVenta.AllowUserToAddRows = false;
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(34, 130);
            dgvVenta.Margin = new Padding(4, 5, 4, 5);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.RowHeadersWidth = 51;
            dgvVenta.RowTemplate.Height = 25;
            dgvVenta.Size = new Size(1057, 405);
            dgvVenta.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 1;
            label1.Text = "Fecha:";
            // 
            // dtiFechaVenta
            // 
            dtiFechaVenta.Format = DateTimePickerFormat.Custom;
            dtiFechaVenta.Location = new Point(101, 28);
            dtiFechaVenta.Margin = new Padding(4, 3, 4, 3);
            dtiFechaVenta.Name = "dtiFechaVenta";
            dtiFechaVenta.Size = new Size(154, 31);
            dtiFechaVenta.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 3;
            label2.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(101, 77);
            txtCliente.Margin = new Padding(4, 3, 4, 3);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(285, 31);
            txtCliente.TabIndex = 4;
            // 
            // btnSeleccionarCliente
            // 
            btnSeleccionarCliente.Location = new Point(397, 77);
            btnSeleccionarCliente.Margin = new Padding(4, 3, 4, 3);
            btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            btnSeleccionarCliente.Size = new Size(117, 37);
            btnSeleccionarCliente.TabIndex = 5;
            btnSeleccionarCliente.Text = "Seleccionar";
            btnSeleccionarCliente.UseVisualStyleBackColor = true;
            btnSeleccionarCliente.Click += btnSeleccionarCliente_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(34, 558);
            btnAgregarProducto.Margin = new Padding(4, 3, 4, 3);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(174, 53);
            btnAgregarProducto.TabIndex = 6;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(34, 627);
            btnEliminarProducto.Margin = new Padding(4, 3, 4, 3);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(174, 53);
            btnEliminarProducto.TabIndex = 7;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.Location = new Point(741, 775);
            btnConfirmarVenta.Margin = new Padding(4, 3, 4, 3);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(157, 37);
            btnConfirmarVenta.TabIndex = 8;
            btnConfirmarVenta.Text = "Confirmar Venta";
            btnConfirmarVenta.UseVisualStyleBackColor = true;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.Location = new Point(920, 775);
            btnCancelarVenta.Margin = new Padding(4, 3, 4, 3);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(157, 37);
            btnCancelarVenta.TabIndex = 9;
            btnCancelarVenta.Text = "Cancelar";
            btnCancelarVenta.UseVisualStyleBackColor = true;
            btnCancelarVenta.Click += btnCancelarVenta_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_electrohogar;
            pictureBox1.Location = new Point(776, 27);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 83);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // txtPromoElectroHogar
            // 
            txtPromoElectroHogar.Location = new Point(934, 615);
            txtPromoElectroHogar.Margin = new Padding(4, 5, 4, 5);
            txtPromoElectroHogar.Name = "txtPromoElectroHogar";
            txtPromoElectroHogar.Size = new Size(141, 31);
            txtPromoElectroHogar.TabIndex = 11;
            // 
            // txtPromoClienteNuevo
            // 
            txtPromoClienteNuevo.Location = new Point(934, 663);
            txtPromoClienteNuevo.Margin = new Padding(4, 5, 4, 5);
            txtPromoClienteNuevo.Name = "txtPromoClienteNuevo";
            txtPromoClienteNuevo.Size = new Size(141, 31);
            txtPromoClienteNuevo.TabIndex = 12;
            // 
            // txtMontoFinal
            // 
            txtMontoFinal.Location = new Point(934, 713);
            txtMontoFinal.Margin = new Padding(4, 5, 4, 5);
            txtMontoFinal.Name = "txtMontoFinal";
            txtMontoFinal.Size = new Size(141, 31);
            txtMontoFinal.TabIndex = 13;
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.Location = new Point(934, 567);
            txtMontoTotal.Margin = new Padding(4, 5, 4, 5);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(141, 31);
            txtMontoTotal.TabIndex = 14;
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Location = new Point(659, 573);
            lblMontoTotal.Margin = new Padding(4, 0, 4, 0);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(272, 25);
            lblMontoTotal.TabIndex = 15;
            lblMontoTotal.Text = "Monto Total Previo A Descuento:";
            // 
            // lblPromoElectroHogar
            // 
            lblPromoElectroHogar.AutoSize = true;
            lblPromoElectroHogar.Location = new Point(627, 620);
            lblPromoElectroHogar.Margin = new Padding(4, 0, 4, 0);
            lblPromoElectroHogar.Name = "lblPromoElectroHogar";
            lblPromoElectroHogar.Size = new Size(310, 25);
            lblPromoElectroHogar.TabIndex = 16;
            lblPromoElectroHogar.Text = "Promo Electro Hogar (5% descuento):";
            // 
            // lblPromoClienteNuevo
            // 
            lblPromoClienteNuevo.AutoSize = true;
            lblPromoClienteNuevo.Location = new Point(619, 668);
            lblPromoClienteNuevo.Margin = new Padding(4, 0, 4, 0);
            lblPromoClienteNuevo.Name = "lblPromoClienteNuevo";
            lblPromoClienteNuevo.Size = new Size(312, 25);
            lblPromoClienteNuevo.TabIndex = 17;
            lblPromoClienteNuevo.Text = "Promo Cliente Nuevo (5% descuento):";
            // 
            // lblMontoFinal
            // 
            lblMontoFinal.AutoSize = true;
            lblMontoFinal.Location = new Point(811, 713);
            lblMontoFinal.Margin = new Padding(4, 0, 4, 0);
            lblMontoFinal.Name = "lblMontoFinal";
            lblMontoFinal.Size = new Size(111, 25);
            lblMontoFinal.TabIndex = 18;
            lblMontoFinal.Text = "Monto Final:";
            // 
            // frmAltaVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 832);
            Controls.Add(lblMontoFinal);
            Controls.Add(lblPromoClienteNuevo);
            Controls.Add(lblPromoElectroHogar);
            Controls.Add(lblMontoTotal);
            Controls.Add(txtMontoTotal);
            Controls.Add(txtMontoFinal);
            Controls.Add(txtPromoClienteNuevo);
            Controls.Add(txtPromoElectroHogar);
            Controls.Add(pictureBox1);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmAltaVenta";
            Text = "Alta de Venta";
            Activated += frmAltaVenta_Activated;
            Load += frmAltaVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private TextBox txtPromoElectroHogar;
        private TextBox txtPromoClienteNuevo;
        private TextBox txtMontoFinal;
        private TextBox txtMontoTotal;
        private Label lblMontoTotal;
        private Label lblPromoElectroHogar;
        private Label lblPromoClienteNuevo;
        private Label lblMontoFinal;
    }
}