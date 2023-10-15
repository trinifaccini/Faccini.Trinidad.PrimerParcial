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
            return (a.nombre == b.nombre && 
                a.precio == b.precio && 
                a.alturaActual == b.alturaActual && 
                a.tieneEspinas 
                && a.tieneEspinas == b.tieneEspinas);
        }

        public static bool operator !=(Cactus a, Cactus b)
        {
            return !(a == b);
        }

        #endregion

        #region Metodos
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());


            return sb.ToString();
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo: Cactus  \t");
            sb.Append(base.Mostrar());
            sb.Append(this.tieneEspinas ? $"Tiene espinas\t" : $"No tiene espinas\t");
            return (sb.ToString());

        }

        internal override void CrecerPlanta()
        {
            if (alturaActual + 5 <= alturaMax)
            {
                alturaActual += 5;
            }
        }
   
        #endregion


    }
}
