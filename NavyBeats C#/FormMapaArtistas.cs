using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;

namespace NavyBeats_C_
{
    public partial class FormMapaArtistas : Form
    {
        // Límites para restringir el movimiento del mapa (Cataluña)
        private readonly double minLat = 40.5;
        private readonly double maxLat = 42.9;
        private readonly double minLng = 0.15;
        private readonly double maxLng = 3.33;
        private GMapOverlay overlayMusico = new GMapOverlay("zonasMusico");


        public FormMapaArtistas()
        {
            InitializeComponent();
        }

        private void FormMapaArtistas_Load(object sender, EventArgs e)
        {

            var musicians = Models.MusicianOrm.GetMusicians();
            cboxMusicos.DataSource = musicians;
            cboxMusicos.DisplayMember = "name";  
            cboxMusicos.ValueMember = "user_id";

            panelMapa.BackColor = Color.FromArgb(216, 255, 255, 255);

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
            this.MaximizeBox = false;

            // Configuración del mapa
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.ShowCenter = false;
            gMapControl1.IgnoreMarkerOnMouseWheel = false;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            // Posición inicial en el centro de Barcelona
            PointLatLng centroBarcelona = new PointLatLng(41.3851, 2.1734);
            gMapControl1.Position = centroBarcelona;
            gMapControl1.MinZoom = 6;
            gMapControl1.MaxZoom = 18;
            gMapControl1.Zoom = 8;

            // Crear un overlay para zonas
            GMapOverlay overlayZonas = new GMapOverlay("zonas");

            // Agregar el overlay al mapa
            gMapControl1.Overlays.Add(overlayZonas);

            // Manejar el evento para restringir el movimiento dentro de Cataluña
            gMapControl1.OnMapDrag += GMapControl1_OnMapDrag;
        }

        // Método para generar un círculo (lista de puntos)
        public static List<PointLatLng> CrearCirculo(PointLatLng centro, double radioKm, int segmentos)
        {
            List<PointLatLng> puntos = new List<PointLatLng>();
            double radioEnGrados = radioKm / 111.0; // Aproximación: 1 grado ≈ 111 km

            for (int i = 0; i <= segmentos; i++)
            {
                double theta = i * 2 * Math.PI / segmentos;
                double lat = centro.Lat + radioEnGrados * Math.Cos(theta);
                double lng = centro.Lng + radioEnGrados * Math.Sin(theta) / Math.Cos(centro.Lat * Math.PI / 180);
                puntos.Add(new PointLatLng(lat, lng));
            }
            return puntos;
        }

        private void GMapControl1_OnMapDrag()   
        {
            double lat = gMapControl1.Position.Lat;
            double lng = gMapControl1.Position.Lng;

            if (lat < 40.5) lat = 40.5;
            if (lat > 42.9) lat = 42.9;
            if (lng < 0.15) lng = 0.15;
            if (lng > 3.33) lng = 3.33;

            gMapControl1.Position = new PointLatLng(lat, lng);
        }

        private void btnLocalMapa_Click(object sender, EventArgs e)
        {
            using (FormMapaLocales formMapaLocales = new FormMapaLocales())
            {
                this.Hide();
                formMapaLocales.ShowDialog();
                this.Show();
            }
        }

        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxMusicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxMusicos.SelectedValue is int selectedUserId)
            {
                // Obtener el usuario que es músico con su latitud/longitud
                var musico = Models.MusicianOrm.GetMusicianById(selectedUserId);

                if (musico != null && musico.latitud.HasValue && musico.longitud.HasValue)
                {
                    // Convertir de decimal a double antes de crear el punto en el mapa
                    double lat = Convert.ToDouble(musico.latitud.Value);
                    double lng = Convert.ToDouble(musico.longitud.Value);
                    PointLatLng centroMusico = new PointLatLng(lat, lng);

                    // si hay un circulo previo, Eliminarlo
                    if (overlayMusico.Polygons.Count > 0)
                    {
                        gMapControl1.Overlays.Remove(overlayMusico);
                        overlayMusico.Polygons.Clear();
                    }

                    // Crear un nuevo círculo en el mapa
                    List<PointLatLng> puntos = CrearCirculo(centroMusico, 10, 100);
                    GMapPolygon circulo = new GMapPolygon(puntos, "Zona Músico")
                    {
                        Stroke = new Pen(Color.Red, 4),
                        //Color de relleno en rojo transparente
                        Fill = new SolidBrush(Color.FromArgb(128, 255, 0, 0))

                    };

                    // Agregar el nuevo círculo al overlay
                    overlayMusico.Polygons.Add(circulo);
                    gMapControl1.Overlays.Add(overlayMusico);

                    // Refrescar el mapa para reflejar los cambios
                    gMapControl1.Refresh();
                }
                else
                {
                    MessageBox.Show("No se encontraron coordenadas para este músico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
