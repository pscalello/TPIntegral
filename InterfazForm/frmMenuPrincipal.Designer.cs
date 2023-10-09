namespace InterfazForm
{
    partial class frmMenuPrincipal
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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Location = new Point(34, 222);
            button6.Name = "button6";
            button6.Size = new Size(218, 23);
            button6.TabIndex = 11;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(34, 180);
            button5.Name = "button5";
            button5.Size = new Size(218, 23);
            button5.TabIndex = 10;
            button5.Text = "Reportes";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(34, 138);
            button4.Name = "button4";
            button4.Size = new Size(218, 23);
            button4.TabIndex = 9;
            button4.Text = "Ventas";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(34, 96);
            button3.Name = "button3";
            button3.Size = new Size(218, 23);
            button3.TabIndex = 8;
            button3.Text = "ABM Productos";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(34, 54);
            button2.Name = "button2";
            button2.Size = new Size(218, 23);
            button2.TabIndex = 7;
            button2.Text = "ABM Proveedores";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(34, 12);
            button1.Name = "button1";
            button1.Size = new Size(218, 23);
            button1.TabIndex = 6;
            button1.Text = "ABM Usuarios";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 273);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmMenuPrincipal";
            Text = "Menú Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}