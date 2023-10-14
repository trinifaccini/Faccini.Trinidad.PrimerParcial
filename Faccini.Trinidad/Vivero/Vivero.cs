namespace Parcial
{
    public class Vivero
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

        public static bool operator ==(Vivero v, Planta p)
        {

            Console.WriteLine("ENTRA A == DE VIVERO");
            foreach (Planta planta in v.listaPlantas)
            {
                if (planta is Arbol && p is Arbol)
                    return (Arbol)planta == (Arbol)p;

                else if (planta is Cactus && p is Cactus)
                    return (Cactus)planta == (Cactus)p;

                else if (planta is Flor && p is Flor)
                    return (Flor)planta == (Flor)p;
                else
                    return (planta == p);
            }

            return false;
        }

        public static bool operator !=(Vivero v, Planta p)
        {
            // si no lo contiene, devuelve true

            return !(v == p);
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