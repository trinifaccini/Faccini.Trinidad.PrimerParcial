using Parcial;

namespace Utilidades
{
    public static class Validador
    {
        /// <summary>
        /// Verifica si el string recibido por parametro puede ser parseado a variable de tipo entero
        /// </summary>
        /// <param name="flotante">string a validar</param>
        /// <returns>true si se puede parsear, false en caso contrario</returns>
        public static bool ValidarEntero(string entero)
        {
            int numero;
            if (entero != "" && int.TryParse(entero, out numero))
                return true;

            return false;
        }

        /// <summary>
        /// Verifica si el string recibido por parametro puede ser parseado a variable de tipo float
        /// </summary>
        /// <param name="flotante">string a validar</param>
        /// <returns>true si se puede parsear, false en caso contrario</returns>
        public static bool ValidarFloat(string flotante)
        {
            float numero;
            if (flotante != "" && float.TryParse(flotante, out numero))
                return true;

            return false;
        }
    }
}