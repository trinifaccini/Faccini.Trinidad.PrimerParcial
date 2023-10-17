namespace Utilidades
{
    public static class Validador
    {
        public static bool VerificarEntero(string entero)
        {
            int numero;
            if (entero != "" && int.TryParse(entero, out numero))
                return true;

            return false;
        }

        public static bool VerificarFloat(string flotante)
        {
            float numero;
            if (flotante != "" && float.TryParse(flotante, out numero))
                return true;

            return false;
        }
    }
}