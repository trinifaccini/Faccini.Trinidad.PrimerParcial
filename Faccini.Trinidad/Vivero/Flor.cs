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
        #endregion

        #region Constructores

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
            return (a.nombre == b.nombre && a.precio == b.precio && a.alturaActual == b.alturaActual && a.tieneOlor == b.tieneOlor);
        }

        public static bool operator !=(Flor a, Flor b)
        {
            return !(a == b);
        }

        #region Metodos

        public override void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Color de sus flores: {color}");
            sb.AppendLine($"Tiene olor: {tieneOlor}");

            base.Mostrar();
            Console.Write(sb.ToString());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());


            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
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
