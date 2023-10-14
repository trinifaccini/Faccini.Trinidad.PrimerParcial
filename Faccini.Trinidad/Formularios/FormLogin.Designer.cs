namespace Formularios
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            lblUsuario = new Label();
            lblClave = new Label();
            txtCorreo = new TextBox();
            txtClave = new TextBox();
            lblTitulo = new Label();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = SystemColors.Window;
            lblUsuario.Location = new Point(12, 89);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(43, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Correo";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(12, 169);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(36, 15);
            lblClave.TabIndex = 1;
            lblClave.Text = "Clave";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(12, 107);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(270, 23);
            txtCorreo.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(12, 204);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(251, 23);
            txtClave.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.Control;
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(63, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(270, 20);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "BIENVENIDO AL SISTEMA DE VIVEROS";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.ButtonShadow;
            btnIngresar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ButtonFace;
            btnIngresar.Location = new Point(103, 267);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(102, 47);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(381, 347);
            Controls.Add(btnIngresar);
            Controls.Add(lblTitulo);
            Controls.Add(txtClave);
            Controls.Add(txtCorreo);
            Controls.Add(lblClave);
            Controls.Add(lblUsuario);
            Name = "FormLogin";
            Text = "Inicio sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblClave;
        private TextBox txtCorreo;
        private TextBox txtClave;
        private Label lblTitulo;
        private Button btnIngresar;
    }
}