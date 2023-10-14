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
using System.Xml.Linq;

namespace Formularios
{
    public partial class FormInicio : Form
    {

        private Vivero vivero;


        public FormInicio()
        {
            InitializeComponent();
            vivero = new Vivero("ARRAYANES");
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void ActualizarVisor()
        {
            this.lstPlantas.Items.Clear();

            foreach (Planta p in vivero.listaPlantas)
            {
                this.lstPlantas.Items.Add(p.Mostrar());
            }
        }

        private void AgregarPlanta(FormPlanta form)
        {
            if (form.DialogResult == DialogResult.OK)
            {
                this.vivero = this.vivero += form.Planta;
                ActualizarVisor();
            }
        }

        private void btnAgregarCactus_Click(object sender, EventArgs e)
        {
            FormCactus formCactus = new FormCactus();
            formCactus.ShowDialog();
            AgregarPlanta(formCactus);
        }


        private void btnAgregarFlor_Click(object sender, EventArgs e)
        {
            FormFlor formFlor = new FormFlor();
            formFlor.ShowDialog();
            AgregarPlanta(formFlor);
        }

        private void btnAgregarArbol_Click(object sender, EventArgs e)
        {
            FormArbol formArbol = new FormArbol();
            formArbol.ShowDialog();
            AgregarPlanta(formArbol);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            string ordenamiento = grpBoxOrden.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text; // ASC o DESC
            string tipoOrdenamiento = grpBoxTipoOrdenamiento.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text; // tipo

            if(ordenamiento == "Ascendente" && tipoOrdenamiento == "Precio")
                vivero.listaPlantas.Sort(Vivero.OrdenarPorPrecioAsc);
            else if (ordenamiento == "Descendente" && tipoOrdenamiento == "Precio")
                    vivero.listaPlantas.Sort(Vivero.OrdenarPorPrecioDesc);
            else if (ordenamiento == "Ascendente" && tipoOrdenamiento == "Altura maxima")
                vivero.listaPlantas.Sort(Vivero.OrdenarPorAlturaMaxAsc);
            else if (ordenamiento == "Descendente" && tipoOrdenamiento == "Altura maxima")
                vivero.listaPlantas.Sort(Vivero.OrdenarPorAlturaMaxDesc);
            else if (ordenamiento == "Ascendente")
                vivero.listaPlantas = vivero.listaPlantas.OrderBy(p => p.nombre).ToList();
            else
                vivero.listaPlantas = vivero.listaPlantas.OrderByDescending(p => p.nombre).ToList();

            ActualizarVisor();
        }
    }
}
