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
    public partial class FormLogsUsuarios : Form
    {
        public FormLogsUsuarios()
        {
            InitializeComponent();
        }

        private void FormLogsUsuarios_Load(object sender, EventArgs e)
        {
            string archivo = @"\Archivos\usuarios.log";
            string path = ManejadorArchivos.ObtenerDirectorioAnterior(Environment.CurrentDirectory, archivo);

            string[] lineas = ManejadorArchivos.LeerArchivoLogs(path);

            listBox1.Items.Clear();

            foreach (string s in lineas)
            {
                listBox1.Items.Add(s);
            }
        }
    }
}
