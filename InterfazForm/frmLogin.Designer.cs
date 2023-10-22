namespace InterfazForm
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnSalir = new Button();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnIngresar = new Button();
            pictureBox1 = new PictureBox();
            backgroundLogoCarga = new System.ComponentModel.BackgroundWorker();
            logoCarga = new PictureBox();
            btnMostrarContraseña = new Label();
            btnOcultarContraseña = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoCarga).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.CausesValidation = false;
            btnSalir.DialogResult = DialogResult.Cancel;
            btnSalir.Location = new Point(299, 240);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 38);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(163, 163);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(241, 31);
            txtContraseña.TabIndex = 10;
            txtContraseña.Validating += txtContraseña_Validating;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(163, 115);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(241, 31);
            txtUsuario.TabIndex = 9;
            txtUsuario.Validating += txtUsuario_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 170);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 8;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 123);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 7;
            label1.Text = "Usuario:";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(183, 240);
            btnIngresar.Margin = new Padding(4, 5, 4, 5);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(107, 38);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            btnIngresar.KeyDown += btnIngresar_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 77);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // logoCarga
            // 
            logoCarga.Image = Properties.Resources.icnLogoCarga;
            logoCarga.Location = new Point(127, 228);
            logoCarga.Margin = new Padding(4, 5, 4, 5);
            logoCarga.Name = "logoCarga";
            logoCarga.Size = new Size(47, 60);
            logoCarga.SizeMode = PictureBoxSizeMode.CenterImage;
            logoCarga.TabIndex = 13;
            logoCarga.TabStop = false;
            // 
            // btnMostrarContraseña
            // 
            btnMostrarContraseña.AutoSize = true;
            btnMostrarContraseña.FlatStyle = FlatStyle.Popup;
            btnMostrarContraseña.Font = new Font("Segoe UI", 7F, FontStyle.Underline, GraphicsUnit.Point);
            btnMostrarContraseña.ForeColor = SystemColors.HotTrack;
            btnMostrarContraseña.Location = new Point(280, 202);
            btnMostrarContraseña.Margin = new Padding(4, 0, 4, 0);
            btnMostrarContraseña.Name = "btnMostrarContraseña";
            btnMostrarContraseña.Size = new Size(129, 19);
            btnMostrarContraseña.TabIndex = 14;
            btnMostrarContraseña.Text = "Mostrar contraseña";
            btnMostrarContraseña.Click += btnMostrarContraseña_Click;
            // 
            // btnOcultarContraseña
            // 
            btnOcultarContraseña.AutoSize = true;
            btnOcultarContraseña.FlatStyle = FlatStyle.Popup;
            btnOcultarContraseña.Font = new Font("Segoe UI", 7F, FontStyle.Underline, GraphicsUnit.Point);
            btnOcultarContraseña.ForeColor = Color.RoyalBlue;
            btnOcultarContraseña.Location = new Point(280, 202);
            btnOcultarContraseña.Margin = new Padding(4, 0, 4, 0);
            btnOcultarContraseña.Name = "btnOcultarContraseña";
            btnOcultarContraseña.Size = new Size(125, 19);
            btnOcultarContraseña.TabIndex = 15;
            btnOcultarContraseña.Text = "Ocultar contraseña";
            btnOcultarContraseña.Click += btnOcultarContraseña_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(451, 313);
            ControlBox = false;
            Controls.Add(btnOcultarContraseña);
            Controls.Add(btnMostrarContraseña);
            Controls.Add(logoCarga);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIngresar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoCarga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
        private Button btnIngresar;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundLogoCarga;
        private PictureBox logoCarga;
        private Label btnMostrarContraseña;
        private Label btnOcultarContraseña;
    }
}