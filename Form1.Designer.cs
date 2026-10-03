namespace HolaMundo
{
    partial class Form1
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
            Contraseña = new TextBox();
            Validar = new Button();
            ConfirmarContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Contraseña
            // 
            Contraseña.Location = new Point(181, 53);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(100, 23);
            Contraseña.TabIndex = 0;
            // 
            // Validar
            // 
            Validar.Location = new Point(191, 140);
            Validar.Name = "Validar";
            Validar.Size = new Size(75, 23);
            Validar.TabIndex = 1;
            Validar.Text = "Validar";
            Validar.UseVisualStyleBackColor = true;
            Validar.Click += Validar_Click;
            // 
            // ConfirmarContraseña
            // 
            ConfirmarContraseña.Location = new Point(181, 95);
            ConfirmarContraseña.Name = "ConfirmarContraseña";
            ConfirmarContraseña.Size = new Size(100, 23);
            ConfirmarContraseña.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 56);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 3;
            label3.Text = "Escribe tu contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 98);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 4;
            label4.Text = "Confirma la contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ConfirmarContraseña);
            Controls.Add(Validar);
            Controls.Add(Contraseña);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Contraseña;
        private Button Validar;
        private TextBox ConfirmarContraseña;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
