using Parcial;
using Utilidades;

namespace Formularios
{
    /// <summary>
     /// Formulario con campos comunes a llenar para las plantas de tipo Flor
     /// </summary>
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
            Planta = flor;

            if (editable == false)
                DeshabilitarControles();
        }


        internal override bool VerificarCampos()
        {
            bool verificadoGeneral = base.VerificarCampos();

            if (verificadoGeneral == false)
                return false;

            if (txtColor.Text == "" || Validador.ValidarEntero(txtColor.Text) || Validador.ValidarFloat(txtColor.Text))
            {
                MessageBox.Show($"Ingresar un color para la planta", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                string nombre = txtNombre.Text.Trim();
                float alturaMax = float.Parse(txtAlturaMax.Text.Trim());
                float alturaTransplante = float.Parse(txtAlturaTransplante.Text.Trim());
                float precio = float.Parse(txtPrecio.Text.Trim());
                int frecuenciaRiego = int.Parse(txtFrecuencia.Text.Trim());
                EEstacion estacionTransplante = (EEstacion)cbmBoxEstacion.SelectedIndex;
                bool aptaInterior = checkedListBoxAmbiente.CheckedIndices.Contains(0);
                bool aptaExterior = checkedListBoxAmbiente.CheckedIndices.Contains(1);
                bool tieneOlor = chBoxOlor.Checked;
                string color = txtColor.Text.Trim();

                flor = new Flor(nombre, frecuenciaRiego, estacionTransplante, aptaInterior, aptaExterior,
                    alturaMax, alturaTransplante, color, tieneOlor, precio);

                Planta = flor;

                DialogResult = DialogResult.OK;
            }
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
