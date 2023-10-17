using Parcial;
using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;

namespace Utilidades
{
    public static class Serializador
    {
        /// <summary>
        /// Deserealiza la lista de usuarios hallada en el archivo tipo json recibido por parametro
        /// </summary>
        /// <param name="path">string con la ruta del archivo</param>
        /// <returns>Lista de usuarios en el archivo (si se encuentran) - 
        /// null en caso contrario</returns>
        public static List<Usuario>? DeserealizarUsuarios(string path)
        {
            List<Usuario>? usuarios = new();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string json = sr.ReadToEnd();
                    usuarios = (List<Usuario>?)System.Text.Json.JsonSerializer.Deserialize(json, typeof(List<Usuario>),options);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return usuarios;

        }

        /// <summary>
        /// Seraliza la lista de plantas recibida por parametro en formato XML
        /// </summary>
        /// <param name="path">string con la ruta del archivo</param>
        /// <param name="plantas">Lista de plantas con las plantas a serealizar</param>
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

        /// <summary>
        /// Deserealiza la lista de plantas hallada en el archivo tipo xml recibido por parametro
        /// </summary>
        /// <returns>Lista de plantas en el archivo (si se encuentran) - 
        /// null en caso contrario</returns>
        public static List<Planta>? DeserealizarPlantas(string path)
        {
            List<Planta>? plantas = new();

            try
            {
                using (XmlTextReader reader = new XmlTextReader(path)) 
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Planta>));
                    plantas = (List<Planta>?)ser.Deserialize(reader);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return plantas;
              
        }

        /// <summary>
        /// Lee los logs con el registro de los usuarios hallados en el archivo de tipo txt recibido por parametro 
        /// </summary>
        /// <param name="path">string con la ruta del archivo</param>
        /// <returns>string[] con las lineas de texto halladas</returns>
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
