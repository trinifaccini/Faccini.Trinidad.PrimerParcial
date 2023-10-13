namespace Vivero
{
    internal class Vivero
    {

        private List<Planta> listaPlantas;

        /*
        private List<Arbol> listaArboles;
        private List<Cactus> listaCactus;
        private List<Flor> listaFlores;
        */

        private string nombreVivero;

        private Vivero()
        {   
            listaPlantas = new List<Planta>();
            nombreVivero = string.Empty;
        }

        public Vivero(string nombreVivero) : this()
        {
            this.nombreVivero = nombreVivero;
        }

        public static bool operator != (Vivero v, Planta p)
        {
            // si no lo contiene, devuelve true
            return !(v.listaPlantas.Contains(p));
        }
        public static bool operator == (Vivero a, Planta p)
        {
            return !(a != p);
        }

        public static bool operator +(Vivero v, Planta p)
        {
            if (v != p)
            {
                v.listaPlantas.Add(p);
                return true;
            }

            else return false;
        }

        public static bool operator -(Vivero v, Planta p)
        {
            if (v == p)
            {
                v.listaPlantas.Remove(p);
                return true;
            }

            else return false;
        }

        // METODO PARA ORDENAR POR ALTURA
        // METODO PARA ORDENAR POR PRECIO


    }
}