namespace Formularios
{
    partial class FormArbol
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
            lblPais = new Label();
            cmbBoxPais = new ComboBox();
            chFruto = new CheckBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(128, 447);
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(262, 447);
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(147, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 15);
            lblTitulo.TabIndex = 20;
            lblTitulo.Text = "AGREGAR NUEVO ARBOL AL VIVERO";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(280, 309);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(81, 15);
            lblPais.TabIndex = 22;
            lblPais.Text = "Pais de origen";
            // 
            // cmbBoxPais
            // 
            cmbBoxPais.FormattingEnabled = true;
            cmbBoxPais.Items.AddRange(new object[] { "Argentina", "USA", "Paraguay", "Brasil" });
            cmbBoxPais.Location = new Point(280, 327);
            cmbBoxPais.Name = "cmbBoxPais";
            cmbBoxPais.Size = new Size(160, 23);
            cmbBoxPais.TabIndex = 23;
            // 
            // chFruto
            // 
            chFruto.AutoSize = true;
            chFruto.Location = new Point(282, 265);
            chFruto.Name = "chFruto";
            chFruto.Size = new Size(74, 19);
            chFruto.TabIndex = 24;
            chFruto.Text = "Da frutos";
            chFruto.UseVisualStyleBackColor = true;
            // 
            // FormArbol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 516);
            Controls.Add(chFruto);
            Controls.Add(cmbBoxPais);
            Controls.Add(lblPais);
            Controls.Add(lblTitulo);
            Name = "FormArbol";
            Text = "FormArbol";
            Load += FormArbol_Load;
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
            Controls.SetChildIndex(lblPais, 0);
            Controls.SetChildIndex(cmbBoxPais, 0);
            Controls.SetChildIndex(chFruto, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblPais;
        private ComboBox cmbBoxPais;
        private CheckBox chFruto;
    }
}