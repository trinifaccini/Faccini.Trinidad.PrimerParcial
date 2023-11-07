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
using Utilidades;

namespace Formularios
{
    /// <summary>
    /// Formulario con campos comunes a llenar para las plantas de tipo Arbol
    /// </summary>
    public partial class FormArbol : FormPlanta
    {
        Arbol arbol;
        public FormArbol()
        {
            InitializeComponent();
        }

        public FormArbol(Arbol a, bool editable) : this()
        {
            arbol = a;
            Planta = arbol;

            if (editable == false)
                DeshabilitarControles();
        }

        private void FormArbol_Load(object sender, EventArgs e)
        {
            if (arbol is not null)
            {
                chFruto.Checked = arbol.TieneFrutos;
                cmbBoxPais.SelectedIndex = (int)arbol.PaisOrigen;
            }
        }

        internal override bool VerificarCampos()
        {
            bool verificadoGeneral = base.VerificarCampos();

            if (verificadoGeneral == false)
                return false;

            if (cmbBoxPais.SelectedIndex == -1)
            {
                MessageBox.Show($"Seleccionar la estacion de transplante", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
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
                bool tieneFrutos = chFruto.Checked;
                EPais pais = (EPais)cmbBoxPais.SelectedIndex;

                arbol = new Arbol(nombre, frecuenciaRiego, estacionTransplante, aptaInterior, aptaExterior,
                    alturaMax, alturaTransplante, tieneFrutos, pais, precio);

                Planta = arbol;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
