using Parcial;
using Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LoguearUsuario(List<Usuario> usuarios, Usuario? u)
        {
            if (u is not null)
            {
                string pathU = @"C:\Users\Usuario\source\repos\Faccini.Trinidad.PrimerParcial\Faccini.Trinidad\usuarios.log";
                string pathP = @"C:\Users\Usuario\source\repos\Faccini.Trinidad.PrimerParcial\Faccini.Trinidad\PLANTAS_DATA.xml";

                u.CrearLogUsuario(pathU);
                FormInicio inicio = new FormInicio(u, pathP);
                Hide();
                inicio.Show();
            }

            else
            {
                MessageBox.Show("Atencion", $"Correo o clave incorrectas\nIntenta nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
 

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string clave = txtClave.Text;

            string path = @"C:\Users\Usuario\source\repos\Faccini.Trinidad.PrimerParcial\Faccini.Trinidad\MOCK_DATA.json";

            List <Usuario>? usuarios = Serializador.DeserealizarUsuarios(path);

            if(usuarios is not null)
            {
                Usuario? u = Usuario.BuscarUsuario(usuarios, correo, clave);
                LoguearUsuario(usuarios, u);
            }

            else
                MessageBox.Show($"No se ha podido verificar la existencia de usuarios.\nIntenta nuevamente en unos momentos.");

        }
    }
}
