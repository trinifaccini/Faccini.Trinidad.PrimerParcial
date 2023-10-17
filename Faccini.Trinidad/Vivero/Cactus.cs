using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
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
        public static bool operator ==(Cactus a, Cactus b)
        {
            Console.WriteLine("== DE CACTUS");
            return (a.nombre == b.nombre && 
                a.precio == b.precio && 
                a.alturaActual == b.alturaActual && 
                a.tieneEspinas == b.tieneEspinas);
        }

        public static bool operator !=(Cactus a, Cactus b)
        {
            return !(a == b);
        }

        #endregion

        #region Metodos
        public override bool Equals(object? obj)
        {
            Console.WriteLine("EQUALS DE CACTUS");

            if (obj is Cactus)
                return this == (Cactus)obj;

            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Cactus\t");
            sb.Append(base.ToString());
            return sb.ToString();
        }


        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Tipo: ");
            sb.Append(this.ToString());
            sb.Append(tieneEspinas ? $"Tiene espinas\n" : $"No tiene espinas\n");

            return (sb.ToString());

        }

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
