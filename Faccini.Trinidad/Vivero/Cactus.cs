using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    /// <summary>
    /// Representa un cactus con sus atributos principales
    /// </summary>
    public class Cactus : Planta
    {

        #region Atributos

        private bool tieneEspinas;
        private bool tieneFlores;

        #endregion

        #region Propiedades
        public bool TieneEspinas { get { return tieneEspinas; } set { tieneEspinas = value; } }
        public bool TieneFlores { get { return tieneFlores; } set { tieneFlores = value; } }
        #endregion

        #region Constructores

        public Cactus() { }

        public Cactus(string nombre):base(nombre) { }

        // Recibe todos
        public Cactus(string nombre, int frecuenciaRiego, EEstacion estacionTransplante, bool aptaInterior, bool aptaExterior,
            float alturaMax, float alturaTransplante,bool espinas, bool flores, float precio) :
            this(nombre, frecuenciaRiego, estacionTransplante, aptaInterior, aptaExterior, alturaMax, alturaTransplante, espinas, precio)
        {
            this.tieneFlores = flores;
        }

        // Recibe todos menos flores
        public Cactus(string nombre, int frecuenciaRiego, EEstacion estacionTransplante, bool aptaInterior, bool aptaExterior,
            float alturaMax, float alturaTransplante, bool espinas, float precio) :
            this(nombre, frecuenciaRiego, estacionTransplante, aptaInterior, aptaExterior, alturaMax, alturaTransplante, precio)
        {
            this.tieneEspinas = espinas;
        }

        // Recibe todos menos flores y espinas
        public Cactus(string nombre, int frecuenciaRiego, EEstacion estacionTransplante, bool aptaInterior, bool aptaExterior, 
            float alturaMax, float alturaTransplante, float precio) : 
            base(nombre, frecuenciaRiego, estacionTransplante, aptaInterior, aptaExterior, alturaMax, alturaTransplante,precio)
        {
            this.tieneEspinas = false;
            this.tieneFlores = false;
        }

        #endregion

        #region Sobreescritura operadores

        /// <summary>
        /// Compara dos objetos de tipo Cactus segun sus atributos: nombre y tieneEspinas
        /// </summary>
        /// <returns>true si son iguales, false si son diferentes</returns>
        public static bool operator ==(Cactus a, Cactus b)
        {
            return a.nombre.ToLower() == b.nombre.ToLower() && a.tieneEspinas == b.tieneEspinas;
        
        }

        /// <summary>
        /// Compara dos objetos de tipo Cactus segun sus atributos: nombre, precio, alturaActual y tieneEspinas
        /// </summary>
        /// <returns>true si son diferentes, false si son iguales</returns>
        public static bool operator !=(Cactus a, Cactus b)
        {
            return !(a == b);
        }

        public static implicit operator string(Cactus cactus)
        {
            return cactus.Nombre;
        }

        public static explicit operator Cactus(string nombreCactus)
        {
            Cactus c = new Cactus(nombreCactus);
            return c;
        }

        #endregion

        #region Metodos

        // NO DOCUMENTAR
        public override bool Equals(object? obj)
        {
            if (obj is Cactus)
                return this == (Cactus)obj;

            return false;
        }

        // NO DOCUMENTAR
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Cactus - ");
            sb.Append(base.ToString());
            return sb.ToString();
        }


        // DOCUMENTADA EN CLASE BASE
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.ToString());
            sb.Append(tieneEspinas ? $"Tiene espinas\n" : $"No tiene espinas\n");

            return (sb.ToString());

        }

        // DOCUMENTADA EN CLASE BASE
        internal override bool CrecerPlanta()
        {
            if (alturaActual < alturaMax)
            {
                if (alturaActual + 5 <= alturaMax)
                    alturaActual += 5;
                else
                    alturaActual = alturaMax;

                return true;
            }

            else return false;
        }

     

        #endregion


    }
}
