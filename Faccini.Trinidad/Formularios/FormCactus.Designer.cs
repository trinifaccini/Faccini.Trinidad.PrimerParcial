namespace Formularios
{
    partial class FormCactus
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
            lblTitulo = new Label();
            btnEspinas = new RadioButton();
            btnFlor = new RadioButton();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(149, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(207, 15);
            lblTitulo.TabIndex = 20;
            lblTitulo.Text = "AGREGAR NUEVO CACTUS AL VIVERO";
            // 
            // btnEspinas
            // 
            btnEspinas.AutoSize = true;
            btnEspinas.Location = new Point(282, 265);
            btnEspinas.Name = "btnEspinas";
            btnEspinas.Size = new Size(95, 19);
            btnEspinas.TabIndex = 21;
            btnEspinas.TabStop = true;
            btnEspinas.Text = "Tiene espinas";
            btnEspinas.UseVisualStyleBackColor = true;
            // 
            // btnFlor
            // 
            btnFlor.AutoSize = true;
            btnFlor.Location = new Point(282, 327);
            btnFlor.Name = "btnFlor";
            btnFlor.Size = new Size(74, 19);
            btnFlor.TabIndex = 22;
            btnFlor.TabStop = true;
            btnFlor.Text = "Tiene flor";
            btnFlor.UseVisualStyleBackColor = true;
            // 
            // FormCactus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 450);
            Controls.Add(btnFlor);
            Controls.Add(btnEspinas);
            Controls.Add(lblTitulo);
            Name = "FormCactus";
            Text = "FormCactus";
            Controls.SetChildIndex(lblTitulo, 0);
            Controls.SetChildIndex(btnEspinas, 0);
            Controls.SetChildIndex(btnFlor, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private RadioButton btnEspinas;
        private RadioButton btnFlor;
    }
}