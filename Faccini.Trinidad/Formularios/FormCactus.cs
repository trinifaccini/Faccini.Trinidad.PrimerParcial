﻿using Parcial;
using System.Globalization;
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
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

                string nombre = ti.ToTitleCase(txtNombre.Text.Trim());
                float alturaMax = float.Parse(txtAlturaMax.Text.Trim());
                float alturaTransplante = float.Parse(txtAlturaTransplante.Text.Trim());
                float precio = float.Parse(txtPrecio.Text.Trim());
                int frecuenciaRiego = int.Parse(txtFrecuencia.Text.Trim());
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
