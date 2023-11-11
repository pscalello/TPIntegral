namespace InterfazForm.Ventas
{
    partial class frmABMVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMVentas));
            dgvVentas = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            idCliente = new DataGridViewTextBoxColumn();
            fechaAlta = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnDevolucion = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { id, cantidad, idCliente, fechaAlta, estado });
            dgvVentas.Location = new Point(12, 31);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 62;
            dgvVentas.RowTemplate.Height = 33;
            dgvVentas.Size = new Size(1011, 533);
            dgvVentas.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 150;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad de Productos Vendidos";
            cantidad.MinimumWidth = 8;
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            cantidad.Width = 150;
            // 
            // idCliente
            // 
            idCliente.HeaderText = "Cliente";
            idCliente.MinimumWidth = 8;
            idCliente.Name = "idCliente";
            idCliente.ReadOnly = true;
            idCliente.Width = 150;
            // 
            // fechaAlta
            // 
            fechaAlta.HeaderText = "Fecha";
            fechaAlta.MinimumWidth = 8;
            fechaAlta.Name = "fechaAlta";
            fechaAlta.ReadOnly = true;
            fechaAlta.Width = 150;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 8;
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Width = 150;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(594, 570);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(207, 34);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Venta";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnDevolucion
            // 
            btnDevolucion.Location = new Point(807, 570);
            btnDevolucion.Name = "btnDevolucion";
            btnDevolucion.Size = new Size(216, 34);
            btnDevolucion.TabIndex = 2;
            btnDevolucion.Text = "Registrar Devolución";
            btnDevolucion.UseVisualStyleBackColor = true;
            btnDevolucion.Click += btnDevolucion_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(911, 610);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 570);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 77);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmABMVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 656);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnDevolucion);
            Controls.Add(btnAgregar);
            Controls.Add(dgvVentas);
            Name = "frmABMVentas";
            Text = "ABM Ventas";
            Load += frmABMVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVentas;
        private Button btnAgregar;
        private Button btnDevolucion;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn idCliente;
        private DataGridViewTextBoxColumn fechaAlta;
        private DataGridViewTextBoxColumn estado;
    }
}