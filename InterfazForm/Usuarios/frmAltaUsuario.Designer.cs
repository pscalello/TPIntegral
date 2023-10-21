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
            txtEmail.Location = new Point(214, 345);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 31);
            txtEmail.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(214, 292);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(300, 31);
            txtTelefono.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(214, 238);
            txtDireccion.Margin = new Padding(4, 5, 4, 5);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(300, 31);
            txtDireccion.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(214, 185);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(300, 31);
            txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(214, 132);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 31);
            txtNombre.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(409, 637);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 38);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(280, 637);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(107, 38);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(214, 558);
            txtDNI.Margin = new Padding(4, 5, 4, 5);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(300, 31);
            txtDNI.TabIndex = 9;
            // 
            // cboHost
            // 
            cboHost.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHost.FormattingEnabled = true;
            cboHost.Items.AddRange(new object[] { "Vendedor", "Supervisor", "Administrador" });
            cboHost.Location = new Point(214, 505);
            cboHost.Margin = new Padding(4, 5, 4, 5);
            cboHost.Name = "cboHost";
            cboHost.Size = new Size(171, 33);
            cboHost.TabIndex = 8;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(214, 452);
            txtNombreUsuario.Margin = new Padding(4, 5, 4, 5);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(300, 31);
            txtNombreUsuario.TabIndex = 7;
            // 
            // dtiFechaNacimiento
            // 
            dtiFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtiFechaNacimiento.Location = new Point(214, 398);
            dtiFechaNacimiento.Margin = new Padding(4, 5, 4, 5);
            dtiFechaNacimiento.MaxDate = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            dtiFechaNacimiento.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            dtiFechaNacimiento.Name = "dtiFechaNacimiento";
            dtiFechaNacimiento.Size = new Size(171, 31);
            dtiFechaNacimiento.TabIndex = 6;
            dtiFechaNacimiento.Value = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(163, 565);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(47, 25);
            label11.TabIndex = 61;
            label11.Text = "DNI:";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(153, 512);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(54, 25);
            label10.TabIndex = 60;
            label10.Text = "Perfil:";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 458);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(172, 25);
            label9.TabIndex = 59;
            label9.Text = "Nombre de Usuario:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 405);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(181, 25);
            label7.TabIndex = 58;
            label7.Text = "Fecha de Nacimiento:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 350);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 56;
            label5.Text = "Email:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 297);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 55;
            label4.Text = "Telefono:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 243);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 54;
            label3.Text = "Domicilio:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 190);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 53;
            label2.Text = "Apellido:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 137);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 52;
            label1.Text = "Nombre:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(207, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 77);
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // frmAltaUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 712);
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
            Margin = new Padding(4, 5, 4, 5);
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