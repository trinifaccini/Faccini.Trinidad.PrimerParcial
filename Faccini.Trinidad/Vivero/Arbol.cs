using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Arbol : Planta
    {

        #region Atributos
        private bool tieneFrutos;
        private EPais paisOrigen;
        #endregion

        #region Propiedades
        #endregion

        #region Constructores

        // Recibe todos
        public Arbol(string nombre, int frecuenciaRiego, EEstacion estacionTransplante, bool aptaInterior, bool aptaExterior,
            float alturaMax, float alturaTransplante, bool tieneFrutos, EPais paisOrigen, float precio) :
            this(nombre, frecuenciaRiego, estacionTransplante, aptaInterior, aptaExterior, alturaMax, alturaTransplante, tieneFrutos, precio)
        {
            this.paisOrigen = paisOrigen;
        }

        // Recibe todos menos paisOrigen
        public Arbol(string nombre, int frecuenciaRiego, EEstacion estacionTransplante, bool aptaInterior, bool aptaExterior,
            float alturaMax, float alturaTransplante, bool tieneFrutos, float precio) :
            this(nombre, frecuenciaRiego, estacionTransplante, aptaInterior, aptaExterior, alturaMax, alturaTransplante, precio)
        {
            this.tieneFrutos = tieneFrutos;
        }

        // Recibe todos menos paisOrigen y tieneFrutos
        public Arbol(string nombre, int frecuenciaRiego, EEstacion estacionTransplante, bool aptaInterior, bool aptaExterior, 
            float alturaMax, float alturaTransplante,float precio) : 
            base(nombre, frecuenciaRiego, estacionTransplante, aptaInterior, aptaExterior, alturaMax, alturaTransplante, precio)
        {
            tieneFrutos = false;
            paisOrigen = EPais.Argentina;
        }

        #endregion

        #region Sobreescritura de operadores

        public static bool operator ==(Arbol a, Arbol b)
        {
            Console.WriteLine("== DE ARBOL");
            return (a.nombre == b.nombre && a.precio == b.precio && a.alturaActual == b.alturaActual && a.tieneFrutos == b.tieneFrutos);
        }

        public static bool operator !=(Arbol a, Arbol b)
        {
            return !(a == b);
        }

        #endregion
        
        #region Metodos
        internal override void CrecerPlanta()
        {
            if (alturaActual + 20 <= alturaMax)
            {
                alturaActual += 20;
            }
        }

        public override void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tiene frutos: {tieneFrutos}");
            sb.AppendLine($"Pais de origen: {paisOrigen}");

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

        #endregion
    }
}
