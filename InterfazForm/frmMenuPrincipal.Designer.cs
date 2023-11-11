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
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            lblAlertaStock = new Label();
            tlDesplegableProductos = new ToolTip(components);
            btnABMClientes = new Button();
            tooltipBotonesDeshabilitados = new ToolTip(components);
            logoCarga = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoCarga).BeginInit();
            SuspendLayout();
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(41, 524);
            btnReportes.Margin = new Padding(4, 5, 4, 5);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(311, 38);
            btnReportes.TabIndex = 12;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(40, 455);
            btnVentas.Margin = new Padding(4, 5, 4, 5);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(311, 38);
            btnVentas.TabIndex = 10;
            btnVentas.Text = "Ventas y Devoluciones";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnABMProductos
            // 
            btnABMProductos.Location = new Point(40, 390);
            btnABMProductos.Margin = new Padding(4, 5, 4, 5);
            btnABMProductos.Name = "btnABMProductos";
            btnABMProductos.Size = new Size(311, 38);
            btnABMProductos.TabIndex = 9;
            btnABMProductos.Text = "ABM Productos";
            btnABMProductos.UseVisualStyleBackColor = true;
            btnABMProductos.Click += btnABMProductos_Click;
            // 
            // btnABMProveedores
            // 
            btnABMProveedores.Location = new Point(40, 260);
            btnABMProveedores.Margin = new Padding(4, 5, 4, 5);
            btnABMProveedores.Name = "btnABMProveedores";
            btnABMProveedores.Size = new Size(311, 38);
            btnABMProveedores.TabIndex = 7;
            btnABMProveedores.Text = "ABM Proveedores";
            btnABMProveedores.UseVisualStyleBackColor = true;
            btnABMProveedores.Click += btnABMProveedores_Click;
            // 
            // btnABMUsuarios
            // 
            btnABMUsuarios.Location = new Point(40, 195);
            btnABMUsuarios.Margin = new Padding(4, 5, 4, 5);
            btnABMUsuarios.Name = "btnABMUsuarios";
            btnABMUsuarios.Size = new Size(311, 38);
            btnABMUsuarios.TabIndex = 6;
            btnABMUsuarios.Text = "ABM Usuarios";
            btnABMUsuarios.UseVisualStyleBackColor = true;
            btnABMUsuarios.Click += btnABMUsuarios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 42);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 80);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(41, 594);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(311, 38);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblAlertaStock
            // 
            lblAlertaStock.AutoSize = true;
            lblAlertaStock.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblAlertaStock.ForeColor = Color.Red;
            lblAlertaStock.Location = new Point(21, 143);
            lblAlertaStock.Margin = new Padding(4, 0, 4, 0);
            lblAlertaStock.Name = "lblAlertaStock";
            lblAlertaStock.Size = new Size(357, 21);
            lblAlertaStock.TabIndex = 15;
            lblAlertaStock.Text = "*Existen productos con stock menor al 25%*";
            tlDesplegableProductos.SetToolTip(lblAlertaStock, "hola");
            // 
            // btnABMClientes
            // 
            btnABMClientes.Location = new Point(40, 325);
            btnABMClientes.Margin = new Padding(4, 5, 4, 5);
            btnABMClientes.Name = "btnABMClientes";
            btnABMClientes.Size = new Size(311, 38);
            btnABMClientes.TabIndex = 8;
            btnABMClientes.Text = "ABM Clientes";
            btnABMClientes.UseVisualStyleBackColor = true;
            btnABMClientes.Click += btnABMClientes_Click;
            // 
            // logoCarga
            // 
            logoCarga.Image = Properties.Resources.icnLogoCarga;
            logoCarga.Location = new Point(359, 455);
            logoCarga.Margin = new Padding(4, 5, 4, 5);
            logoCarga.Name = "logoCarga";
            logoCarga.Size = new Size(31, 38);
            logoCarga.SizeMode = PictureBoxSizeMode.CenterImage;
            logoCarga.TabIndex = 16;
            logoCarga.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 654);
            Controls.Add(logoCarga);
            Controls.Add(btnABMClientes);
            Controls.Add(lblAlertaStock);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Controls.Add(btnReportes);
            Controls.Add(btnVentas);
            Controls.Add(btnABMProductos);
            Controls.Add(btnABMProveedores);
            Controls.Add(btnABMUsuarios);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmMenuPrincipal";
            Text = "Menú Principal";
            Load += frmMenuPrincipal_Load;
            MouseMove += frmMenuPrincipal_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoCarga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnReportes;
        private Button btnVentas;
        private Button btnABMProductos;
        private Button btnABMProveedores;
        private Button btnABMUsuarios;
        private PictureBox pictureBox1;
        private Button btnSalir;
        private Label lblAlertaStock;
        private ToolTip tlDesplegableProductos;
        private Button btnABMClientes;
        private ToolTip tooltipBotonesDeshabilitados;
        private PictureBox logoCarga;
    }
}