namespace Formularios
{
    partial class FormFlor
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
            lblColor = new Label();
            btnOlor = new RadioButton();
            txtColor = new TextBox();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(283, 247);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(85, 15);
            lblColor.TabIndex = 16;
            lblColor.Text = "Color de la flor";
            lblColor.Click += label1_Click;
            // 
            // btnOlor
            // 
            btnOlor.AutoSize = true;
            btnOlor.Location = new Point(283, 317);
            btnOlor.Name = "btnOlor";
            btnOlor.Size = new Size(77, 19);
            btnOlor.TabIndex = 17;
            btnOlor.TabStop = true;
            btnOlor.Text = "Tiene olor";
            btnOlor.UseVisualStyleBackColor = true;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(283, 266);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 23);
            txtColor.TabIndex = 18;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(167, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(189, 15);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "AGREGAR NUEVA FLOR AL VIVERO";
            // 
            // FormFlor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 473);
            Controls.Add(lblTitulo);
            Controls.Add(txtColor);
            Controls.Add(btnOlor);
            Controls.Add(lblColor);
            Name = "FormFlor";
            Text = "PROPIEDADES FLOR";
            Controls.SetChildIndex(lblColor, 0);
            Controls.SetChildIndex(btnOlor, 0);
            Controls.SetChildIndex(txtColor, 0);
            Controls.SetChildIndex(lblTitulo, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblColor;
        private RadioButton btnOlor;
        private TextBox txtColor;
        private Label lblTitulo;
    }
}