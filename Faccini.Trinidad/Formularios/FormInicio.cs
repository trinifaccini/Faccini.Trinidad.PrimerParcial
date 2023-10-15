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
        private Usuario usuario;

        public FormInicio(Usuario usuario)
        {
            InitializeComponent();
            vivero = new Vivero("ARRAYANES");
            this.usuario = usuario;
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            label1.Text = $"BIENVENIDO AL SISTEMA DEL VIVERO: {vivero.NombreVivero}";
            lblOperador.Text = $"Operador: {usuario.ToString()}";

            lblFecha.Text = $"Fecha: {DateTime.Now.ToString().Substring(0, 10)}";

            if (usuario.perfil != "vendedor")
            {
                btnAgregarArbol.Visible = true;
                btnAgregarCactus.Visible = true;
                btnAgregarFlor.Visible = true;
            }

            if (usuario.perfil == "administrador")
            {
                btnEliminar.Visible = true;
                btnModificar.Visible = true;
            }
        }

        private void ActualizarVisor()
        {
            lstPlantas.Items.Clear();

            foreach (Planta p in vivero.listaPlantas)
            {
                lstPlantas.Items.Add(p.Mostrar());
            }
        }

        private void AgregarPlanta(FormPlanta frm)
        {
            if (frm.DialogResult == DialogResult.OK)
            {
                vivero += frm.Planta;
                ActualizarVisor();
            }
        }

        private void btnAgregarCactus_Click(object sender, EventArgs e)
        {
            FormCactus frmCactus = new FormCactus();
            frmCactus.ShowDialog();
            AgregarPlanta(frmCactus);
        }


        private void btnAgregarFlor_Click(object sender, EventArgs e)
        {
            FormFlor frmFlor = new FormFlor();
            frmFlor.ShowDialog();
            AgregarPlanta(frmFlor);
        }

        private void btnAgregarArbol_Click(object sender, EventArgs e)
        {
            FormArbol frmArbol = new FormArbol();
            frmArbol.ShowDialog();
            AgregarPlanta(frmArbol);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = lstPlantas.SelectedIndex;

            if (index == -1) return;

            vivero -= vivero.listaPlantas[index];
            ActualizarVisor();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = lstPlantas.SelectedIndex;

            if (index == -1) return;

            FormPlanta frm;

            if (vivero.listaPlantas[index] is Arbol)
                frm = new FormArbol();
            else if (vivero.listaPlantas[index] is Flor)
                frm = new FormFlor((Flor)vivero.listaPlantas[index]);
            else
                frm = new FormCactus();

            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                vivero.listaPlantas[index] = frm.Planta;
                ActualizarVisor();
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            string ordenamiento = grpBoxOrden.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text; // ASC o DESC
            string tipoOrdenamiento = grpBoxTipoOrdenamiento.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text; // tipo

            if (ordenamiento == "Ascendente" && tipoOrdenamiento == "Precio")
                vivero.listaPlantas.Sort(Vivero.OrdenarPorPrecioAsc);
            else if (ordenamiento == "Descendente" && tipoOrdenamiento == "Precio")
                vivero.listaPlantas.Sort(Vivero.OrdenarPorPrecioDesc);
            else if (ordenamiento == "Ascendente" && tipoOrdenamiento == "Altura maxima")
                vivero.listaPlantas.Sort(Vivero.OrdenarPorAlturaMaxAsc);
            else if (ordenamiento == "Descendente" && tipoOrdenamiento == "Altura maxima")
                vivero.listaPlantas.Sort(Vivero.OrdenarPorAlturaMaxDesc);
            else if (ordenamiento == "Ascendente")
                vivero.listaPlantas = vivero.listaPlantas.OrderBy(p => p.Nombre).ToList();
            else
                vivero.listaPlantas = vivero.listaPlantas.OrderByDescending(p => p.Nombre).ToList();

            ActualizarVisor();
        }

        private void btnRegar_Click(object sender, EventArgs e)
        {
            int index = lstPlantas.SelectedIndex;

            if (index == -1) return;

            Planta planta = vivero.listaPlantas[index];

            MessageBox.Show(planta.Regar());
        }
    }
}
