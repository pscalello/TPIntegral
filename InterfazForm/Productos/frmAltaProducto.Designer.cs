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
            pictureBox1 = new PictureBox();
            cboCategoria = new ComboBox();
            txtStock = new TextBox();
            Stock = new Label();
            Nombre = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            cboProveedor = new ComboBox();
            cboGuidProveedor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(259, 336);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(157, 336);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 48;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // categoria
            // 
            categoria.AutoSize = true;
            categoria.Location = new Point(34, 128);
            categoria.Name = "categoria";
            categoria.Size = new Size(77, 20);
            categoria.TabIndex = 45;
            categoria.Text = "Categoría:";
            categoria.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(103, 247);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(241, 27);
            txtPrecio.TabIndex = 44;
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Location = new Point(54, 250);
            Precio.Name = "Precio";
            Precio.Size = new Size(53, 20);
            Precio.TabIndex = 43;
            Precio.Text = "Precio:";
            Precio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 61);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Items.AddRange(new object[] { "Audio", "Celulares", "Electro Hogar", "Informática", "Smart TV" });
            cboCategoria.Location = new Point(104, 124);
            cboCategoria.Margin = new Padding(3, 4, 3, 4);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(241, 28);
            cboCategoria.TabIndex = 52;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(103, 285);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(241, 27);
            txtStock.TabIndex = 54;
            // 
            // Stock
            // 
            Stock.AutoSize = true;
            Stock.Location = new Point(59, 289);
            Stock.Name = "Stock";
            Stock.Size = new Size(48, 20);
            Stock.TabIndex = 53;
            Stock.Text = "Stock:";
            Stock.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(42, 171);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(67, 20);
            Nombre.TabIndex = 55;
            Nombre.Text = "Nombre:";
            Nombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(104, 167);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 27);
            txtNombre.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 209);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 58;
            label1.Text = "Proveedor:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboProveedor
            // 
            cboProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProveedor.FormattingEnabled = true;
            cboProveedor.Location = new Point(104, 207);
            cboProveedor.Name = "cboProveedor";
            cboProveedor.Size = new Size(241, 28);
            cboProveedor.TabIndex = 59;
            cboProveedor.SelectedIndexChanged += cboProveedor_SelectedIndexChanged;
            // 
            // cboGuidProveedor
            // 
            cboGuidProveedor.FormattingEnabled = true;
            cboGuidProveedor.Location = new Point(376, 205);
            cboGuidProveedor.Name = "cboGuidProveedor";
            cboGuidProveedor.Size = new Size(151, 28);
            cboGuidProveedor.TabIndex = 60;
            // 
            // frmAltaProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 416);
            Controls.Add(cboGuidProveedor);
            Controls.Add(cboProveedor);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(Nombre);
            Controls.Add(txtStock);
            Controls.Add(Stock);
            Controls.Add(cboCategoria);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(categoria);
            Controls.Add(txtPrecio);
            Controls.Add(Precio);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label id;
        private PictureBox pictureBox1;
        private ComboBox cboCategoria;
        private TextBox txtStock;
        private Label Stock;
        private Label Nombre;
        private TextBox txtNombre;
        private Label label1;
        private ComboBox cboProveedor;
        private ComboBox cboGuidProveedor;
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