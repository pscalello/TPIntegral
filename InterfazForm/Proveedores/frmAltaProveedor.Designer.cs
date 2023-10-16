namespace InterfazForm.Proveedores
{
    partial class frmAltaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaProveedor));
            btnCancelar = new Button();
            btnAgregar = new Button();
            txtApellido = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtCUIT = new TextBox();
            txtNombre = new TextBox();
            label9 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(227, 220);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(137, 220);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 48;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(91, 112);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(211, 23);
            txtApellido.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 115);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 45;
            label2.Text = "Apellido:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(91, 178);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 23);
            txtEmail.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 181);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 43;
            label5.Text = "Email:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(91, 146);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(211, 23);
            txtCUIT.TabIndex = 42;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(91, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 23);
            txtNombre.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(50, 149);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 38;
            label9.Text = "CUIT:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 83);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 35;
            label1.Text = "Nombre:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 46);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // frmAltaProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 272);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtCUIT);
            Controls.Add(txtNombre);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "frmAltaProveedor";
            Text = "Alta de Proveedores";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAgregar;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtCUIT;
        private TextBox txtNombre;
        private Label label9;
        private Label label1;
        private PictureBox pictureBox1;
    }
}