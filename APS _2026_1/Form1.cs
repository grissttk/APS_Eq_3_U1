using APS__2026_1.Clase_Definitions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS__2026_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // Tipo de dato abstracto
            Cientifico_de_Datos CdD; //declaracion del objeto

            CdD = new Cientifico_de_Datos();

            CdD.Lenguaje("Python");

           string n = CdD.Lenguaje();

            txt_lenguaje.Text = n;

            Console.WriteLine();
            
            //
            Cientifico_de_Datosv2 CdDv2;

            CdDv2 = new Cientifico_de_Datosv2(true, "Python", "Maestria", "Alto",)

            Cientifico_de_Datosv2 
        }
    }
}
