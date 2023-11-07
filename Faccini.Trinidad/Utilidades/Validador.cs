using Parcial;

namespace Utilidades
{
    /// <summary>
    /// Clase estatica con metodos que se utilizaran para validar tipos de datos
    /// </summary>
    public static class Validador
    {
        /// <summary>
        /// Verifica si el string recibido por parametro contiene solo caracteres alfabéticos
        /// </summary>
        /// <param name="flotante">string a validar</param>
        /// <returns>true si se puede parsear, false en caso contrario</returns>
        public static bool ValidarAlfa(string alfa)
        {
            return alfa.All(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == ' ');
        }

        /// <summary>
        /// Verifica si el string recibido por parametro puede ser parseado a variable de tipo entero positivo
        /// </summary>
        /// <param name="flotante">string a validar</param>
        /// <returns>true si se puede parsear, false en caso contrario</returns>
        public static bool ValidarEntero(string entero)
        {
            int numero;
            if (entero != "" && int.TryParse(entero, out numero))
            {
                if(numero > 0)
                    return true;

            }
            return false;
        }

        /// <summary>
        /// Verifica si el string recibido por parametro puede ser parseado a variable de tipo float positivo
        /// </summary>
        /// <param name="flotante">string a validar</param>
        /// <returns>true si se puede parsear, false en caso contrario</returns>
        public static bool ValidarFloat(string flotante)
        {
            float numero;
            if (flotante != "" && float.TryParse(flotante, out numero))
            {
                if (numero > 0)
                    return true;
            }

            return false;
        }
    }
}