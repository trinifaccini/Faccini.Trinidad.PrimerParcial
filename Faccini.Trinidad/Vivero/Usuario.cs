using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    /// <summary>
    /// Representa un usuario con sus atributos principales
    /// </summary>
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

        /// <summary>
        /// Compara dos objetos de tipo Usuario segun sus atributos correo y clave
        /// </summary>
        /// <returns>true si son iguales, false si son diferentes</returns>
        public static bool operator == (Usuario u1, Usuario u2)
        {
            return (u1.Correo == u2.Correo && u1.Clave == u2.Clave);
        }

        /// <summary>
        /// Compara dos objetos de tipo Usuario segun sus atributos correo y clave
        /// </summary>
        /// <returns>true si son diferentes, false si son iguales</returns>
        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
        }

        #endregion

        #region Metodos

        // NO DOCUMENTAR
        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido}";
        }

        /// <summary>
        /// Busca si el correo y la clave recibidas por parametro coinciden con las de algun usuario en la lista recibida por parametro
        /// </summary>
        /// <param name="usuarios">Lista de usuarios a recorrer</param>
        /// <param name="correo">string con el correo a buscar</param>
        /// <param name="clave">string con la clave a buscar</param>
        /// <returns>null si no se encontró el usuario, el usuario hallado si se encontró</returns>
        public static Usuario? BuscarUsuario(List<Usuario> usuarios, string correo, string clave)
        {
            Usuario usuario = new Usuario(correo, clave); 

            foreach (Usuario u in usuarios)
            {
                if (u == usuario)
                    return u;
            }

            return null;
        }

        /// <summary>
        /// Crea un log en el archivo ubicado en la ruta recibida por parametro, escribiendo nombre apellido y horario de ingreso de este usuario
        /// </summary>
        /// <param name="path">Ruta del archivo donde se va a escribir</param>
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

        // NO DOCUMENTAR
        public override bool Equals(object obj)
        {
         
            if (obj is Usuario)
                return this == (Usuario)obj;

            return false;
        }
        #endregion
    }
}
