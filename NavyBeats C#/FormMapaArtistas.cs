﻿using System;
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
        // Límites para restringir el movimiento del mapa.
        private readonly double minLat = 40.5;
        private readonly double maxLat = 42.9;
        private readonly double minLng = 0.15;
        private readonly double maxLng = 3.33;

        // Overlay para el círculo del músico.
        private GMapOverlay overlayMusico = new GMapOverlay("zonasMusico");

        public FormMapaArtistas()
        {
            InitializeComponent();

            //labelNombre.Text = Resources.Idiomas.lblNombreMusico;
        }
        /// <summary>
        /// Configuraciones iniciales del mapa y del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMapaArtistas_Load(object sender, EventArgs e)
        {
            // Cargar músicos en el ComboBox.
            var musicians = Models.UsuarioMovilOrm.SelectMusician();
            cboxMusicos.DataSource = musicians;
            cboxMusicos.DisplayMember = "name";
            cboxMusicos.ValueMember = "user_id";

            // Configurar el FlowLayoutPanel.
            ConfiguracionFlowLayoutPanel(flowLayoutPanelMusicos);

            panelMapa.BackColor = Color.FromArgb(216, 255, 255, 255);

            //Configuraciones iniciales del formulario.
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Configuración del mapa.
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.ShowCenter = false;
            gMapControl1.IgnoreMarkerOnMouseWheel = false;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            // Posición inicial en el centro de Barcelona.
            PointLatLng centroBarcelona = new PointLatLng(41.3851, 2.1734);
            gMapControl1.Position = centroBarcelona;
            gMapControl1.MinZoom = 6;
            gMapControl1.MaxZoom = 18;
            gMapControl1.Zoom = 8;

            // Crear un overlay para otras zonas.
            GMapOverlay overlayZonas = new GMapOverlay("zonas");
            gMapControl1.Overlays.Add(overlayZonas);

            // Manejar el evento para restringir el movimiento dentro de Cataluña.
            gMapControl1.OnMapDrag += GMapControl1_OnMapDrag;

            // (Opcional) Forzar la carga inicial del círculo si hay un músico seleccionado por defecto.
            if (cboxMusicos.SelectedValue is int selectedUserId)
            {
                MostrarCirculosEnMapa();
            }

            MostrarCirculosEnMapa();

        }

        /// <summary>
        /// Crea un círculo de puntos alrededor de un centro dado.
        /// </summary>
        /// <param name="centro"></param>
        /// <param name="radioKm"></param>
        /// <param name="segmentos"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Evento que se ejecuta al arrastrar el mapa.
        /// </summary>
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
        /// <summary>
        /// Configura el FlowLayoutPanel con los músicos.
        /// </summary>
        /// <param name="flowLayoutPanel"></param>
        private void ConfiguracionFlowLayoutPanel(FlowLayoutPanel flowLayoutPanel)
        {
            // Cargar los músicos en el panel solo una vez.
            flowLayoutPanel.Controls.Clear();

            var musicianList = Models.UsuarioMovilOrm.SelectMusician();

            foreach (var musician in musicianList)
            {
                Panel panelMusico = new Panel();
                panelMusico.Size = new Size(220, 70);
                panelMusico.BackColor = Color.FromArgb(134, 187, 216);
                panelMusico.Margin = new Padding(5);

                Label lblNombre = new Label();
                lblNombre.Text = musician.name;
                lblNombre.Font = new Font("Montserrat", 10, FontStyle.Bold);
                lblNombre.Location = new Point(10, 10);
                lblNombre.AutoSize = true;

                Label lblEmail = new Label();
                lblEmail.Text = musician.email;
                lblEmail.Font = new Font("Montserrat", 9, FontStyle.Regular);
                lblEmail.Location = new Point(10, 30);
                lblEmail.AutoSize = true;

                Label lblMunicipio = new Label();
                lblMunicipio.Text = musician.municipality;
                lblMunicipio.Font = new Font("Montserrat", 9, FontStyle.Regular);
                lblMunicipio.Location = new Point(10, 50);
                lblMunicipio.AutoSize = true;

                panelMusico.Controls.Add(lblNombre);
                panelMusico.Controls.Add(lblEmail);
                panelMusico.Controls.Add(lblMunicipio);

                flowLayoutPanel.Controls.Add(panelMusico);
            }
        }
        /// <summary>
        /// Muestra un círculo en el mapa basado en la selección del ComboBox.
        /// </summary>
        private void MostrarCirculosEnMapa()
        {
            if (cboxMusicos.SelectedValue is int selectedUserId)
            {
                var musico = Models.UsuarioMovilOrm.SelectMusicianByIdFromUsers(selectedUserId);

                if (musico != null && musico.latitud.HasValue && musico.longitud.HasValue)
                {
                    double lat = Convert.ToDouble(musico.latitud.Value);
                    double lng = Convert.ToDouble(musico.longitud.Value);
                    PointLatLng centroMusico = new PointLatLng(lat, lng);

                    // Eliminar el overlay anterior si existe.
                    if (overlayMusico.Polygons.Count > 0)
                    {
                        gMapControl1.Overlays.Remove(overlayMusico);
                        overlayMusico.Polygons.Clear();
                    }

                    // Crear el círculo.
                    List<PointLatLng> puntos = CrearCirculo(centroMusico, 10, 100);
                    GMapPolygon circulo = new GMapPolygon(puntos, "Zona Músico")
                    {
                        Stroke = new Pen(Color.Red, 4),
                        Fill = new SolidBrush(Color.FromArgb(128, 255, 0, 0)) 
                    };

                    overlayMusico.Polygons.Add(circulo);
                    gMapControl1.Overlays.Add(overlayMusico);

                    // Forzar actualización del mapa.
                    gMapControl1.Refresh();
                    gMapControl1.Invalidate();
                }
                else
                {
                    MessageBox.Show(Resources.Strings.msgCoordMusico, Resources.Strings.msgError, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        /// <summary>
        /// Evento que se ejecuta al cambiar la selección del ComboBox de músicos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxMusicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Actualizar el círculo sin recargar el FlowLayoutPanel (ya cargado en Load).
            MostrarCirculosEnMapa();
        }
        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de mapa de músicos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocalMapa_Click(object sender, EventArgs e)
        {
            using (FormMapaLocales formMapaLocales = new FormMapaLocales())
            {
                this.Hide();
                formMapaLocales.ShowDialog();
                this.Show();
            }
        }
        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
