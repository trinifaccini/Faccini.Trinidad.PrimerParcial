namespace Formularios
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            label1 = new Label();
            lstPlantas = new ListBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnDetalles = new Button();
            grpBoxTipoOrdenamiento = new GroupBox();
            grpBoxOrden = new GroupBox();
            btnDefault = new RadioButton();
            btnPrecio = new RadioButton();
            btnAlturaMax = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            grpBoxTipoOrdenamiento.SuspendLayout();
            grpBoxOrden.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(93, 9);
            label1.Name = "label1";
            label1.Size = new Size(477, 23);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDOS AL SISTEMA DE VIVEROS DE: XXXXXXX";
            // 
            // lstPlantas
            // 
            lstPlantas.FormattingEnabled = true;
            lstPlantas.ItemHeight = 15;
            lstPlantas.Location = new Point(12, 58);
            lstPlantas.Name = "lstPlantas";
            lstPlantas.Size = new Size(362, 334);
            lstPlantas.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(395, 58);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(232, 50);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR NUEVA PLANTA";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(395, 130);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(232, 50);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "ELIMINAR PLANTA SELECCIONADA";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(395, 205);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(232, 50);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "MODIFICAR PLANTA SELECCIONADA";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(395, 286);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(232, 50);
            btnDetalles.TabIndex = 5;
            btnDetalles.Text = "DETALLES DE PLANTA SELECCIONADA";
            btnDetalles.UseVisualStyleBackColor = true;
            // 
            // grpBoxTipoOrdenamiento
            // 
            grpBoxTipoOrdenamiento.Controls.Add(btnAlturaMax);
            grpBoxTipoOrdenamiento.Controls.Add(btnPrecio);
            grpBoxTipoOrdenamiento.Controls.Add(btnDefault);
            grpBoxTipoOrdenamiento.Location = new Point(12, 398);
            grpBoxTipoOrdenamiento.Name = "grpBoxTipoOrdenamiento";
            grpBoxTipoOrdenamiento.Size = new Size(160, 96);
            grpBoxTipoOrdenamiento.TabIndex = 6;
            grpBoxTipoOrdenamiento.TabStop = false;
            grpBoxTipoOrdenamiento.Text = "Ordenar por:";
            // 
            // grpBoxOrden
            // 
            grpBoxOrden.Controls.Add(radioButton2);
            grpBoxOrden.Controls.Add(radioButton1);
            grpBoxOrden.Location = new Point(201, 398);
            grpBoxOrden.Name = "grpBoxOrden";
            grpBoxOrden.Size = new Size(173, 96);
            grpBoxOrden.TabIndex = 7;
            grpBoxOrden.TabStop = false;
            grpBoxOrden.Text = "Orden";
            // 
            // btnDefault
            // 
            btnDefault.AutoSize = true;
            btnDefault.Location = new Point(12, 22);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new Size(119, 19);
            btnDefault.TabIndex = 0;
            btnDefault.TabStop = true;
            btnDefault.Text = "Defecto (nombre)";
            btnDefault.UseVisualStyleBackColor = true;
            // 
            // btnPrecio
            // 
            btnPrecio.AutoSize = true;
            btnPrecio.Location = new Point(12, 47);
            btnPrecio.Name = "btnPrecio";
            btnPrecio.Size = new Size(58, 19);
            btnPrecio.TabIndex = 1;
            btnPrecio.TabStop = true;
            btnPrecio.Text = "Precio";
            btnPrecio.UseVisualStyleBackColor = true;
            // 
            // btnAlturaMax
            // 
            btnAlturaMax.AutoSize = true;
            btnAlturaMax.Location = new Point(12, 72);
            btnAlturaMax.Name = "btnAlturaMax";
            btnAlturaMax.Size = new Size(103, 19);
            btnAlturaMax.TabIndex = 2;
            btnAlturaMax.TabStop = true;
            btnAlturaMax.Text = "Altura maxima";
            btnAlturaMax.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ascendente";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Descendente";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(662, 552);
            Controls.Add(grpBoxOrden);
            Controls.Add(grpBoxTipoOrdenamiento);
            Controls.Add(btnDetalles);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lstPlantas);
            Controls.Add(label1);
            Name = "FormInicio";
            Text = "FormInicio";
            Load += FormInicio_Load;
            grpBoxTipoOrdenamiento.ResumeLayout(false);
            grpBoxTipoOrdenamiento.PerformLayout();
            grpBoxOrden.ResumeLayout(false);
            grpBoxOrden.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstPlantas;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnDetalles;
        private GroupBox grpBoxTipoOrdenamiento;
        private RadioButton btnDefault;
        private GroupBox grpBoxOrden;
        private RadioButton btnAlturaMax;
        private RadioButton btnPrecio;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}