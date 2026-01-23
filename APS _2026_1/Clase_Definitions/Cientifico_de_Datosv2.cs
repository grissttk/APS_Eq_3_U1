using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace APS__2026_1.Clase_Definitions
{
    internal class Cientifico_de_Datosv2
    {

        //Abstraccion
        //Encapsulamiento
        private bool titulo;
        private string lenguaje;
        private string nivel_de_estudios;
        private string salario;
        private string habilidad;
        private string equipo;
        private string entorno;

        public Cientifico_de_Datosv2(bool titulo, string lenguaje, string nivel_de_estudios,
            string salario, string habilidad, string equipo, string entorno)
        {
            this.titulo = titulo;
            this.lenguaje = lenguaje;
            this.nivel_de_estudios = nivel_de_estudios;
            this.salario = salario;
            this.habilidad = habilidad;
            this.equipo = equipo;
            this.entorno = entorno;
        }

        public string Lenguaje()
        {
            return lenguaje;
        }

        public void Lenguaje(string lenguaje)
        {
            this.lenguaje = lenguaje;
        } 

        //getter y setter
        public string Nivel_de_Estudios
        {
            get
            {
                return "Nivel de estudios" + nivel_de_estudios;
            }
            set
            {
                nivel_de_estudios = value;
            }
        }
    }

}
