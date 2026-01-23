using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS__2026_1.Clase_Definitions
{
    internal class Chef_Ejecutivo
    {
        string rango;
        string especilidad_comida;
        string uniforme;
        string herramienta_cocina;
        string lugar;
        string paladar;
        string ritmo;
        string gestión;

        public string Rango()
        {
            return rango;
        }

        public void Rango(string rango)
        {
            this.rango = rango;
        }
    }
}
