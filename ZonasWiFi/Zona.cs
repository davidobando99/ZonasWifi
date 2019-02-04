using System;
using System.Collections.Generic;
using System.IO;
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

        public Zona()
        {
        }

        public double Local1 { get; set; }
        public double Local2 { get; set; }
        public string Nombre { get; set; }

        public void readFiles()
        {
            StreamReader st = new StreamReader("...\\..\\archivos\\ZONAS_WIFI_GRATIS_PARA_LA_GENTE.csv");

            string line = st.ReadLine();
            line = st.ReadLine();
            int conta = 0;
            while (conta<303)
            {

                string[] info = line.Split(',');
                string name = info[8];
                string longitud = info[14];
                string latitud = info[15];
                writeFile(name, longitud, latitud);
                conta++;
                Console.WriteLine(conta + " CONTADOR");
               
                line = st.ReadLine();
            }
            st.Close();

        }
        public void writeFile(string name, string longitud, string latitud)
        {
            StreamWriter sw = new StreamWriter("...\\..\\archivos\\" + name + ".txt");
            Console.WriteLine(name + " NOMBRE MUNICIPIO");
           // Console.WriteLine(latitud + " LATITUD MUNICIPIO");
            sw.WriteLine(longitud + "," + latitud);
            sw.Close();
        }
        static void Main()
        {
            Zona z = new Zona();
            z.readFiles();
        }


       
    }
}
