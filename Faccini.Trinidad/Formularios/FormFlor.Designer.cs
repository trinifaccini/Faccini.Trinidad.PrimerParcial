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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFlor));
            lblColor = new Label();
            txtColor = new TextBox();
            lblTitulo = new Label();
            chBoxOlor = new CheckBox();
            SuspendLayout();
            // 
            // checkedListBoxAmbiente
            // 
            checkedListBoxAmbiente.SelectedIndexChanged += checkedListBoxAmbiente_SelectedIndexChanged;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(283, 247);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(85, 15);
            lblColor.TabIndex = 16;
            lblColor.Text = "Color de la flor";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(283, 266);
            txtColor.Name = "txtColor";
            txtColor.PlaceholderText = "Ingrese el color de la flor";
            txtColor.Size = new Size(157, 23);
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
            // chBoxOlor
            // 
            chBoxOlor.AutoSize = true;
            chBoxOlor.Location = new Point(282, 327);
            chBoxOlor.Name = "chBoxOlor";
            chBoxOlor.Size = new Size(78, 19);
            chBoxOlor.TabIndex = 20;
            chBoxOlor.Text = "Tiene olor";
            chBoxOlor.UseVisualStyleBackColor = true;
            // 
            // FormFlor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(523, 473);
            Controls.Add(chBoxOlor);
            Controls.Add(lblTitulo);
            Controls.Add(txtColor);
            Controls.Add(lblColor);
            Name = "FormFlor";
            Text = "PROPIEDADES FLOR";
            Load += FormFlor_Load;
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtPrecio, 0);
            Controls.SetChildIndex(txtFrecuencia, 0);
            Controls.SetChildIndex(cbmBoxEstacion, 0);
            Controls.SetChildIndex(checkedListBoxAmbiente, 0);
            Controls.SetChildIndex(txtAlturaActual, 0);
            Controls.SetChildIndex(txtAlturaMax, 0);
            Controls.SetChildIndex(lblAlturaTransplante, 0);
            Controls.SetChildIndex(txtAlturaTransplante, 0);
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(lblColor, 0);
            Controls.SetChildIndex(txtColor, 0);
            Controls.SetChildIndex(lblTitulo, 0);
            Controls.SetChildIndex(chBoxOlor, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblColor;
        private TextBox txtColor;
        private Label lblTitulo;
        private CheckBox chBoxOlor;
    }
}