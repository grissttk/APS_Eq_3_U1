using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS__2026_1.Clase_Definitions
{
    internal class Bombero
    {
        string rangoB;
        string equipoB;
        string vehiculo;
        string valor;
        string turno;
        string herramientaB;
        string riesgo;
        string entrenamiento;

        public string RangoB()
        {
            return rangoB;
        }
        public void RangoB(string rangoB)
        {
            this.rangoB = rangoB;
        }
    }
}
