using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace APS__2026_1.Clase_Definitions
{
    internal class Cientifico_de_Datos
    {
        internal string titulo;

        //Abstraccion

        bool tituloo;
        string lenguaje;
        string nivel_de_estudios;
        string salario;
        string habilidad;
        string equipo;
        string entorno;

        public string Lenguaje()
        {
            return lenguaje;
        }

        public void Lenguaje(string lenguaje)
        {
            this.lenguaje = lenguaje;
        }

    }

}
