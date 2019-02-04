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
           
            
                while (line != null )
                {

                    string[] info = line.Split(',');
                    string name = info[8];
                    string longitud = info[14];
                    string latitud = info[15];

              
                writeFile(name, longitud, latitud);


                    line = st.ReadLine();

                }

            st.Close();
           
            





        }
        public void writeFile(string name, string longitud, string latitud)
        {
            Console.WriteLine(name);
            StreamWriter sw = new StreamWriter("...\\..\\archivos\\" + name + ".txt",true);
            
            sw.WriteLine(longitud + "," + latitud);
            sw.Close();
        }
        
        public string[] buscarMunicipio(string name)
        {
            StreamReader st = new StreamReader("...\\..\\archivos\\"+name+".txt");

            string line = st.ReadLine();
            string[] info = line.Split(',');
            string [] datos = new string[10];
            int contador = 0;
            while (line != null)
            {


                datos[contador] = line;
                contador++;
                line = st.ReadLine();
            }
            st.Close();
            return datos;

            
        }



    }
}
