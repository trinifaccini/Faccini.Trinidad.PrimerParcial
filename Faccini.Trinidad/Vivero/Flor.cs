using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
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
            this.color = "verde";
            this.tieneOlor = false;
        }

        #endregion

        public static bool operator ==(Flor a, Flor b)
        {
            return (a.nombre == b.nombre && 
                a.precio == b.precio && 
                a.alturaActual == b.alturaActual && 
                a.tieneOlor == b.tieneOlor);
        }

        public static bool operator !=(Flor a, Flor b)
        {
            return !(a == b);
        }

        #region Metodos

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Tipo: ");
            sb.Append(this.ToString());
            sb.Append($"Color: {color}\n");

            return (sb.ToString());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Flor\t");
            sb.Append(base.ToString());
            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            Console.WriteLine("EQUALS DE FLOR");

            if (obj is Flor)
                return this == (Flor)obj;

            return false;
        }

        internal override void CrecerPlanta()
        {
            if (alturaActual + 10 <= alturaMax)
            {
                alturaActual += 10;
            }
        }

        #endregion
    }
}
