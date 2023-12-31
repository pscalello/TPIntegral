﻿namespace InterfazForm.Ventas
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
            components = new System.ComponentModel.Container();
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
            tooltipBotonesDeshabilitados = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { id, cantidad, idCliente, fechaAlta, estado });
            dgvVentas.Location = new Point(9, 25);
            dgvVentas.Margin = new Padding(2, 3, 2, 3);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 62;
            dgvVentas.RowTemplate.Height = 33;
            dgvVentas.Size = new Size(809, 427);
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
            btnAgregar.Location = new Point(475, 464);
            btnAgregar.Margin = new Padding(2, 3, 2, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(166, 37);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Venta";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnDevolucion
            // 
            btnDevolucion.Location = new Point(646, 464);
            btnDevolucion.Margin = new Padding(2, 3, 2, 3);
            btnDevolucion.Name = "btnDevolucion";
            btnDevolucion.Size = new Size(173, 37);
            btnDevolucion.TabIndex = 2;
            btnDevolucion.Text = "Registrar Devolución";
            btnDevolucion.UseVisualStyleBackColor = true;
            btnDevolucion.Click += btnDevolucion_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(729, 507);
            btnSalir.Margin = new Padding(2, 3, 2, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 36);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 464);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 61);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmABMVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 557);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnDevolucion);
            Controls.Add(btnAgregar);
            Controls.Add(dgvVentas);
            Margin = new Padding(2, 3, 2, 3);
            Name = "frmABMVentas";
            Text = "ABM Ventas";
            Load += frmABMVentas_Load;
            MouseMove += frmABMVentas_MouseMove;
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
        private ToolTip tooltipBotonesDeshabilitados;
    }
}