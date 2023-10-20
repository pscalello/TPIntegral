﻿namespace InterfazForm
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
            btnSalir.Location = new Point(209, 144);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(114, 98);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(170, 23);
            txtContraseña.TabIndex = 10;
            txtContraseña.Validating += txtContraseña_Validating;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(114, 69);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(170, 23);
            txtUsuario.TabIndex = 9;
            txtUsuario.Validating += txtUsuario_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 102);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 8;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 74);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 7;
            label1.Text = "Usuario:";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(128, 144);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            btnIngresar.KeyDown += btnIngresar_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(62, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 46);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // logoCarga
            // 
            logoCarga.Image = Properties.Resources.icnLogoCarga;
            logoCarga.Location = new Point(89, 137);
            logoCarga.Name = "logoCarga";
            logoCarga.Size = new Size(33, 36);
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
            btnMostrarContraseña.Location = new Point(196, 121);
            btnMostrarContraseña.Name = "btnMostrarContraseña";
            btnMostrarContraseña.Size = new Size(89, 12);
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
            btnOcultarContraseña.Location = new Point(196, 121);
            btnOcultarContraseña.Name = "btnOcultarContraseña";
            btnOcultarContraseña.Size = new Size(88, 12);
            btnOcultarContraseña.TabIndex = 15;
            btnOcultarContraseña.Text = "Ocultar contraseña";
            btnOcultarContraseña.Click += btnOcultarContraseña_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 188);
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