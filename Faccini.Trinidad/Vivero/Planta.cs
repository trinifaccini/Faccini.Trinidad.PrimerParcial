using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Parcial
{

    /// <summary>
    /// Representa una planta con sus atributos principales
    /// </summary>
    [XmlInclude(typeof(Cactus))]
    [XmlInclude(typeof(Arbol))]
    [XmlInclude(typeof(Flor))]
    [XmlRoot("Planta")]
    public abstract class Planta
    {
        #region Atributos
        internal string nombre;
        internal float precio;
        internal DateTime ultimoRiego;
        internal int frecuenciaRiego;
        internal EEstacion estacionTransplante;

        internal bool aptaInterior;
        internal bool aptaExterior;

        internal float alturaMax;
        internal float alturaActual; 
        internal float alturaTransplante;
        #endregion

        #region Propiedades
        // PREGUNTAR SI ESTA BIEN
        // devuelve true si nos encontramos en la estacion en la que se puede
        // y tiene la altura necesaria 
        internal bool Transpantable
        {
            get { return (ObtenerEstacion() == estacionTransplante && alturaActual > alturaTransplante); }
        }
        public string Nombre { get { return nombre; } set { nombre = value;  } }
        public float Precio { get { return precio; } set { precio = value; } }
        public string UltimoRiego { get { return ultimoRiego.ToString(); } set { ultimoRiego = ParsearFecha(value.ToString()); } }
        public int FrecuenciaRiego { get { return frecuenciaRiego; } set { } }
        public EEstacion EstacionTransplante { get { return estacionTransplante; } set { estacionTransplante = value; } }
        public bool AptaInterior { get { return aptaInterior; } set { aptaInterior = value; } }
        public bool AptaExterior { get { return aptaExterior; } set { aptaExterior = value; } }
        public float AlturaMax { get { return alturaMax; } set { alturaMax = value; } }
        public float AlturaActual { get { return alturaActual;  } set { alturaActual = value;  } }
        public float AlturaTransplante { get { return alturaTransplante; } set { alturaTransplante = value; } }

        #endregion

        #region Constructores
        public Planta() 
        {
            nombre = "";
        }

        // Recibe todos -> llama al que recibe alturaActual 
        public Planta(string nombre, string ultimoRiego, int frecuenciaRiego, EEstacion estacionTransplante, bool aptaInterior, bool aptaExterior, 
            float alturaMax, float alturaActual, float alturaTransplante,float precio): this(nombre, frecuenciaRiego, estacionTransplante,
                       aptaInterior, aptaExterior,alturaActual, alturaMax, alturaTransplante, precio)
        {
            this.ultimoRiego = ParsearFecha(ultimoRiego);
        }

        // No recibe ultimoRiego -> llama al que no recibe ni ultimoRiego ni alturaActual
        public Planta(string nombre, int frecuenciaRiego, EEstacion estacionTransplante, bool aptaInterior, bool aptaExterior,
                   float alturaMax, float alturaActual, float alturaTransplante,float precio) : this(nombre, frecuenciaRiego, estacionTransplante,
                       aptaInterior, aptaExterior, alturaMax, alturaTransplante,precio)
        {
            this.alturaActual = alturaActual;
        }

        // No recibe alturaActual ni ultimoRiego -> llama al que no recibe alturaActual
        public Planta(string nombre, int frecuenciaRiego, EEstacion estacionTransplante,
            bool aptaInterior, bool aptaExterior, float alturaMax, float alturaTransplante, float precio)
        {
            this.nombre = nombre;
            this.ultimoRiego = DateTime.Now;
            this.frecuenciaRiego = frecuenciaRiego;
            this.estacionTransplante = estacionTransplante;
            this.aptaInterior = aptaInterior;
            this.aptaExterior = aptaExterior;
            this.alturaMax = alturaMax;
            this.alturaActual = 0;
            this.alturaTransplante = alturaTransplante;
            this.precio = precio;
        }
        #endregion


        #region Sobreescritura operadores

        /// <summary>
        /// Compara dos objetos de tipo Planta segun su atributo nombre
        /// </summary>
        /// <returns>true si son iguales, false si son diferentes</returns>
        public static bool operator ==(Planta a, Planta b)
        {
            return a.nombre == b.nombre;
        }

        /// <summary>
        /// Compara dos objetos de tipo Planta segun su atributo nombre
        /// </summary>
        /// <returns>true si son diferentes, false si son iguales</returns>
        public static bool operator !=(Planta a, Planta b)
        {
            return !(a == b);
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Parsea un string con formato de fecha valido a DateTime
        /// </summary>
        /// <param name="fecha">string con fecha a parsear</param>
        /// <returns>Fecha recibida en tipo DateTime</returns>
        private static DateTime ParsearFecha(string fecha)
        {
            string[] dtSeparada = fecha.Split('/', ' ');
            Console.WriteLine(dtSeparada[0] + dtSeparada[1] + dtSeparada[2]);
            DateTime dt = new DateTime(int.Parse(dtSeparada[2]), int.Parse(dtSeparada[1]), int.Parse(dtSeparada[0]));
            return dt;
        }

        /// <summary>
        /// Calcula la estaciond del año correspondiente a la fecha recibida
        /// </summary>
        /// <param name="fecha">DateTime con fecha a calcular</param>
        /// <returns> Enumerado de tipo EEstacion con la estacion correspondiente</returns>
        private static EEstacion ObtenerEstacion(DateTime fecha)
        {

            EMes mes = (EMes)fecha.Month;
            int dia = fecha.Day;

            switch (mes)
            {
                case (EMes.Enero | EMes.Febrero):
                    return EEstacion.Verano;
                case (EMes.Abril | EMes.Mayo):
                    return EEstacion.Otonio;
                case (EMes.Julio | EMes.Agosto):
                    return EEstacion.Invierno;
                case (EMes.Octubre | EMes.Noviembre):
                    return EEstacion.Primavera;
            }

            if (mes == EMes.Marzo)
            {
                if (dia >= 21)
                    return EEstacion.Otonio;
                else
                    return EEstacion.Verano;
            }

            if (mes == EMes.Junio)
            {
                if (dia >= 21)
                    return EEstacion.Invierno;
                else
                    return EEstacion.Otonio;
            }

            if (mes == EMes.Septiembre)
            {
                if (dia >= 21)
                    return EEstacion.Primavera;
                else
                    return EEstacion.Invierno;
            }

            if (mes == EMes.Diciembre && dia >= 21)
                return EEstacion.Verano;

            return EEstacion.Primavera;

        }

        /// <summary>
        /// Calcula la estaciond del año correspondiente a la fecha recibida
        /// </summary>
        /// <param name="fecha">string con fecha a calcular</param>
        /// <returns> Enumerado de tipo EEstacion con la estacion correspondiente</returns>
        private static EEstacion ObtenerEstacion(string fecha)
        {
            DateTime fechaDt = ParsearFecha(fecha);
            return ObtenerEstacion(fechaDt);
        }

        /// <summary>
        /// Devuelve un enumerado EEstacion correspondiente a la estacion actual
        /// </summary>
        /// <returns>Fecha recibida en tipo DateTime</returns>
        private static EEstacion ObtenerEstacion()
        {
            return  ObtenerEstacion(DateTime.Now);
        }

        /// <summary>
        /// Aumenta, si es posible, el atributo alturaActual de la planta los centimetros correspondientes
        /// </summary>
        /// <returns>true si se pudo aumentar, false en caso contrario</returns>
        internal abstract bool CrecerPlanta();


        /// <summary>
        /// Riega, si es posible, la planta.
        /// </summary>
        /// <returns>string que informa si fue posible o no regarla y la altura actual de la planta</returns>
        public string Regar()
        {
            TimeSpan dif = DateTime.Now - this.ultimoRiego;
            int difDias = dif.Days;

            if (difDias >= frecuenciaRiego)
            {
                ultimoRiego = DateTime.Now;
                bool crecida = CrecerPlanta();

                if (crecida)
                    return $"Regada - Altura actual de {nombre}: {alturaActual}cm";
                else
                    return $"No se puede regar - {nombre} alcanzó su altura máxima de {alturaActual}cm";
            }

            else
                return $"Aun no se puede regar - Debes esperar {frecuenciaRiego - difDias} días"; ;
        }

        /// <summary>
        /// Devuelve un string con los datos a mostrar sobre la planta actual
        /// </summary>
        /// <returns>string con los datos</returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.ToString());
            return sb.ToString();
        }

        // NO DOCUMENTAR
        public override bool Equals(object? obj)
        {
            if (obj is Planta)
                return this == (Planta)obj;

            return false;
        }

        // NO DOCUMENTAR
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre {nombre}\t");
            sb.Append($"Altura actual: {alturaActual}\t");
            sb.Append($"Precio {precio}\t");
            return sb.ToString();
        }


        #endregion

    }
}
