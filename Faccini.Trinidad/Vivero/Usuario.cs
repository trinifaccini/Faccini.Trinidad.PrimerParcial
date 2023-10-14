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

        public static List<Usuario> DeserealizarUsuarios(string path)
        {
            List<Usuario> usuarios = new List<Usuario>(); 

            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
                {
                    string json = sr.ReadToEnd();
                    usuarios = (List<Usuario>)System.Text.Json.JsonSerializer.Deserialize(json, typeof(List<Usuario>));
                }
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return usuarios;

        }
    }
}

    /*
     * 
    [{"apellido":"Gorgen","nombre":"Corey","legajo":1,"correo":"cgorgen@vendedor.com","clave":"123abc45","perfil":"vendedor"},
{ "apellido":"Harroll","nombre":"Ingrid","legajo":2,"correo":"iharroll@vendedor.com","clave":"qweasdzx","perfil":"vendedor"},
{ "apellido":"Harris","nombre":"Steve","legajo":3,"correo":"sharris@maiden.com.uk","clave":"eddie666","perfil":"vendedor"},
{ "apellido":"Robinson","nombre":"Tilda","legajo":4,"correo":"trobinson@super.com","clave":"12345678","perfil":"supervisor"},
{ "apellido":"Jordan","nombre":"Michael","legajo":5,"correo":"admin@admin.com","clave":"12345678","perfil":"administrador"}]
    */