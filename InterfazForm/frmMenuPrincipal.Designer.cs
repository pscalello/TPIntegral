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
            btnReportes.Location = new Point(33, 417);
            btnReportes.Margin = new Padding(3, 4, 3, 4);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(250, 31);
            btnReportes.TabIndex = 12;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(32, 363);
            btnVentas.Margin = new Padding(3, 4, 3, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(250, 31);
            btnVentas.TabIndex = 10;
            btnVentas.Text = "Ventas y Devoluciones";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnABMProductos
            // 
            btnABMProductos.Location = new Point(32, 311);
            btnABMProductos.Margin = new Padding(3, 4, 3, 4);
            btnABMProductos.Name = "btnABMProductos";
            btnABMProductos.Size = new Size(250, 31);
            btnABMProductos.TabIndex = 9;
            btnABMProductos.Text = "ABM Productos";
            btnABMProductos.UseVisualStyleBackColor = true;
            btnABMProductos.Click += btnABMProductos_Click;
            // 
            // btnABMProveedores
            // 
            btnABMProveedores.Location = new Point(32, 207);
            btnABMProveedores.Margin = new Padding(3, 4, 3, 4);
            btnABMProveedores.Name = "btnABMProveedores";
            btnABMProveedores.Size = new Size(250, 31);
            btnABMProveedores.TabIndex = 7;
            btnABMProveedores.Text = "ABM Proveedores";
            btnABMProveedores.UseVisualStyleBackColor = true;
            btnABMProveedores.Click += btnABMProveedores_Click;
            // 
            // btnABMUsuarios
            // 
            btnABMUsuarios.Location = new Point(32, 155);
            btnABMUsuarios.Margin = new Padding(3, 4, 3, 4);
            btnABMUsuarios.Name = "btnABMUsuarios";
            btnABMUsuarios.Size = new Size(250, 31);
            btnABMUsuarios.TabIndex = 6;
            btnABMUsuarios.Text = "ABM Usuarios";
            btnABMUsuarios.UseVisualStyleBackColor = true;
            btnABMUsuarios.Click += btnABMUsuarios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 29);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 64);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(33, 473);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(250, 31);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnABMClientes
            // 
            btnABMClientes.Location = new Point(32, 259);
            btnABMClientes.Margin = new Padding(3, 4, 3, 4);
            btnABMClientes.Name = "btnABMClientes";
            btnABMClientes.Size = new Size(250, 31);
            btnABMClientes.TabIndex = 8;
            btnABMClientes.Text = "ABM Clientes";
            btnABMClientes.UseVisualStyleBackColor = true;
            btnABMClientes.Click += btnABMClientes_Click;
            // 
            // logoCarga
            // 
            logoCarga.Image = Properties.Resources.icnLogoCarga;
            logoCarga.Location = new Point(138, 103);
            logoCarga.Margin = new Padding(3, 4, 3, 4);
            logoCarga.Name = "logoCarga";
            logoCarga.Size = new Size(35, 41);
            logoCarga.TabIndex = 16;
            logoCarga.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 563);
            Controls.Add(logoCarga);
            Controls.Add(btnABMClientes);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Controls.Add(btnReportes);
            Controls.Add(btnVentas);
            Controls.Add(btnABMProductos);
            Controls.Add(btnABMProveedores);
            Controls.Add(btnABMUsuarios);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMenuPrincipal";
            Text = "Menú Principal";
            Load += frmMenuPrincipal_Load;
            MouseMove += frmMenuPrincipal_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoCarga).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnReportes;
        private Button btnVentas;
        private Button btnABMProductos;
        private Button btnABMProveedores;
        private Button btnABMUsuarios;
        private PictureBox pictureBox1;
        private Button btnSalir;
        private ToolTip tlDesplegableProductos;
        private Button btnABMClientes;
        private ToolTip tooltipBotonesDeshabilitados;
        private PictureBox logoCarga;
    }
}