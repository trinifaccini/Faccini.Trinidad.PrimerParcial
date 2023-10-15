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

        public FormFlor(Flor f) : this()
        {
            flor = f;
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
                txtNombre.Text = flor.Nombre;
                txtColor.Text = flor.Color;
                txtAlturaActual.Text = flor.AlturaActual.ToString();
                txtAlturaMax.Text = flor.AlturaMax.ToString();
                txtAlturaTransplante.Text = flor.AlturaTransplante.ToString();
                cbmBoxEstacion.SelectedIndex = (int)flor.EstacionTransplante;
                chBoxOlor.Checked = flor.TieneOlor;
                txtPrecio.Text = flor.Precio.ToString();
                checkedListBoxAmbiente.SetItemChecked(0, flor.AptaInterior);
                checkedListBoxAmbiente.SetItemChecked(1, flor.AptaExterior);
                txtFrecuencia.Text = flor.FrecuenciaRiego.ToString();
            }
        }

        private void checkedListBoxAmbiente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
