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
    public partial class FormCactus : FormPlanta
    {
        private Cactus cactus;
        public FormCactus()
        {
            InitializeComponent();
        }

        public FormCactus(Cactus c) : this()
        {
            cactus = c;
            base.Planta = c;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
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
            bool tieneEspinas = this.chEspinas.Checked;
            bool tieneFlor = this.chFlor.Checked;

            cactus = new Cactus(nombre, frecuenciaRiego, estacionTransplante, aptaInterior, aptaExterior,
                alturaMax, alturaTransplante, tieneEspinas, tieneFlor, precio);

            base.planta = cactus;

            DialogResult = DialogResult.OK;
        }

        private void FormCactus_Load(object sender, EventArgs e)
        {

            if (cactus is not null)
            {
                chEspinas.Checked = cactus.TieneEspinas;
                chFlor.Checked = cactus.TieneFlores;
               
            }
        }
    }
}
