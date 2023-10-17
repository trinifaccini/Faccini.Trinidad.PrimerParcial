using Parcial;
using Utilidades;
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
    public partial class FormPlanta : Form
    {

        private Planta? planta;

        public Planta? Planta
        {
            get { return planta; }
            set { planta = value; }
        }

        public FormPlanta()
        {
            InitializeComponent();
        }

        /*
        public FormPlanta()
        {
            InitializeComponent();
            DeshabilitarControles();
        }

        public FormPlanta(bool editable):this()
        {
            if (editable)
                HabilitarControles();
        }
        */

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

        internal void HabilitarControles()
        {
            foreach (Control c in Controls)
                c.Enabled = true;
        }


        public virtual bool VerificarCampos()
        {
            if (txtNombre.Text == "" || Validador.VerificarEntero(txtNombre.Text) || Validador.VerificarFloat(txtNombre.Text))
            {
                MessageBox.Show("Ingresar un nombre para la planta");
                return false;
            }
            if (!Validador.VerificarFloat(txtAlturaMax.Text))
            {
                MessageBox.Show("Ingresar altura máxima válida para la planta");
                return false;
            }
            if (!Validador.VerificarFloat(txtAlturaTransplante.Text))
            {
                MessageBox.Show("Ingresar altura transplante válida para la planta");
                return false;
            }
            if (!Validador.VerificarFloat(txtPrecio.Text))
            {
                MessageBox.Show("Ingresar precio válido para la planta");
                return false;
            }
            if (!Validador.VerificarEntero(txtFrecuencia.Text))
            {
                MessageBox.Show("Ingresar numero de frecuencia de riego válido para la planta");
                return false;
            }

            return true;
        }


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

        internal virtual void btnAceptar_Click(object sender, EventArgs e) { }
    }
}
