using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZonasWiFi
{
    class Zona
    {
        private double local1;
        private double local2;
        private string nombre;

        public Zona(double local1, double local2, string nombre)
        {
            this.local1 = local1;
            this.local2 = local2;
            this.nombre = nombre;
        }



        public double Local1 { get; set; }
        public double Local2 { get; set; }
        public string Nombre { get; set; }
    }
}
