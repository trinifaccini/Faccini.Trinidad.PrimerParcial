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
            chFlor = new CheckBox();
            chEspinas = new CheckBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Click += btnAgregar_Click_1;
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
            // chFlor
            // 
            chFlor.AutoSize = true;
            chFlor.Location = new Point(282, 327);
            chFlor.Name = "chFlor";
            chFlor.Size = new Size(61, 19);
            chFlor.TabIndex = 23;
            chFlor.Text = "Da flor";
            chFlor.UseVisualStyleBackColor = true;
            // 
            // chEspinas
            // 
            chEspinas.AutoSize = true;
            chEspinas.Location = new Point(282, 259);
            chEspinas.Name = "chEspinas";
            chEspinas.Size = new Size(96, 19);
            chEspinas.TabIndex = 24;
            chEspinas.Text = "Tiene espinas";
            chEspinas.UseVisualStyleBackColor = true;
            // 
            // FormCactus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 450);
            Controls.Add(chEspinas);
            Controls.Add(chFlor);
            Controls.Add(lblTitulo);
            Name = "FormCactus";
            Text = "FormCactus";
            Load += FormCactus_Load;
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtPrecio, 0);
            Controls.SetChildIndex(txtFrecuencia, 0);
            Controls.SetChildIndex(cbmBoxEstacion, 0);
            Controls.SetChildIndex(checkedListBoxAmbiente, 0);
            Controls.SetChildIndex(txtAlturaActual, 0);
            Controls.SetChildIndex(txtAlturaMax, 0);
            Controls.SetChildIndex(lblAlturaTransplante, 0);
            Controls.SetChildIndex(txtAlturaTransplante, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(lblTitulo, 0);
            Controls.SetChildIndex(chFlor, 0);
            Controls.SetChildIndex(chEspinas, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private CheckBox chFlor;
        private CheckBox chEspinas;
    }
}