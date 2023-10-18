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

    /// <summary>
    /// Formulario con campos comunes a llenar para las plantas de tipo Cactus
    /// </summary>
    public partial class FormCactus : FormPlanta
    {
        private Cactus cactus;
        public FormCactus()
        {
            InitializeComponent();
        }

        public FormCactus(Cactus c, bool editable) : this()
        {
            cactus = c;
            Planta = c;
            if (editable == false)
            {
                DeshabilitarControles();
            }
        }

        internal override void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                string nombre = txtNombre.Text;
                float alturaMax = float.Parse(txtAlturaMax.Text);
                float alturaTransplante = float.Parse(txtAlturaTransplante.Text);
                float precio = float.Parse(txtPrecio.Text);
                int frecuenciaRiego = int.Parse(txtFrecuencia.Text);
                EEstacion estacionTransplante = (EEstacion)cbmBoxEstacion.SelectedIndex;
                bool aptaInterior = checkedListBoxAmbiente.CheckedIndices.Contains(0);
                bool aptaExterior = checkedListBoxAmbiente.CheckedIndices.Contains(1);
                bool tieneEspinas = chEspinas.Checked;
                bool tieneFlor = chFlor.Checked;

                cactus = new Cactus(nombre, frecuenciaRiego, estacionTransplante, aptaInterior, aptaExterior,
                    alturaMax, alturaTransplante, tieneEspinas, tieneFlor, precio);

                Planta = cactus;

                DialogResult = DialogResult.OK;
            }
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
