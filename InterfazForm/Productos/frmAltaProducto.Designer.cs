namespace InterfazForm.Proveedores
{
    partial class frmAltaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaProducto));
            btnCancelar = new Button();
            btnAgregar = new Button();
            categoria = new Label();
            txtPrecio = new TextBox();
            Precio = new Label();
            txtId = new TextBox();
            fechaAlta = new Label();
            id = new Label();
            pictureBox1 = new PictureBox();
            fechaAltaPicker = new DateTimePicker();
            cboHost = new ComboBox();
            txtStock = new TextBox();
            Stock = new Label();
            txtNombre = new TextBox();
            Nombre = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(227, 252);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(137, 252);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 48;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // categoria
            // 
            categoria.AutoSize = true;
            categoria.Location = new Point(30, 96);
            categoria.Name = "categoria";
            categoria.Size = new Size(61, 15);
            categoria.TabIndex = 45;
            categoria.Text = "Categoría:";
            categoria.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(90, 185);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(211, 23);
            txtPrecio.TabIndex = 44;
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Location = new Point(47, 188);
            Precio.Name = "Precio";
            Precio.Size = new Size(43, 15);
            Precio.TabIndex = 43;
            Precio.Text = "Precio:";
            Precio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            txtId.Location = new Point(91, 64);
            txtId.Name = "txtId";
            txtId.Size = new Size(211, 23);
            txtId.TabIndex = 39;
            // 
            // fechaAlta
            // 
            fechaAlta.AutoSize = true;
            fechaAlta.Location = new Point(12, 161);
            fechaAlta.Name = "fechaAlta";
            fechaAlta.Size = new Size(79, 15);
            fechaAlta.TabIndex = 38;
            fechaAlta.Text = "Fecha de alta:";
            fechaAlta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(71, 67);
            id.Name = "id";
            id.Size = new Size(20, 15);
            id.TabIndex = 35;
            id.Text = "Id:";
            id.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 46);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // fechaAltaPicker
            // 
            fechaAltaPicker.Location = new Point(90, 156);
            fechaAltaPicker.Name = "fechaAltaPicker";
            fechaAltaPicker.Size = new Size(211, 23);
            fechaAltaPicker.TabIndex = 51;
            // 
            // cboHost
            // 
            cboHost.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHost.FormattingEnabled = true;
            cboHost.Items.AddRange(new object[] { "Administrador", "Supervisor", "Vendedor" });
            cboHost.Location = new Point(91, 93);
            cboHost.Name = "cboHost";
            cboHost.Size = new Size(211, 23);
            cboHost.TabIndex = 52;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(90, 214);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(211, 23);
            txtStock.TabIndex = 54;
            // 
            // Stock
            // 
            Stock.AutoSize = true;
            Stock.Location = new Point(52, 217);
            Stock.Name = "Stock";
            Stock.Size = new Size(39, 15);
            Stock.TabIndex = 53;
            Stock.Text = "Stock:";
            Stock.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(91, 125);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 23);
            txtNombre.TabIndex = 56;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(37, 128);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(54, 15);
            Nombre.TabIndex = 55;
            Nombre.Text = "Nombre:";
            Nombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmAltaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 312);
            Controls.Add(txtNombre);
            Controls.Add(Nombre);
            Controls.Add(txtStock);
            Controls.Add(Stock);
            Controls.Add(cboHost);
            Controls.Add(fechaAltaPicker);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(categoria);
            Controls.Add(txtPrecio);
            Controls.Add(Precio);
            Controls.Add(txtId);
            Controls.Add(fechaAlta);
            Controls.Add(id);
            Name = "frmAltaProducto";
            Text = "Alta de Producto";
            Load += frmAltaProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAgregar;
        private Label categoria;
        private TextBox txtPrecio;
        private Label Precio;
        private TextBox txtId;
        private Label fechaAlta;
        private Label id;
        private PictureBox pictureBox1;
        private DateTimePicker fechaAltaPicker;
        private ComboBox cboHost;
        private TextBox txtStock;
        private Label Stock;
        private TextBox txtNombre;
        private Label Nombre;
    }

    /*Id = id;
            IdCategoria = idCategoria;
            Nombre = nombre;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
            Precio = precio;
            Stock = stock;
            IdUsuario = idUsuario;
            IdProveedor = idProveedor;
    */
}