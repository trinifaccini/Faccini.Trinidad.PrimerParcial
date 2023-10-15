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
    public partial class FormPlanta : Form
    {

        protected Planta planta;

        public Planta Planta
        {
            get { return planta; }
            set { planta = value; }
        }

        public FormPlanta()
        {
            InitializeComponent();
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

        private void FormPlanta_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        internal virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            float alturaActual = float.Parse(this.txtAlturaActual.Text);
            float alturaMax = float.Parse(this.txtAlturaMax.Text);
            float alturaTransplante = float.Parse(this.txtAlturaTransplante.Text);
            float precio = float.Parse(this.txtPrecio.Text);
            int frecuenciaRiego = int.Parse(this.txtFrecuencia.Text);
            EEstacion estacionTransplante = (EEstacion)this.cbmBoxEstacion.SelectionStart;
            bool aptaInterior = this.checkedListBoxAmbiente.CheckedIndices.Contains(0);
            bool aptaExterior = this.checkedListBoxAmbiente.CheckedIndices.Contains(0);
        }
    }
}
