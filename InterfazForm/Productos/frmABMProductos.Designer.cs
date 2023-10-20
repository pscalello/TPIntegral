namespace InterfazForm.Productos
{
    partial class frmABMProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMProductos));
            dgvProductos = new DataGridView();
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnAltaProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(24, 24);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(752, 350);
            dgvProductos.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 392);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 46);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(700, 419);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(700, 380);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAltaProducto
            // 
            btnAltaProducto.Location = new Point(619, 380);
            btnAltaProducto.Name = "btnAltaProducto";
            btnAltaProducto.Size = new Size(75, 23);
            btnAltaProducto.TabIndex = 8;
            btnAltaProducto.Text = "Agregar";
            btnAltaProducto.UseVisualStyleBackColor = true;
            btnAltaProducto.Click += btnAltaProducto_Click;
            // 
            // frmABMProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnAltaProducto);
            Controls.Add(pictureBox1);
            Controls.Add(dgvProductos);
            Name = "frmABMProductos";
            Text = "frmABMProductos";
            Load += frmABMProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private PictureBox pictureBox1;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnAltaProducto;
    }
}