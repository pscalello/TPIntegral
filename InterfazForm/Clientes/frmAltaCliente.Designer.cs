namespace InterfazForm.Clientes
{
    partial class frmAltaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaCliente));
            pictureBox1 = new PictureBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnCancelar = new Button();
            btnAgregar = new Button();
            txtDNI = new TextBox();
            dtiFechaNacimiento = new DateTimePicker();
            label11 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 46);
            pictureBox1.TabIndex = 91;
            pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(155, 234);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(155, 203);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(211, 23);
            txtTelefono.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(155, 172);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(211, 23);
            txtDireccion.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(155, 110);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(211, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(155, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(291, 311);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(201, 311);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(155, 141);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(211, 23);
            txtDNI.TabIndex = 3;
            // 
            // dtiFechaNacimiento
            // 
            dtiFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtiFechaNacimiento.Location = new Point(155, 265);
            dtiFechaNacimiento.MaxDate = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            dtiFechaNacimiento.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            dtiFechaNacimiento.Name = "dtiFechaNacimiento";
            dtiFechaNacimiento.Size = new Size(121, 23);
            dtiFechaNacimiento.TabIndex = 7;
            dtiFechaNacimiento.Value = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(119, 144);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 90;
            label11.Text = "DNI:";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 268);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 87;
            label7.Text = "Fecha de Nacimiento:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 237);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 86;
            label5.Text = "Email:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 206);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 85;
            label4.Text = "Telefono:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 175);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 84;
            label3.Text = "Domicilio:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 113);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 83;
            label2.Text = "Apellido:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 82);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 82;
            label1.Text = "Nombre:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmAltaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 353);
            Controls.Add(pictureBox1);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDNI);
            Controls.Add(dtiFechaNacimiento);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAltaCliente";
            Text = "Alta Cliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnCancelar;
        private Button btnAgregar;
        private TextBox txtDNI;
        private DateTimePicker dtiFechaNacimiento;
        private Label label11;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}