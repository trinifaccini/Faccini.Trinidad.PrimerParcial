using Parcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormFlor : FormPlanta
    {
        private Flor flor;
        public Flor Flor
        {
            get { return flor; }
        }

        public FormFlor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        internal override void btnAgregar_Click(object sender, EventArgs e)
        {

            string nombre = base.txtNombre.Text;
            //float alturaActual = float.Parse(base.txtAlturaActual.Text);
            float alturaMax = float.Parse(base.txtAlturaMax.Text);
            float alturaTransplante = float.Parse(base.txtAlturaTransplante.Text);
            float precio = float.Parse(base.txtPrecio.Text);
            int frecuenciaRiego = int.Parse(base.txtFrecuencia.Text);
            EEstacion estacionTransplante = (EEstacion)base.cbmBoxEstacion.SelectionStart;
            bool aptaInterior = base.checkedListBoxEstacion.CheckedIndices.Contains(0);
            bool aptaExterior = base.checkedListBoxEstacion.CheckedIndices.Contains(0);
            bool tieneOlor = this.btnOlor.Checked;
            string color = this.txtColor.Text;

            flor = new Flor(nombre, frecuenciaRiego, estacionTransplante, aptaInterior, aptaExterior, 
                alturaMax, alturaTransplante, color, tieneOlor, precio);

            base.planta = flor;

            this.DialogResult = DialogResult.OK;
        }
    }
}
