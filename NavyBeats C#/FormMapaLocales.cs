using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NavyBeats_C_
{
    public partial class FormMapaLocales: Form
    {

        // Limites de Cataluña
        private readonly double minLat = 40.5;  // Sur
        private readonly double maxLat = 42.9;  // Norte
        private readonly double minLng = 0.15;  // Oeste
        private readonly double maxLng = 3.33;  // Este
        public FormMapaLocales()
        {
            InitializeComponent();
        }

        private void FormMapaLocales_Load(object sender, EventArgs e)
        {
            panelMapa.BackColor = Color.FromArgb(216, 255, 255, 255);
            cBoxMunicipios.TabStop = false;     

            // Centrar el formulario
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            int formWidth = this.Width;
            int formHeight = this.Height;

            int positionX = (screenWidth - formWidth) / 2;
            int positionY = (screenHeight - formHeight) / 2;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(positionX, positionY);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Configuración del mapa
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.ShowCenter = false;
            gMapControl1.IgnoreMarkerOnMouseWheel = false;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;

            // Seleccionar Google Maps como proveedor
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            // Posición inicial en el centro de Barcelona
            gMapControl1.Position = new PointLatLng(41.3851, 2.1734);

            // Configuración de zoom
            gMapControl1.MinZoom = 6;
            gMapControl1.MaxZoom = 18;
            gMapControl1.Zoom = 8;

            // Manejar el evento para restringir el movimiento dentro de Cataluña
            gMapControl1.OnMapDrag += GMapControl1_OnMapDrag;
        }

        private void GMapControl1_OnMapDrag()
        {
            // Obtener la posición actual
            double lat = gMapControl1.Position.Lat;
            double lng = gMapControl1.Position.Lng;

            // Verificar si está fuera de los límites y corregir
            if (lat < minLat) lat = minLat;
            if (lat > maxLat) lat = maxLat;
            if (lng < minLng) lng = minLng;
            if (lng > maxLng) lng = maxLng;

            // Aplicar la nueva posición si es necesario
            gMapControl1.Position = new PointLatLng(lat, lng);
        }

        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
