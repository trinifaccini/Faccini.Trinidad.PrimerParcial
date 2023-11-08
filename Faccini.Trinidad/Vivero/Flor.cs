using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    /// <summary>
    /// Representa una flor con sus atributos principales
    /// </summary>
    public class Flor : Planta
    {
        #region Atributos
        private string color;
        private bool tieneOlor;
        #endregion

        #region Propiedades

        public string Color { get { return color; } set { color = value;  } }
        public bool TieneOlor { get {  return tieneOlor; } set { tieneOlor = value; } }

        #endregion

        #region Constructores

        public Flor()
        {
            color = "";
        }

        public Flor(string nombre):base(nombre)
        {
            color = "verde";
        }

        // Recibe todos
        public Flor(string nombre, int frecuenciaRiego, EEstacion estacionTransplante, bool aptaInterior, bool aptaExterior, float alturaMax,
            float alturaTransplante, string color, bool tieneOlor, float precio) :
            this(nombre, frecuenciaRiego, estacionTransplante, aptaInterior, aptaExterior, alturaMax, alturaTransplante, color, precio)
        {
            this.tieneOlor = tieneOlor;
        }

        // Recibe todos menos olor
        public Flor(string nombre, int frecuenciaRiego, EEstacion estacionTransplante, bool aptaInterior, bool aptaExterior, float alturaMax,
            float alturaTransplante, string color, float precio) :
            this(nombre, frecuenciaRiego, estacionTransplante, aptaInterior, aptaExterior, alturaMax, alturaTransplante, precio)
        {
            this.color = color;
        }

        // Recibe todos menos olor y color
        public Flor(string nombre, int frecuenciaRiego, EEstacion estacionTransplante, bool aptaInterior, bool aptaExterior, float alturaMax, 
            float alturaTransplante, float precio) : 
            base(nombre, frecuenciaRiego, estacionTransplante, aptaInterior, aptaExterior, alturaMax, alturaTransplante, precio)
        {
            this.color = "Verde";
            this.tieneOlor = false;
        }

        #endregion


        /// <summary>
        /// Compara dos objetos de tipo Flor segun sus atributos: nombre y tieneOlor
        /// </summary>
        /// <returns>true si son iguales, false si son diferentes</returns>
        public static bool operator ==(Flor a, Flor b)
        {
             return a.nombre.ToLower() == b.nombre.ToLower() && a.tieneOlor == b.tieneOlor; 

            
        }

        /// <summary>
        /// Compara dos objetos de tipo Flor segun sus atributos: nombre, precio, alturaActual y tieneOlor
        /// </summary>
        /// <returns>false si son iguales, true si son diferentes</returns>
        public static bool operator !=(Flor a, Flor b)
        {
            return !(a == b);
        }


        public static implicit operator string(Flor flor)
        {
            return flor.Nombre;
        }

        public static explicit operator Flor(string nombreFlor)
        {
            Flor f = new Flor(nombreFlor);
            return f;
        }

        #region Metodos

        // DOCUMENTADA EN CLASE BASE
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.ToString());
            sb.Append($"Color: {color} - ");
            sb.Append(tieneOlor ? $"Tiene olor\n" : $"No tiene olor\n");

            return (sb.ToString());
        }

        // NO DOCUMENTAR
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Flor      - ");
            sb.Append(base.ToString());
            return sb.ToString();
        }

        // NO DOCUMENTAR
        public override bool Equals(object? obj)
        {
            if (obj is Flor)
                return this == (Flor)obj;

            return false;
        }

        // DOCUMENTADA EN CLASE BASE
        internal override bool CrecerPlanta()
        {
            if (alturaActual < alturaMax)
            {
                if (alturaActual + 10 <= alturaMax)
                    alturaActual += 10;
                else
                    alturaActual = alturaMax;
                return true;
 
            }

            else return false;
        }

        #endregion
    }
}
