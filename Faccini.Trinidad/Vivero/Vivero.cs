﻿namespace Parcial
{
    public class Vivero
    {

        public List<Planta> listaPlantas;

        /*
        private List<Arbol> listaArboles;
        private List<Cactus> listaCactus;
        private List<Flor> listaFlores;
        */

        private string nombreVivero;

        #region Propiedades
        public string NombreVivero { get { return nombreVivero; } }
        #endregion

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


        public static Vivero operator +(Vivero v, Planta p)
        {
            if (v != p)
                v.listaPlantas.Add(p);

            return v;
        }

        public static Vivero operator -(Vivero v, Planta p)
        {
            if (v == p)
                v.listaPlantas.Remove(p);

            return v;
        }

        public void MostrarInfoVivero()
        {
            foreach(Planta p in listaPlantas)
            {
                p.Mostrar(); // llama vien al mostrar de cada clase 
            }
        }

        public static int OrdenarPorPrecioAsc(Planta a, Planta b)
        {
            // ASCENDENTE
            if (a.precio < b.precio)
                return -1;
            else if (a.precio > b.precio)
                return 1;
            else
                return 0;     
        }

        public static int OrdenarPorPrecioDesc(Planta a, Planta b)
        {
            if (a.precio < b.precio)
                return 1;
            else if (a.precio > b.precio)
                return -1;
            else
                return 0;
        }


        public static int OrdenarPorAlturaMaxAsc(Planta a, Planta b)
        {
           // ASCENDENTE
            if (a.alturaMax < b.alturaMax)
                return -1;
            else if (a.alturaMax > b.alturaMax)
                return 1;
            else
                return 0; 
        }

        public static int OrdenarPorAlturaMaxDesc(Planta a, Planta b)
        {
            if (a.alturaMax < b.alturaMax)
                return 1;
            else if (a.alturaMax > b.alturaMax)
                return -1;
            else
                return 0;
        }


    }


    
}