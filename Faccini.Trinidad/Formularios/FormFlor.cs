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

        public FormFlor()
        {
            InitializeComponent();
        }

        public FormFlor(Flor f, bool editable) : this()
        {
            flor = f;
            base.Planta = flor;

            if(editable == false)
                DeshabilitarControles();

        }


        internal override void btnAgregar_Click(object sender, EventArgs e)
        {

            string nombre = base.txtNombre.Text;
            //float alturaActual = float.Parse(base.txtAlturaActual.Text);
            float alturaMax = float.Parse(base.txtAlturaMax.Text);
            float alturaTransplante = float.Parse(base.txtAlturaTransplante.Text);
            float precio = float.Parse(base.txtPrecio.Text);
            int frecuenciaRiego = int.Parse(base.txtFrecuencia.Text);
            EEstacion estacionTransplante = (EEstacion)base.cbmBoxEstacion.SelectedIndex;
            bool aptaInterior = base.checkedListBoxAmbiente.CheckedIndices.Contains(0);
            bool aptaExterior = base.checkedListBoxAmbiente.CheckedIndices.Contains(1);
            bool tieneOlor = this.chBoxOlor.Checked;
            string color = this.txtColor.Text;

            flor = new Flor(nombre, frecuenciaRiego, estacionTransplante, aptaInterior, aptaExterior,
                alturaMax, alturaTransplante, color, tieneOlor, precio);

            base.planta = flor;

            DialogResult = DialogResult.OK;
        }

        private void FormFlor_Load(object sender, EventArgs e)
        {

            if (flor is not null)
            {
                
                txtColor.Text = flor.Color;
                chBoxOlor.Checked = flor.TieneOlor;
               
            }
        }

        private void checkedListBoxAmbiente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
