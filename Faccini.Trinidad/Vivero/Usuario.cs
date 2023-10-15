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

        public Usuario(string apellido, string nombre, int legajo, string correo, string clave, string perfil)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
            this.correo = correo;
            this.clave = clave;
            this.perfil = perfil;
        }

        public static Usuario BuscarUsuario(List<Usuario> usuarios, string correo, string clave)
        {
            Usuario usuario = new Usuario(); 

            foreach (Usuario u in usuarios)
            {
                if (u.correo == correo && u.clave == clave)
                    usuario = u;
            }

            return usuario;
        }

     
    }
}
