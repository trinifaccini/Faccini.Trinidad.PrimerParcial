namespace Parcial
{
    /// <summary>
    /// Representa un vivero con sus atributos principales
    /// </summary>
    public class Vivero
    {

        #region Atributos

        public List<Planta> listaPlantas;
        private string nombreVivero;

        #endregion

        #region Propiedades
        public string NombreVivero { get { return nombreVivero; } }
        #endregion

        #region Constructores
        private Vivero()
        {   
            listaPlantas = new List<Planta>();
            nombreVivero = string.Empty;
        }

        public Vivero(string nombreVivero) : this()
        {
            this.nombreVivero = nombreVivero;
        }
        #endregion

        #region Sobreescritura de operadores

        /// <summary>
        /// Compara un objeto de tipo Vivero y uno de tipo Planta
        /// </summary>
        /// <returns>true si la planta se encuentra en la lista de plantas del vivero recibido por parametro, false en caso contrario</returns>
        public static bool operator ==(Vivero v, Planta p)
        {
            Console.WriteLine("== DE VIVERO");
            return v.listaPlantas.Contains(p);
            //foreach (Planta planta in v.listaPlantas)
            //{
            //    if (planta is Arbol && p is Arbol)
            //        return (Arbol)planta == (Arbol)p;

            //    else if (planta is Cactus && p is Cactus)
            //        return (Cactus)planta == (Cactus)p;

            //    else if (planta is Flor && p is Flor)
            //        return (Flor)planta == (Flor)p;
            //    else
            //        return (planta == p);
            //}

            //return false;
        }

        /// <summary>
        /// Compara un objeto de tipo Vivero y uno de tipo Planta
        /// </summary>
        /// <returns>false si la planta se encuentra en la lista de plantas del vivero recibido por parametro, true en caso contrario</returns>
        public static bool operator !=(Vivero v, Planta p)
        {
            return !(v == p);
        }

        /// <summary>
        /// Agrega la planta recibida por parametro a la lista de plantas del vivero recibido por parametro en caso de no encontrarse anteriormente en ella
        /// </summary>
        /// <returns>Vivero modificado</returns>
        public static Vivero operator +(Vivero v, Planta p)
        {
            if (v != p)
                v.listaPlantas.Add(p);
            else
                Console.WriteLine("Ya existe la planta");
            return v;
        }

        /// <summary>
        /// Sustrae la planta recibida por parametro a la lista de plantas del vivero recibido por parametro en caso de encontrarse en ella
        /// </summary>
        /// <returns>Vivero modificado</returns>
        public static Vivero operator -(Vivero v, Planta p)
        {
            if (v == p)
                v.listaPlantas.Remove(p);
            else
                Console.WriteLine("No existe la planta a remover");
            return v;
        }

        #endregion

        /// <summary>
        /// Muestra por consola la información de la lista de plantas que se encuentrar en el vivero
        /// </summary>
        public void MostrarInfoVivero()
        {
            string[] infoPlantas = { };
            foreach(Planta p in listaPlantas)
            {
                Console.WriteLine(p.Mostrar());
            }
        }

        /// <summary>
        /// Metodo de ordenamiento según precio de la planta, ascendente.
        /// </summary>
        public static int OrdenarPorPrecioAsc(Planta a, Planta b)
        {
            if (a.precio < b.precio)
                return -1;
            else if (a.precio > b.precio)
                return 1;
            else
                return 0;     
        }

        /// <summary>
        /// Metodo de ordenamiento según precio de la planta, descendente.
        /// </summary>
        public static int OrdenarPorPrecioDesc(Planta a, Planta b)
        {
            if (a.precio < b.precio)
                return 1;
            else if (a.precio > b.precio)
                return -1;
            else
                return 0;
        }

        /// <summary>
        /// Metodo de ordenamiento según altura máxima de la planta, ascendente.
        /// </summary>
        public static int OrdenarPorAlturaMaxAsc(Planta a, Planta b)
        {
            if (a.alturaMax < b.alturaMax)
                return -1;
            else if (a.alturaMax > b.alturaMax)
                return 1;
            else
                return 0; 
        }

        /// <summary>
        /// Metodo de ordenamiento según altura máxima de la planta, descendente.
        /// </summary>
        public static int OrdenarPorAlturaMaxDesc(Planta a, Planta b)
        {
            if (a.alturaMax < b.alturaMax)
                return 1;
            else if (a.alturaMax > b.alturaMax)
                return -1;
            else
                return 0;
        }

        // NO DOCUMENTAR
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }
    }


    
}