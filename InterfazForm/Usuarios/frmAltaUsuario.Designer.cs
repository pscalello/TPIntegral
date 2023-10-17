namespace InterfazForm.Usuarios
{
    partial class frmAltaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaUsuario));
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnCancelar = new Button();
            btnAgregar = new Button();
            txtDNI = new TextBox();
            cboHost = new ComboBox();
            txtNombreUsuario = new TextBox();
            dtiFechaNacimiento = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 207);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(150, 175);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(211, 23);
            txtTelefono.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(150, 143);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(211, 23);
            txtDireccion.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(150, 111);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(211, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(286, 382);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(196, 382);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(150, 335);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(211, 23);
            txtDNI.TabIndex = 9;
            // 
            // cboHost
            // 
            cboHost.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHost.FormattingEnabled = true;
            cboHost.Items.AddRange(new object[] { "Administrador", "Supervisor", "Vendedor" });
            cboHost.Location = new Point(150, 303);
            cboHost.Name = "cboHost";
            cboHost.Size = new Size(121, 23);
            cboHost.TabIndex = 8;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(150, 271);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(211, 23);
            txtNombreUsuario.TabIndex = 7;
            // 
            // dtiFechaNacimiento
            // 
            dtiFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtiFechaNacimiento.Location = new Point(150, 239);
            dtiFechaNacimiento.MaxDate = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            dtiFechaNacimiento.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            dtiFechaNacimiento.Name = "dtiFechaNacimiento";
            dtiFechaNacimiento.Size = new Size(121, 23);
            dtiFechaNacimiento.TabIndex = 6;
            dtiFechaNacimiento.Value = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(114, 339);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 61;
            label11.Text = "DNI:";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(107, 307);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 60;
            label10.Text = "Perfil:";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 275);
            label9.Name = "label9";
            label9.Size = new Size(113, 15);
            label9.TabIndex = 59;
            label9.Text = "Nombre de Usuario:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 243);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 58;
            label7.Text = "Fecha de Nacimiento:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 210);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 56;
            label5.Text = "Email:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 178);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 55;
            label4.Text = "Telefono:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 146);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 54;
            label3.Text = "Domicilio:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 114);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 53;
            label2.Text = "Apellido:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 82);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 52;
            label1.Text = "Nombre:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(145, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 46);
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // frmAltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 427);
            Controls.Add(pictureBox1);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDNI);
            Controls.Add(cboHost);
            Controls.Add(txtNombreUsuario);
            Controls.Add(dtiFechaNacimiento);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAltaUsuario";
            Text = "Alta de Usuario";
            Load += frmAltaUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnCancelar;
        private Button btnAgregar;
        private TextBox txtDNI;
        private ComboBox cboHost;
        private TextBox txtNombreUsuario;
        private DateTimePicker dtiFechaNacimiento;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}