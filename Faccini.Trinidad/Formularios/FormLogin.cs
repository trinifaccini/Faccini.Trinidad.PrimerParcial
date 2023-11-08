﻿using Parcial;
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
    /// <summary>
    /// Formulario de inicio de sesion
    /// </summary>
    public partial class FormLogin : Form
    {
        private string pathLogsUsuarios;
        private string pathDataUsuarios;
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
        }

        public FormLogin()
        {
            InitializeComponent();
            string archivoLogs = @"\Archivos\usuarios.log";
            //string archivoData = @"\Archivos\MOCK_DATA.json";

            pathLogsUsuarios = ManejadorArchivos.ObtenerDirectorioAnterior(Environment.CurrentDirectory, archivoLogs);
            pathDataUsuarios = @"..\..\..\MOCK_DATA.json";
            //pathDataUsuarios = ManejadorArchivos.ObtenerDirectorioAnterior(Environment.CurrentDirectory, archivoData);
        }

        private void LoguearUsuario(List<Usuario> usuarios, Usuario? u)
        {
            if (u is not null)
            {

                u.CrearLogUsuario(pathLogsUsuarios);
                usuario = u;
                this.DialogResult = DialogResult.OK;
                this.Close();
                //FormCRUD inicio = new FormCRUD(u);
                //Hide();
                //inicio.Show();
            }

            else
            {
                MessageBox.Show($"Correo o clave incorrectas\nIntenta nuevamente", $"Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string clave = txtClave.Text;

            List<Usuario>? usuarios = ManejadorArchivos.DeserealizarUsuarios(pathDataUsuarios);

            if (usuarios is not null)
            {
                Usuario? u = Usuario.BuscarUsuario(usuarios, correo, clave);
                LoguearUsuario(usuarios, u);
            }

            else
                MessageBox.Show($"No se ha podido verificar la existencia de usuarios.\nIntenta nuevamente en unos momentos.");

        }
    }
}
