using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZonasWiFi
{
    public partial class Form1 : Form
    {
        private Zona zona;
        public Form1()
        {
            zona = new Zona();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obtenerMunicipio();
        }

        private void gMap_Load(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //gMap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            //GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            // gMap.SetPositionByKeywords("Cali, Colombia");
            //gMap.Position = new GMap.NET.PointLatLng(-25.966688, 32.580528);

            //GMapOverlay markersOverlay = new GMapOverlay("markers");
            //GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-25.966688, 32.580528),
            //GMarkerGoogleType.green);
            //markersOverlay.Markers.Add(marker);
            //gMap.Overlays.Add(markersOverlay);




        }
        public void obtenerMunicipio()
        {

            string municipio = txtMunicipio.Text;
            string[] info = zona.buscarMunicipio(municipio);

           for(int i = 0; i < info.Length; i++)
            {
                 
            }

           




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
