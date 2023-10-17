using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Usuario
    {

        #region Propiedades
        public string Apellido { get; set ; }
        public string Nombre { get;  set ; }
        public int Legajo { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Perfil { get; set; }

        #endregion

        #region Constructores
        public Usuario()
        {
            Apellido = "";
            Nombre = "";
            Legajo = -1;
            Correo = "";
            Clave = "";
            Perfil = "";
        }

        public Usuario(string correo, string clave):this()
        {
            Correo = correo;
            Clave = clave;
        }

        public Usuario(string apellido, string nombre, int legajo, string correo, string clave, string perfil):this(correo, clave)
        {
            Legajo = legajo;
            Correo = correo;
            Clave = clave;
            Perfil = perfil;
        }

        #endregion

        #region Sobreescritura de operadores
        public static bool operator == (Usuario u1, Usuario u2)
        {
            return (u1.Correo == u2.Correo && u1.Clave == u2.Clave);
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido}";
        }


        public static Usuario BuscarUsuario(List<Usuario> usuarios, string correo, string clave)
        {

            Usuario usuario = new Usuario(correo, clave); 

            foreach (Usuario u in usuarios)
            {
                if (u == usuario)
                    usuario = u;
            }

            return usuario;
        }

        public void CrearLogUsuario(string path)
        {
            string fechaHora = DateTime.Now.ToString();

            StringBuilder sb = new StringBuilder();
            sb.Append($"Usuario ingresado: {this.ToString()}");
            sb.Append($" - Fecha y hora de ingreso: {fechaHora}");

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(sb.ToString());
            }

        }

        public override bool Equals(object obj)
        {
         
            if (obj is Usuario)
                return this == (Usuario)obj;

            return false;
        }
        #endregion
    }
}
