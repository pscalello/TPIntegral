namespace InterfazForm
{
    partial class frmMenuPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            btnReportes = new Button();
            btnVentas = new Button();
            btnABMProductos = new Button();
            btnABMProveedores = new Button();
            btnABMUsuarios = new Button();
            btnDevoluciones = new Button();
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            lblAlertaStock = new Label();
            tlDesplegableProductos = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(28, 322);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(218, 23);
            btnReportes.TabIndex = 10;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(28, 240);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(218, 23);
            btnVentas.TabIndex = 9;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnABMProductos
            // 
            btnABMProductos.Location = new Point(28, 199);
            btnABMProductos.Name = "btnABMProductos";
            btnABMProductos.Size = new Size(218, 23);
            btnABMProductos.TabIndex = 8;
            btnABMProductos.Text = "ABM Productos";
            btnABMProductos.UseVisualStyleBackColor = true;
            btnABMProductos.Click += btnABMProductos_Click;
            // 
            // btnABMProveedores
            // 
            btnABMProveedores.Location = new Point(28, 158);
            btnABMProveedores.Name = "btnABMProveedores";
            btnABMProveedores.Size = new Size(218, 23);
            btnABMProveedores.TabIndex = 7;
            btnABMProveedores.Text = "ABM Proveedores";
            btnABMProveedores.UseVisualStyleBackColor = true;
            btnABMProveedores.Click += btnABMProveedores_Click;
            // 
            // btnABMUsuarios
            // 
            btnABMUsuarios.Location = new Point(28, 117);
            btnABMUsuarios.Name = "btnABMUsuarios";
            btnABMUsuarios.Size = new Size(218, 23);
            btnABMUsuarios.TabIndex = 6;
            btnABMUsuarios.Text = "ABM Usuarios";
            btnABMUsuarios.UseVisualStyleBackColor = true;
            btnABMUsuarios.Click += btnABMUsuarios_Click;
            // 
            // btnDevoluciones
            // 
            btnDevoluciones.Location = new Point(28, 281);
            btnDevoluciones.Name = "btnDevoluciones";
            btnDevoluciones.Size = new Size(218, 23);
            btnDevoluciones.TabIndex = 12;
            btnDevoluciones.Text = "Devoluciones";
            btnDevoluciones.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 48);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(28, 362);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(218, 23);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblAlertaStock
            // 
            lblAlertaStock.AutoSize = true;
            lblAlertaStock.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblAlertaStock.ForeColor = Color.Red;
            lblAlertaStock.Location = new Point(15, 86);
            lblAlertaStock.Name = "lblAlertaStock";
            lblAlertaStock.Size = new Size(245, 13);
            lblAlertaStock.TabIndex = 15;
            lblAlertaStock.Text = "*Existen productos con stock menor al 25%*";
            tlDesplegableProductos.SetToolTip(lblAlertaStock, "hola");
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 407);
            Controls.Add(lblAlertaStock);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Controls.Add(btnDevoluciones);
            Controls.Add(btnReportes);
            Controls.Add(btnVentas);
            Controls.Add(btnABMProductos);
            Controls.Add(btnABMProveedores);
            Controls.Add(btnABMUsuarios);
            Name = "frmMenuPrincipal";
            Text = "Menú Principal";
            Load += frmMenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnReportes;
        private Button btnVentas;
        private Button btnABMProductos;
        private Button btnABMProveedores;
        private Button btnABMUsuarios;
        private Button btnDevoluciones;
        private PictureBox pictureBox1;
        private Button btnSalir;
        private Label lblAlertaStock;
        private ToolTip tlDesplegableProductos;
    }
}