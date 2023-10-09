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
            txtNuevaContraseña.Location = new Point(125, 19);
            txtNuevaContraseña.Name = "txtNuevaContraseña";
            txtNuevaContraseña.Size = new Size(170, 23);
            txtNuevaContraseña.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 11;
            label1.Text = "Nueva Contraseña:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(220, 60);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(125, 60);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmModificaContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 106);
            Controls.Add(btnSalir);
            Controls.Add(btnAceptar);
            Controls.Add(txtNuevaContraseña);
            Controls.Add(label1);
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