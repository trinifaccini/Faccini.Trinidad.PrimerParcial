namespace Formularios
{
    partial class FormPlanta
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
            lblNombre = new Label();
            Precio = new Label();
            lblFrecuencia = new Label();
            lblEstacion = new Label();
            lblAmbiente = new Label();
            lblAltura = new Label();
            lblAlturaMax = new Label();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtFrecuencia = new TextBox();
            cbmBoxEstacion = new ComboBox();
            checkedListBoxAmbiente = new CheckedListBox();
            txtAlturaActual = new TextBox();
            txtAlturaMax = new TextBox();
            txtAlturaTransplante = new TextBox();
            lblAlturaTransplante = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(16, 41);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Location = new Point(16, 118);
            Precio.Name = "Precio";
            Precio.Size = new Size(40, 15);
            Precio.TabIndex = 1;
            Precio.Text = "Precio";
            // 
            // lblFrecuencia
            // 
            lblFrecuencia.AutoSize = true;
            lblFrecuencia.Location = new Point(16, 183);
            lblFrecuencia.Name = "lblFrecuencia";
            lblFrecuencia.Size = new Size(94, 15);
            lblFrecuencia.TabIndex = 2;
            lblFrecuencia.Text = "Frecuencia riego";
            // 
            // lblEstacion
            // 
            lblEstacion.AutoSize = true;
            lblEstacion.Location = new Point(18, 309);
            lblEstacion.Name = "lblEstacion";
            lblEstacion.Size = new Size(113, 15);
            lblEstacion.TabIndex = 5;
            lblEstacion.Text = "Estacion transplante";
            // 
            // lblAmbiente
            // 
            lblAmbiente.AutoSize = true;
            lblAmbiente.Location = new Point(282, 41);
            lblAmbiente.Name = "lblAmbiente";
            lblAmbiente.Size = new Size(86, 15);
            lblAmbiente.TabIndex = 4;
            lblAmbiente.Text = "Ambiente apto";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(282, 118);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(74, 15);
            lblAltura.TabIndex = 3;
            lblAltura.Text = "Altura actual";
            // 
            // lblAlturaMax
            // 
            lblAlturaMax.AutoSize = true;
            lblAlturaMax.Location = new Point(282, 183);
            lblAlturaMax.Name = "lblAlturaMax";
            lblAlturaMax.Size = new Size(85, 15);
            lblAlturaMax.TabIndex = 6;
            lblAlturaMax.Text = "Altura máxima";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(16, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese un nombre para la planta";
            txtNombre.Size = new Size(186, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(16, 136);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Ingrese un numero con o sin .";
            txtPrecio.Size = new Size(186, 23);
            txtPrecio.TabIndex = 8;
            // 
            // txtFrecuencia
            // 
            txtFrecuencia.Location = new Point(18, 201);
            txtFrecuencia.Name = "txtFrecuencia";
            txtFrecuencia.PlaceholderText = "Ingrese un numero entero";
            txtFrecuencia.Size = new Size(184, 23);
            txtFrecuencia.TabIndex = 9;
            // 
            // cbmBoxEstacion
            // 
            cbmBoxEstacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmBoxEstacion.FormattingEnabled = true;
            cbmBoxEstacion.Items.AddRange(new object[] { "Verano", "Otonio", "Primavera", "Invierno" });
            cbmBoxEstacion.Location = new Point(18, 327);
            cbmBoxEstacion.Name = "cbmBoxEstacion";
            cbmBoxEstacion.Size = new Size(160, 23);
            cbmBoxEstacion.TabIndex = 10;
            // 
            // checkedListBoxAmbiente
            // 
            checkedListBoxAmbiente.FormattingEnabled = true;
            checkedListBoxAmbiente.Items.AddRange(new object[] { "Interior", "Exterior" });
            checkedListBoxAmbiente.Location = new Point(282, 59);
            checkedListBoxAmbiente.Name = "checkedListBoxAmbiente";
            checkedListBoxAmbiente.Size = new Size(186, 40);
            checkedListBoxAmbiente.TabIndex = 11;
            // 
            // txtAlturaActual
            // 
            txtAlturaActual.Enabled = false;
            txtAlturaActual.Location = new Point(282, 136);
            txtAlturaActual.Name = "txtAlturaActual";
            txtAlturaActual.Size = new Size(186, 23);
            txtAlturaActual.TabIndex = 12;
            txtAlturaActual.Text = "0";
            // 
            // txtAlturaMax
            // 
            txtAlturaMax.Location = new Point(282, 201);
            txtAlturaMax.Name = "txtAlturaMax";
            txtAlturaMax.PlaceholderText = "Ingrese un numero con o sin .";
            txtAlturaMax.Size = new Size(186, 23);
            txtAlturaMax.TabIndex = 13;
            // 
            // txtAlturaTransplante
            // 
            txtAlturaTransplante.Location = new Point(18, 265);
            txtAlturaTransplante.Name = "txtAlturaTransplante";
            txtAlturaTransplante.PlaceholderText = "Ingrese un numero con o sin .";
            txtAlturaTransplante.Size = new Size(184, 23);
            txtAlturaTransplante.TabIndex = 15;
            // 
            // lblAlturaTransplante
            // 
            lblAlturaTransplante.AutoSize = true;
            lblAlturaTransplante.Location = new Point(18, 247);
            lblAlturaTransplante.Name = "lblAlturaTransplante";
            lblAlturaTransplante.Size = new Size(127, 15);
            lblAlturaTransplante.TabIndex = 14;
            lblAlturaTransplante.Text = "Altura apta transplante";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(128, 415);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 42);
            btnAceptar.TabIndex = 16;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(262, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 42);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormPlanta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 498);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtAlturaTransplante);
            Controls.Add(lblAlturaTransplante);
            Controls.Add(txtAlturaMax);
            Controls.Add(txtAlturaActual);
            Controls.Add(checkedListBoxAmbiente);
            Controls.Add(cbmBoxEstacion);
            Controls.Add(txtFrecuencia);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(lblAlturaMax);
            Controls.Add(lblEstacion);
            Controls.Add(lblAmbiente);
            Controls.Add(lblAltura);
            Controls.Add(lblFrecuencia);
            Controls.Add(Precio);
            Controls.Add(lblNombre);
            Name = "FormPlanta";
            Text = "FormPlanta";
            Load += FormPlanta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label Precio;
        private Label lblFrecuencia;
        private Label lblEstacion;
        private Label lblAmbiente;
        private Label lblAltura;
        private Label lblAlturaMax;
        protected TextBox txtNombre;
        protected TextBox txtPrecio;
        protected TextBox txtFrecuencia;
        protected ComboBox cbmBoxEstacion;
        protected CheckedListBox checkedListBoxAmbiente;
        protected TextBox txtAlturaActual;
        protected TextBox txtAlturaMax;
        protected TextBox txtAlturaTransplante;
        protected Label lblAlturaTransplante;
        protected Button btnAceptar;
        protected Button btnCancelar;
    }
}