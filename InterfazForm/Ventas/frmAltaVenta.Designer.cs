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
            dgvVenta.Location = new Point(24, 78);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.RowHeadersWidth = 51;
            dgvVenta.RowTemplate.Height = 25;
            dgvVenta.Size = new Size(740, 243);
            dgvVenta.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Fecha:";
            // 
            // dtiFechaVenta
            // 
            dtiFechaVenta.Format = DateTimePickerFormat.Custom;
            dtiFechaVenta.Location = new Point(71, 17);
            dtiFechaVenta.Margin = new Padding(3, 2, 3, 2);
            dtiFechaVenta.Name = "dtiFechaVenta";
            dtiFechaVenta.Size = new Size(109, 23);
            dtiFechaVenta.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 51);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(71, 46);
            txtCliente.Margin = new Padding(3, 2, 3, 2);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(201, 23);
            txtCliente.TabIndex = 4;
            // 
            // btnSeleccionarCliente
            // 
            btnSeleccionarCliente.Location = new Point(278, 46);
            btnSeleccionarCliente.Margin = new Padding(3, 2, 3, 2);
            btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            btnSeleccionarCliente.Size = new Size(82, 22);
            btnSeleccionarCliente.TabIndex = 5;
            btnSeleccionarCliente.Text = "Seleccionar";
            btnSeleccionarCliente.UseVisualStyleBackColor = true;
            btnSeleccionarCliente.Click += btnSeleccionarCliente_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(24, 335);
            btnAgregarProducto.Margin = new Padding(3, 2, 3, 2);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(122, 32);
            btnAgregarProducto.TabIndex = 6;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(24, 376);
            btnEliminarProducto.Margin = new Padding(3, 2, 3, 2);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(122, 32);
            btnEliminarProducto.TabIndex = 7;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.Location = new Point(519, 465);
            btnConfirmarVenta.Margin = new Padding(3, 2, 3, 2);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(110, 22);
            btnConfirmarVenta.TabIndex = 8;
            btnConfirmarVenta.Text = "Confirmar Venta";
            btnConfirmarVenta.UseVisualStyleBackColor = true;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.Location = new Point(644, 465);
            btnCancelarVenta.Margin = new Padding(3, 2, 3, 2);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(110, 22);
            btnCancelarVenta.TabIndex = 9;
            btnCancelarVenta.Text = "Cancelar";
            btnCancelarVenta.UseVisualStyleBackColor = true;
            btnCancelarVenta.Click += btnCancelarVenta_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_electrohogar;
            pictureBox1.Location = new Point(543, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 50);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // txtPromoElectroHogar
            // 
            txtPromoElectroHogar.Location = new Point(654, 369);
            txtPromoElectroHogar.Name = "txtPromoElectroHogar";
            txtPromoElectroHogar.Size = new Size(100, 23);
            txtPromoElectroHogar.TabIndex = 11;
            // 
            // txtPromoClienteNuevo
            // 
            txtPromoClienteNuevo.Location = new Point(654, 398);
            txtPromoClienteNuevo.Name = "txtPromoClienteNuevo";
            txtPromoClienteNuevo.Size = new Size(100, 23);
            txtPromoClienteNuevo.TabIndex = 12;
            // 
            // txtMontoFinal
            // 
            txtMontoFinal.Location = new Point(654, 428);
            txtMontoFinal.Name = "txtMontoFinal";
            txtMontoFinal.Size = new Size(100, 23);
            txtMontoFinal.TabIndex = 13;
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.Location = new Point(654, 340);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(100, 23);
            txtMontoTotal.TabIndex = 14;
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Location = new Point(461, 344);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(180, 15);
            lblMontoTotal.TabIndex = 15;
            lblMontoTotal.Text = "Monto Total Previo A Descuento:";
            // 
            // lblPromoElectroHogar
            // 
            lblPromoElectroHogar.AutoSize = true;
            lblPromoElectroHogar.Location = new Point(439, 372);
            lblPromoElectroHogar.Name = "lblPromoElectroHogar";
            lblPromoElectroHogar.Size = new Size(206, 15);
            lblPromoElectroHogar.TabIndex = 16;
            lblPromoElectroHogar.Text = "Promo Electro Hogar (5% descuento):";
            // 
            // lblPromoClienteNuevo
            // 
            lblPromoClienteNuevo.AutoSize = true;
            lblPromoClienteNuevo.Location = new Point(433, 401);
            lblPromoClienteNuevo.Name = "lblPromoClienteNuevo";
            lblPromoClienteNuevo.Size = new Size(209, 15);
            lblPromoClienteNuevo.TabIndex = 17;
            lblPromoClienteNuevo.Text = "Promo Cliente Nuevo (5% descuento):";
            // 
            // lblMontoFinal
            // 
            lblMontoFinal.AutoSize = true;
            lblMontoFinal.Location = new Point(568, 428);
            lblMontoFinal.Name = "lblMontoFinal";
            lblMontoFinal.Size = new Size(74, 15);
            lblMontoFinal.TabIndex = 18;
            lblMontoFinal.Text = "Monto Final:";
            // 
            // frmAltaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 499);
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
            Name = "frmAltaVenta";
            Text = "frmAltaVenta";
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