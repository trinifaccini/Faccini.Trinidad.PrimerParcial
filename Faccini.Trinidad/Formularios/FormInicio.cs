using Parcial;
using Utilidades;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormInicio : Form
    {

        private Vivero vivero;
        private Usuario usuario;

        public FormInicio()
        {

            InitializeComponent();
            vivero = new Vivero("ARRAYANES");
        }

        public FormInicio(Usuario usuario) : this()
        {
            this.usuario = usuario;
            AbrirArchivoPlantas();
        }

        public void AbrirArchivoPlantas()
        {
            openFileDialog1.Title = "Elige el archivo de plantas a abrir";
            openFileDialog1.InitialDirectory = @"C:\Users\Usuario\source\repos\Faccini.Trinidad.PrimerParcial\Faccini.Trinidad\Archivos\";
            openFileDialog1.FileName = "PLANTAS_DATA.xml";
            openFileDialog1.Filter = "XML-File | *.xml";
            openFileDialog1.ShowDialog();


            if (File.Exists(openFileDialog1.FileName))
            {
                List<Planta>? aux = ManejadorArchivos.DeserealizarPlantas(openFileDialog1.FileName);
                if (aux is not null)
                    vivero.listaPlantas = aux;
            }
        }

        public bool GuardarArchivoPlantas()
        {
            saveFileDialog1.Title = "Elige donde guardar la lista de plantas";
            saveFileDialog1.InitialDirectory = @"C:\Users\Usuario\source\repos\Faccini.Trinidad.PrimerParcial\Faccini.Trinidad\Archivos\";
            saveFileDialog1.Filter = "XML-File | *.xml";
            saveFileDialog1.FileName = "PLANTAS_DATA.xml";

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        ManejadorArchivos.SerealizarPlantas(saveFileDialog1.FileName, vivero.listaPlantas);
                        return true;
                    }
                }

                return false;
            }

            catch (Exception e)
            {
                MessageBox.Show("Error al guardar");
                return false;
            }

        }



        private void FormInicio_Load(object sender, EventArgs e)
        {
            label1.Text = $"BIENVENIDO AL SISTEMA DEL VIVERO: {vivero.NombreVivero}";
            lblOperador.Text = $"Operador: {usuario}";

            lblFecha.Text = $"Fecha: {DateTime.Now.ToString().Substring(0, 10)}";

            if (usuario.Perfil != "vendedor")
            {
                btnAgregarArbol.Visible = true;
                btnAgregarCactus.Visible = true;
                btnAgregarFlor.Visible = true;
            }

            if (usuario.Perfil == "administrador")
            {
                btnEliminar.Visible = true;
                btnModificar.Visible = true;
            }

            ActualizarVisor();
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
                if (vivero.listaPlantas.Count == lstPlantas.Items.Count)
                    MessageBox.Show("No se pudo añadir la planta - Ya existente");

                else
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
                frm = new FormArbol((Arbol)vivero.listaPlantas[index], true);
            else if (vivero.listaPlantas[index] is Flor)
                frm = new FormFlor((Flor)vivero.listaPlantas[index], true);
            else
                frm = new FormCactus((Cactus)vivero.listaPlantas[index], true);

            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                vivero.listaPlantas[index] = frm.Planta;
                ActualizarVisor();
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            int index = lstPlantas.SelectedIndex;

            if (index == -1) return;

            FormPlanta frm;

            if (vivero.listaPlantas[index] is Arbol)
                frm = new FormArbol((Arbol)vivero.listaPlantas[index], false);
            else if (vivero.listaPlantas[index] is Flor)
                frm = new FormFlor((Flor)vivero.listaPlantas[index], false);
            else
                frm = new FormCactus((Cactus)vivero.listaPlantas[index], false);

            frm.ShowDialog();

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

        private void FormInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres salir?", "Apagando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

            else
            {
                if (GuardarArchivoPlantas() == true)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
