using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS__2026_1.Clase_Definitions
{
    internal class Ingeniero_Civil
    {
        bool tituloIC;
        string colorCasco;
        string software;
        string lugarT;
        string tipoProyecto;
        string responsabilidad;
        string herramientaT;
        string clima;

        public bool TituloIC()
        {
            return tituloIC;
        }
        public void TituloIC(bool tituloIC)
        {
            this.tituloIC = tituloIC;
        }
    }
}
