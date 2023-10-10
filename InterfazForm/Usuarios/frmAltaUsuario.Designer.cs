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
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label8 = new Label();
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
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(160, 174);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 23);
            txtEmail.TabIndex = 74;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(160, 142);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(211, 23);
            txtTelefono.TabIndex = 73;
            txtTelefono.Validating += txtTelefono_Validating;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(160, 110);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(211, 23);
            txtDireccion.TabIndex = 72;
            txtDireccion.Validating += txtDireccion_Validating;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(160, 78);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(211, 23);
            txtApellido.TabIndex = 71;
            txtApellido.Validating += txtApellido_Validating;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 23);
            txtNombre.TabIndex = 70;
            txtNombre.Validating += txtNombre_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(32, 9);
            label8.Name = "label8";
            label8.Size = new Size(226, 15);
            label8.TabIndex = 69;
            label8.Text = "TP Integral - Formulario Alta de Usuario";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(296, 349);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 68;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(206, 349);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 67;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(160, 302);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(211, 23);
            txtDNI.TabIndex = 66;
            txtDNI.Validating += txtDNI_Validating;
            // 
            // cboHost
            // 
            cboHost.FormattingEnabled = true;
            cboHost.Items.AddRange(new object[] { "Administrador", "Supervisor", "Vendedor" });
            cboHost.Location = new Point(160, 270);
            cboHost.Name = "cboHost";
            cboHost.Size = new Size(121, 23);
            cboHost.TabIndex = 65;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(160, 238);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(211, 23);
            txtNombreUsuario.TabIndex = 64;
            txtNombreUsuario.Validating += txtNombreUsuario_Validating;
            // 
            // dtiFechaNacimiento
            // 
            dtiFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtiFechaNacimiento.Location = new Point(160, 206);
            dtiFechaNacimiento.MaxDate = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            dtiFechaNacimiento.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            dtiFechaNacimiento.Name = "dtiFechaNacimiento";
            dtiFechaNacimiento.Size = new Size(121, 23);
            dtiFechaNacimiento.TabIndex = 63;
            dtiFechaNacimiento.Value = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(124, 306);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 61;
            label11.Text = "DNI:";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(117, 274);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 60;
            label10.Text = "Perfil:";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 242);
            label9.Name = "label9";
            label9.Size = new Size(113, 15);
            label9.TabIndex = 59;
            label9.Text = "Nombre de Usuario:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 210);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 58;
            label7.Text = "Fecha de Nacimiento:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(115, 177);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 56;
            label5.Text = "Email:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 145);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 55;
            label4.Text = "Telefono:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 113);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 54;
            label3.Text = "Domicilio:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 81);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 53;
            label2.Text = "Apellido:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 49);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 52;
            label1.Text = "Nombre:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmAltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 401);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label8);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label8;
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
    }
}