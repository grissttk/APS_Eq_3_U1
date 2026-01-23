using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS__2026_1.Clase_Definitions
{
    internal class Medico_Cirujano
    {
        string especialidad;
        int años_de_servicio;
        string lugar;
        string uniforme;
        string responsabilidad;
        string herramienta;
        int guardia;
        bool licenciatura;

        public string Especialidad()
        {
            return especialidad;
        }

        public void Especialidad(string especialidad)
        {
            this.especialidad = especialidad;
        }
    }
}
