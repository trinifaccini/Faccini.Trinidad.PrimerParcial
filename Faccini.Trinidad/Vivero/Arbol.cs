using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    /// <summary>
    /// Representa un arbol con sus atributos principales
    /// </summary>
    public class Arbol : Planta
    {

        #region Atributos
        private bool tieneFrutos;
        private EPais paisOrigen;
        #endregion

        #region Propiedades

        public bool TieneFrutos { get { return tieneFrutos; } set { tieneFrutos = value; } }
        public EPais PaisOrigen { get { return paisOrigen; } set { paisOrigen = value;  } }
        #endregion

        #region Constructores
        
        public Arbol() { }

        public Arbol(string nombre) : base(nombre)
        {

        }


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

        /// <summary>
        /// Compara dos objetos de tipo Arbol segun sus atributos: nombre, precio, alturaActual y tieneFrutos
        /// </summary>
        /// <returns>true si son iguales, false si son diferentes</returns>
        public static bool operator ==(Arbol a, Arbol b)
        {
            return (a.nombre == b.nombre && 
                a.precio == b.precio && 
                a.alturaActual == b.alturaActual && 
                a.tieneFrutos == b.tieneFrutos);
        }

        /// <summary>
        /// Compara dos objetos de tipo Arbol segun sus atributos: nombre, precio, alturaActual y tieneFrutos
        /// </summary>
        /// <returns>false si son iguales, true si son diferentes</returns>
        public static bool operator !=(Arbol a, Arbol b)
        {
            return !(a == b);
        }

        public static implicit operator string(Arbol arbol)
        {
            return arbol.Nombre;
        }

        public static explicit operator Arbol(string nombreArbol)
        {
            Arbol a = new Arbol(nombreArbol);
            return a;
        }

        #endregion

        #region Metodos
        // DOCUMENTADA EN CLASE BASE
        internal override bool CrecerPlanta()
        {
            if (alturaActual < alturaMax)
            {
                if (alturaActual + 20 <= alturaMax)
                    alturaActual += 20;
                else
                    alturaActual = alturaMax;

                return true;

            }

            else return false;
        }

        // DOCUMENTADA EN CLASE BASE
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Tipo: ");
            sb.Append(this.ToString());
            sb.Append($"Pais: {paisOrigen}\n");
            return sb.ToString();
        }
        
        // NO DOCUMENTAR
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Arbol\t");
            sb.Append(base.ToString());
            return sb.ToString();
        }

        // NO DOCUMENTAR
        public override bool Equals(object? obj)
        {
            Console.WriteLine("EQUALS DE ARBOL");

            if (obj is Arbol)
                return this == (Arbol)obj;

            return false;
        }

       
        #endregion
    }
}
