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
            btnFrutos = new RadioButton();
            lblPais = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
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
            // btnFrutos
            // 
            btnFrutos.AutoSize = true;
            btnFrutos.Location = new Point(280, 265);
            btnFrutos.Name = "btnFrutos";
            btnFrutos.Size = new Size(87, 19);
            btnFrutos.TabIndex = 21;
            btnFrutos.Text = "Tiene frutos";
            btnFrutos.UseVisualStyleBackColor = true;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Argentina", "USA", "Paraguay", "Brasil" });
            comboBox1.Location = new Point(280, 327);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 23);
            comboBox1.TabIndex = 23;
            // 
            // FormArbol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 450);
            Controls.Add(comboBox1);
            Controls.Add(lblPais);
            Controls.Add(btnFrutos);
            Controls.Add(lblTitulo);
            Name = "FormArbol";
            Text = "FormArbol";
            Controls.SetChildIndex(lblTitulo, 0);
            Controls.SetChildIndex(btnFrutos, 0);
            Controls.SetChildIndex(lblPais, 0);
            Controls.SetChildIndex(comboBox1, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private RadioButton btnFrutos;
        private Label lblPais;
        private ComboBox comboBox1;
    }
}