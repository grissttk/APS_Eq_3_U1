using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS__2026_1.Clase_Definitions
{
    internal class Influencer_Streamer
    {
        string plataforma;
        string nicho;
        string ingresos;
        string equipoIS;
        int audiencia;
        bool carisma;
        string edicion;
        string horario;

        public string Plataforma()
        {
            return plataforma;
        }
        public void Plataforma(string plataforma)
        {
            this.plataforma = plataforma;
        }
    }
}
