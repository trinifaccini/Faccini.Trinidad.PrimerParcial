using Parcial;
using Utilidades;

namespace Formularios
{
    public partial class FormPlanta : Form
    {

        private Planta planta;

        public Planta Planta
        {
            get { return planta; }
            set { planta = value; }
        }

        public FormPlanta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Deshabilita todos los controles del formulario que no sean de tipo Label
        /// </summary>
        internal void DeshabilitarControles()
        {
            foreach (Control c in Controls)
            {
                if (c is not Label)
                {
                    c.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Habilita todos los controles del formulario que no sean de tipo Label
        /// </summary>
        internal void HabilitarControles()
        {
            foreach (Control c in Controls)
                c.Enabled = true;
        }

        /// <summary>
        /// Verifica todos los campos del formulario actual.
        /// Muestra mensaje del primer campo verificado como incorrecto. 
        /// </summary>
        /// <returns>true si todos los campos son correctos, false si al menos uno no lo es</returns>
        public virtual bool VerificarCampos()
        {
            if (txtNombre.Text == "" || Validador.ValidarEntero(txtNombre.Text) || Validador.ValidarFloat(txtNombre.Text))
            {
                MessageBox.Show($"Ingresar un nombre para la planta", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Validador.ValidarFloat(txtPrecio.Text))
            {
                MessageBox.Show($"Ingresar precio válido para la planta", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Validador.ValidarEntero(txtFrecuencia.Text))
            {
                MessageBox.Show($"Ingresar numero de frecuencia de riego válido para la planta", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Validador.ValidarFloat(txtAlturaTransplante.Text))
            {
                MessageBox.Show($"Ingresar altura transplante válida para la planta","Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbmBoxEstacion.SelectedIndex == -1)
            {
                MessageBox.Show($"Seleccionar la estacion de transplante","Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Validador.ValidarFloat(txtAlturaMax.Text))
            {
                MessageBox.Show($"Ingresar altura máxima válida para la planta", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
           
            return true;
        }

        /// <summary>
        /// Rellena todos los campos de la planta creada anteriormente, si la hubiera. 
        /// </summary>
        internal virtual void FormPlanta_Load(object sender, EventArgs e)
        {
            if (planta is not null)
            {
                txtNombre.Text = planta.Nombre;
                txtAlturaActual.Text = planta.AlturaActual.ToString();
                txtAlturaMax.Text = planta.AlturaMax.ToString();
                txtAlturaTransplante.Text = planta.AlturaTransplante.ToString();
                cbmBoxEstacion.SelectedIndex = (int)planta.EstacionTransplante;
                txtPrecio.Text = planta.Precio.ToString();
                checkedListBoxAmbiente.SetItemChecked(0, planta.AptaInterior);
                checkedListBoxAmbiente.SetItemChecked(1, planta.AptaExterior);
                txtFrecuencia.Text = planta.FrecuenciaRiego.ToString();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Verifica los campos llenados. En caso de ser todos correctos, crea una instancia de la nueva planta.
        /// </summary>
       
        internal virtual void btnAceptar_Click(object sender, EventArgs e) { }
    }
}
