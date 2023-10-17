﻿namespace InterfazForm.Proveedores
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
            label2 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label9 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            cboHost = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(228, 218);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(138, 218);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 48;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 96);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 45;
            label2.Text = "Categoría:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(91, 151);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 23);
            txtEmail.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 154);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 43;
            label5.Text = "Precio:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(91, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 23);
            txtNombre.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 127);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 38;
            label9.Text = "Fecha de alta:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 67);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 35;
            label1.Text = "Id:";
            label1.TextAlign = ContentAlignment.MiddleRight;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(91, 122);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 51;
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
            // textBox1
            // 
            textBox1.Location = new Point(91, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 183);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 53;
            label3.Text = "Stock:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmAltaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 263);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(cboHost);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(label9);
            Controls.Add(label1);
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
        private Label label2;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtNombre;
        private Label label9;
        private Label label1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox cboHost;
        private TextBox textBox1;
        private Label label3;
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