using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS__2026_1.Clase_Definitions
{
    internal class Desarrollador_de_Juegos
    {
        string rol;
        string motor;
        string lenguaje_programacion;
        string creatividad;
        string proyecto;
        string equipo;
        string presion;
        string estilo;
        
        public string Rol()
        {
            return this.rol;
        }

        public void Rol(string rol)
        {
            this.rol = rol;
        }
    }
}
