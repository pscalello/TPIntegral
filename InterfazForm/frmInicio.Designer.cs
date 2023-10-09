namespace InterfazForm
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegistrarse = new Button();
            btnLogin = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(21, 79);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(179, 61);
            btnRegistrarse.TabIndex = 3;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(21, 12);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(179, 61);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(21, 146);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(179, 61);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 221);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnLogin);
            Name = "frmInicio";
            Text = "Inicio - TP Integral 2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarse;
        private Button btnLogin;
        private Button btnSalir;
    }
}