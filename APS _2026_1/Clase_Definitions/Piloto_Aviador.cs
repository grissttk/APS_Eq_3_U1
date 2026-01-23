using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS__2026_1.Clase_Definitions
{
    internal class Piloto_Aviador
    {
        bool licenciaPA;
        string aeronave;
        string idioma;
        string uniformePA;
        int vista;
        bool maletaLista;
        string salario;
        string lugar;

        public bool LicenciaPA()
        {
            return licenciaPA;
        }
        public void LicenciaPA(bool licenciaPA)
        {
            this.licenciaPA = licenciaPA;
        }
    }
}
