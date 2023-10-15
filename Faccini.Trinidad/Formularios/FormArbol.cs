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
            base.Planta = a;
            if (editable)
            {
                HabilitarControles();
            }
        }

        private void FormArbol_Load(object sender, EventArgs e)
        {
            if (arbol is not null)
            {
                chFruto.Checked = arbol.TieneFrutos;
                cmbBoxPais.SelectedIndex = (int)arbol.PaisOrigen;
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
