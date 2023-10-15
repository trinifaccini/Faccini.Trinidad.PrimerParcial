using Parcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public static class Serializador
    {

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

        public static void SerealizarPlantas(string path, List<Planta> plantas)
        {
            System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
            opciones.WriteIndented = true;
            try
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(path))
                {
                    var obj_son = System.Text.Json.JsonSerializer.Serialize(plantas, opciones);
                    Console.WriteLine(obj_son);
                    sw.Write(obj_son.ToString());
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static List<Planta> DeserealizarPlantas(string path)
        {
            List<Planta> plantas = new List<Planta>();

            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
                {
                    string json = sr.ReadToEnd();
                    Console.WriteLine(json);
                    plantas = (List<Planta>)System.Text.Json.JsonSerializer.Deserialize(json, typeof(List<Planta>));
                    Console.WriteLine(plantas[0].precio);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return plantas;

        }

    }
}
