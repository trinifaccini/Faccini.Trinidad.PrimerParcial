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
            btnAgregarCactus = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnDetalles = new Button();
            grpBoxTipoOrdenamiento = new GroupBox();
            btnAlturaMax = new RadioButton();
            btnPrecio = new RadioButton();
            btnDefault = new RadioButton();
            grpBoxOrden = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnAgregarFlor = new Button();
            btnAgregarArbol = new Button();
            btnOrden = new Button();
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
            lstPlantas.Size = new Size(558, 334);
            lstPlantas.TabIndex = 1;
            // 
            // btnAgregarCactus
            // 
            btnAgregarCactus.Location = new Point(581, 58);
            btnAgregarCactus.Name = "btnAgregarCactus";
            btnAgregarCactus.Size = new Size(78, 50);
            btnAgregarCactus.TabIndex = 2;
            btnAgregarCactus.Text = "AGREGAR CACTUS";
            btnAgregarCactus.UseVisualStyleBackColor = true;
            btnAgregarCactus.Click += btnAgregarCactus_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(581, 130);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(246, 50);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "ELIMINAR PLANTA SELECCIONADA";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(581, 205);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(246, 50);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "MODIFICAR PLANTA SELECCIONADA";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(581, 286);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(246, 50);
            btnDetalles.TabIndex = 5;
            btnDetalles.Text = "DETALLES DE PLANTA SELECCIONADA";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
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
            // btnAlturaMax
            // 
            btnAlturaMax.AutoSize = true;
            btnAlturaMax.Location = new Point(12, 72);
            btnAlturaMax.Name = "btnAlturaMax";
            btnAlturaMax.Size = new Size(103, 19);
            btnAlturaMax.TabIndex = 2;
            btnAlturaMax.Text = "Altura maxima";
            btnAlturaMax.UseVisualStyleBackColor = true;
            // 
            // btnPrecio
            // 
            btnPrecio.AutoSize = true;
            btnPrecio.Location = new Point(12, 47);
            btnPrecio.Name = "btnPrecio";
            btnPrecio.Size = new Size(58, 19);
            btnPrecio.TabIndex = 1;
            btnPrecio.Text = "Precio";
            btnPrecio.UseVisualStyleBackColor = true;
            // 
            // btnDefault
            // 
            btnDefault.AutoSize = true;
            btnDefault.Checked = true;
            btnDefault.Location = new Point(12, 22);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new Size(119, 19);
            btnDefault.TabIndex = 0;
            btnDefault.TabStop = true;
            btnDefault.Text = "Defecto (nombre)";
            btnDefault.UseVisualStyleBackColor = true;
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
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 19);
            radioButton2.TabIndex = 4;
            radioButton2.Text = "Descendente";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ascendente";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnAgregarFlor
            // 
            btnAgregarFlor.Location = new Point(665, 58);
            btnAgregarFlor.Name = "btnAgregarFlor";
            btnAgregarFlor.Size = new Size(78, 50);
            btnAgregarFlor.TabIndex = 9;
            btnAgregarFlor.Text = "AGREGAR FLOR";
            btnAgregarFlor.UseVisualStyleBackColor = true;
            btnAgregarFlor.Click += btnAgregarFlor_Click;
            // 
            // btnAgregarArbol
            // 
            btnAgregarArbol.Location = new Point(749, 58);
            btnAgregarArbol.Name = "btnAgregarArbol";
            btnAgregarArbol.Size = new Size(78, 50);
            btnAgregarArbol.TabIndex = 10;
            btnAgregarArbol.Text = "AGREGAR ARBOL";
            btnAgregarArbol.UseVisualStyleBackColor = true;
            btnAgregarArbol.Click += btnAgregarArbol_Click;
            // 
            // btnOrden
            // 
            btnOrden.DialogResult = DialogResult.OK;
            btnOrden.Location = new Point(399, 398);
            btnOrden.Name = "btnOrden";
            btnOrden.Size = new Size(104, 30);
            btnOrden.TabIndex = 11;
            btnOrden.Text = "Ordenar";
            btnOrden.UseVisualStyleBackColor = true;
            btnOrden.Click += btnOrden_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(943, 552);
            Controls.Add(btnOrden);
            Controls.Add(btnAgregarArbol);
            Controls.Add(btnAgregarFlor);
            Controls.Add(grpBoxOrden);
            Controls.Add(grpBoxTipoOrdenamiento);
            Controls.Add(btnDetalles);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregarCactus);
            Controls.Add(lstPlantas);
            Controls.Add(label1);
            Name = "FormInicio";
            Text = "Inicio";
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
        private Button btnAgregarCactus;
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
        private Button btnAgregarFlor;
        private Button btnAgregarArbol;
        private Button btnOrden;
    }
}