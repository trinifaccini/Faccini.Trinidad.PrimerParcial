using Parcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Parcial
{
    public static class Serializador
    {
        public static List<Usuario> DeserealizarUsuarios(string path)
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                using (StreamReader sr = new StreamReader(path))
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
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(path, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Planta>));
                    ser.Serialize(writer, plantas);
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
                using (XmlTextReader reader = new XmlTextReader(path)) 
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Planta>));
                    plantas = (List<Planta>)ser.Deserialize(reader);
                    Console.WriteLine(plantas[0].AlturaActual);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return plantas;
              
        }

        public static string[] LeerArchivoLogs(string path)
        {

            string[] lineas = {};

            try
            {
                lineas = File.ReadAllLines(path);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lineas;
        }

    }
}
