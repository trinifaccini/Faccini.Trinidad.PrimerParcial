using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Vivero
{
    internal abstract class Planta
    {
        internal DateTime ultimoRiego; // no se recibe en el constructor
        internal int frecuenciaRiego;
        internal EEstacion estacionTransplante;
        internal bool tieneFlores;

        internal bool aptaInterior;
        internal bool aptaExterior;

        internal float alturaMax;
        internal float alturaActual; // no se recibe en el constructor 
        internal float alturaTransplante;

        // PREGUNTAR SI ESTA BIEN
        internal bool Transpantable {
            get { return (this.ObtenerEstacion() == estacionTransplante); }
        }

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

        // este metodo lo implementa cada clase, segun que tipo sea hace crecer ciertos cm a la planta
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
        
        // bool se puede transplantar ->
        // devuelve true si nos encontramos en la estacion en la que se puede
        // y tiene la altura necesaria 

        private bool Transplantar() { 
            return true; 
        }

        







    }
}
