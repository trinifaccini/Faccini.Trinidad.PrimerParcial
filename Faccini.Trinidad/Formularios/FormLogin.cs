﻿using Parcial;
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
 

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string clave = txtClave.Text;

            string path = @"C:\Users\Usuario\source\repos\Faccini.Trinidad.PrimerParcial\Faccini.Trinidad\MOCK_DATA.json";

            List <Usuario> usuarios = Usuario.DeserealizarUsuarios(path);

            bool encontrado = usuarios.Any(u => u.correo == correo && u.clave == clave);

            if (encontrado)
            {
                FormInicio inicio = new FormInicio();
                this.Hide();
                inicio.Show();
            }

            else
            {
                MessageBox.Show($"Correo o clave incorrectas\nIntenta nuevamente");
            }

          
        }
    }
}
