namespace Formularios
{
    partial class FormLogsUsuarios
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
            listBox1 = new ListBox();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(610, 349);
            listBox1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(20, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(334, 21);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Nombre - Apellido - Fecha y hora de ingreso";
            // 
            // FormLogsUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 450);
            Controls.Add(lblTitulo);
            Controls.Add(listBox1);
            Name = "FormLogsUsuarios";
            Text = "Formulario de registro de usuarios";
            Load += FormLogsUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label lblTitulo;
    }
}