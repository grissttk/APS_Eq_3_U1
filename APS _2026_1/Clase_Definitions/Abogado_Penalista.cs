using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS__2026_1.Clase_Definitions
{
    internal class Abogado_Penalista
    {
        bool titulo_lic;
        string especialidad;
        string lugar;
        string vestimenta;
        string habilidad;
        string honorarios;
        string lectura;
        string estres;

        public bool TituloLic()
        {
            return titulo_lic;
        }

        public void TituloLic(bool titulo_lic)
        {
            this.titulo_lic = titulo_lic;
        }
    }
}
