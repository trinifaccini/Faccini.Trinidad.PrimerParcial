using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Usuario
    {

        public string apellido { get; set; }
        public string nombre { get; set; }
        public int legajo { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public string perfil { get; set; }

        public Usuario()
        {

        }

        public Usuario(string correo, string clave)
        {
            this.correo = correo;
            this.clave = clave;
            this.apellido = "";
            this.nombre = "";
            this.perfil = "";
        }

        public Usuario(string apellido, string nombre, int legajo, string correo, string clave, string perfil):this(correo, clave)
        {
        
            this.legajo = legajo;
            this.correo = correo;
            this.clave = clave;
            this.perfil = perfil;
        }

        public override string ToString()
        {
            return $"{this.nombre} {this.apellido}";
        }

        public static bool operator == (Usuario u1, Usuario u2)
        {
            return (u1.correo == u2.correo && u1.clave == u2.clave);
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
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



     
    }
}
