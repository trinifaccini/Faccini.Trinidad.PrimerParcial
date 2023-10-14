using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public abstract class Planta
    {
        #region Atributos
        public string nombre;
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

        #region Constructores
        // Recibe todos -> llama al que recibe alturaActual 
        public Planta(string nombre, DateTime ultimoRiego, int frecuenciaRiego, EEstacion estacionTransplante, bool aptaInterior, bool aptaExterior, 
            float alturaMax, float alturaActual, float alturaTransplante,float precio): this(nombre, frecuenciaRiego, estacionTransplante,
                       aptaInterior, aptaExterior,alturaActual, alturaMax, alturaTransplante, precio)
        {
            this.ultimoRiego = ultimoRiego;
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

        #region Propiedades
        // PREGUNTAR SI ESTA BIEN
        // devuelve true si nos encontramos en la estacion en la que se puede
        // y tiene la altura necesaria 
        internal bool Transpantable {
            get { return (this.ObtenerEstacion() == estacionTransplante && alturaActual > alturaTransplante); }
        }

        #endregion

        #region Metodos
        private EEstacion ObtenerEstacion()
        {

            EMes mes = (EMes)DateTime.Now.Month;
            int dia = DateTime.Now.Day;

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

        // este metodo lo DEBE implementar cada clase, segun que tipo sea hace crecer ciertos cm a la planta
        internal abstract void CrecerPlanta();

        // si pasaron los dias necesarios, se hace crecer a la planta y devuelve true
        private bool Regar()
        {
            TimeSpan dif = DateTime.Now - this.ultimoRiego;
            int difDias = dif.Days;

            if (difDias >= frecuenciaRiego)
            {
                this.ultimoRiego = DateTime.Now;
                CrecerPlanta();
                return true;
            }

            else
                return false;
        }


        public virtual string Mostrar()
        {
            // MUESTRO SOLO INFO QUE QUIERO VER EN LA LISTA DEL FORM
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre {nombre} - ");
            sb.AppendLine($"Altura actual: {alturaActual} - ");
            sb.AppendLine($"Precio {precio}");

            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            Console.WriteLine("EQUALS DE PLANTA");
            
            Planta planta = (Planta)obj;
            return (planta is not null && this == planta);
        }

        #endregion

        #region Sobreescritura operadores
        public static bool operator ==(Planta a, Planta b)
        {
            Console.WriteLine("== DE PLANTA");

            return a.nombre == b.nombre;
        }

        public static bool operator !=(Planta a, Planta b)
        {
            return !(a == b);
        }

        #endregion

        #region Metodos ordenamiento

        #endregion



    }
}
