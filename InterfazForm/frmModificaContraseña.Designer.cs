namespace InterfazForm
{
    partial class frmModificaContraseña
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
            txtNuevaContraseña = new TextBox();
            label1 = new Label();
            btnSalir = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // txtNuevaContraseña
            // 
            txtNuevaContraseña.Location = new Point(179, 32);
            txtNuevaContraseña.Margin = new Padding(4, 5, 4, 5);
            txtNuevaContraseña.Name = "txtNuevaContraseña";
            txtNuevaContraseña.Size = new Size(241, 31);
            txtNuevaContraseña.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 11;
            label1.Text = "Nueva Contraseña:";
            // 
            // btnSalir
            // 
            btnSalir.CausesValidation = false;
            btnSalir.DialogResult = DialogResult.Cancel;
            btnSalir.Location = new Point(314, 100);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 38);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(199, 100);
            btnAceptar.Margin = new Padding(4, 5, 4, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(107, 38);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmModificaContraseña
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 177);
            Controls.Add(btnSalir);
            Controls.Add(btnAceptar);
            Controls.Add(txtNuevaContraseña);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmModificaContraseña";
            Text = "Modificación de Contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNuevaContraseña;
        private Label label1;
        private Button btnSalir;
        private Button btnAceptar;
    }
}