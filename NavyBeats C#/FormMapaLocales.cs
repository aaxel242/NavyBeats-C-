using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace NavyBeats_C_
{
    public partial class FormMapaLocales : Form
    {
        // Límites de Cataluña
        private readonly double minLat = 40.5;
        private readonly double maxLat = 42.9;
        private readonly double minLng = 0.15;
        private readonly double maxLng = 3.33;

        // Overlay para los markers de restaurantes
        private GMapOverlay overlayRestaurant = new GMapOverlay("markersRestaurant");

        public FormMapaLocales()
        {
            InitializeComponent();
        }

        private void FormMapaLocales_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox con los restaurantes (usuarios que son locales)
            var restaurants = Models.RestaurantsOrm.GetRestaurants();
            cBoxMunicipios.DataSource = restaurants;
            cBoxMunicipios.DisplayMember = "name";
            cBoxMunicipios.ValueMember = "user_id";
            cBoxMunicipios.TabStop = false;

            // Llenar el FlowLayoutPanel con las "tarjetas" de información de los restaurantes
            ConfigurarFlowLayoutPanelRestaurantes(flowLayoutPanelLocales);

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
            gMapControl1.Position = new PointLatLng(41.3851, 2.1734);
            gMapControl1.MinZoom = 6;
            gMapControl1.MaxZoom = 18;
            gMapControl1.Zoom = 8;

            // Agregar el overlay para markers (se crea una sola vez)
            gMapControl1.Overlays.Add(overlayRestaurant);

            // Suscribirse al evento de click en marker
            gMapControl1.OnMarkerClick += new MarkerClick(gMapControl1_OnMarkerClick);

            // Manejar el evento para restringir el movimiento dentro de Cataluña
            gMapControl1.OnMapDrag += GMapControl1_OnMapDrag;

            // Mostrar el marker del restaurante seleccionado (si ya hay alguno seleccionado)
            MostrarMarkerEnMapa();
        }

        // Configurar el FlowLayoutPanel para mostrar las tarjetas de restaurantes
        private void ConfigurarFlowLayoutPanelRestaurantes(FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.WrapContents = false;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Controls.Clear();

            var restaurantList = Models.RestaurantsOrm.GetRestaurantInfoList();

            foreach (var restaurant in restaurantList)
            {
                // Panel contenedor para la "tarjeta"
                Panel panelRestaurante = new Panel();
                panelRestaurante.Size = new Size(220, 90);
                panelRestaurante.BackColor = Color.FromArgb(134, 187, 216);
                panelRestaurante.Margin = new Padding(5);

                // Label para el nombre
                Label lblNombre = new Label();
                lblNombre.Text = restaurant.Name;
                lblNombre.Font = new Font("Montserrat", 10, FontStyle.Bold);
                lblNombre.Location = new Point(10, 5);
                lblNombre.AutoSize = true;

                // Label para el email
                Label lblEmail = new Label();
                lblEmail.Text = restaurant.Email;
                lblEmail.Font = new Font("Montserrat", 9, FontStyle.Regular);
                lblEmail.Location = new Point(10, 25);
                lblEmail.AutoSize = true;

                // Label para el municipio
                Label lblMunicipio = new Label();
                lblMunicipio.Text = restaurant.Municipality;
                lblMunicipio.Font = new Font("Montserrat", 9, FontStyle.Regular);
                lblMunicipio.Location = new Point(10, 45);
                lblMunicipio.AutoSize = true;

                // Label para el horario (apertura y cierre)
                Label lblHorario = new Label();

                // Asegúrate de que OpeningTime y ClosingTime no sean nulos antes de intentar formatearlos
                string openingTime = restaurant.OpeningTime.HasValue ? restaurant.OpeningTime.Value.ToString(@"hh\:mm") : "No disponible";
                string closingTime = restaurant.ClosingTime.HasValue ? restaurant.ClosingTime.Value.ToString(@"hh\:mm") : "No disponible";

                lblHorario.Text = $"Apertura: {openingTime} - Cierre: {closingTime}";
                lblHorario.Font = new Font("Montserrat", 8, FontStyle.Regular);
                lblHorario.Location = new Point(10, 65);
                lblHorario.AutoSize = true;

                // Agregar los labels al panel
                panelRestaurante.Controls.Add(lblNombre);
                panelRestaurante.Controls.Add(lblEmail);
                panelRestaurante.Controls.Add(lblMunicipio);
                panelRestaurante.Controls.Add(lblHorario);

                // Agregar el panel al FlowLayoutPanel
                flowLayoutPanel.Controls.Add(panelRestaurante);
            }
        }

        private void GMapControl1_OnMapDrag()
        {
            double lat = gMapControl1.Position.Lat;
            double lng = gMapControl1.Position.Lng;

            if (lat < minLat) lat = minLat;
            if (lat > maxLat) lat = maxLat;
            if (lng < minLng) lng = minLng;
            if (lng > maxLng) lng = maxLng;

            gMapControl1.Position = new PointLatLng(lat, lng);
        }

        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento para seleccionar un restaurante del ComboBox y mostrar su marker en el mapa
        private void cBoxMunicipios_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MostrarMarkerEnMapa();
        }

        private void MostrarMarkerEnMapa()
        {
            if (cBoxMunicipios.SelectedValue is int selectedUserId)
            {
                // Obtener RestaurantInfo para este restaurante (usando GetRestaurantInfoList)
                var restaurantInfo = Models.RestaurantsOrm.GetRestaurantInfoList()
                    .FirstOrDefault(r => r.UserId == selectedUserId);

                if (restaurantInfo != null && restaurantInfo.Latitud.HasValue && restaurantInfo.Longitud.HasValue)
                {
                    double lat = restaurantInfo.Latitud.Value;
                    double lng = restaurantInfo.Longitud.Value;
                    PointLatLng punto = new PointLatLng(lat, lng);

                    // Eliminar cualquier marker previo
                    overlayRestaurant.Markers.Clear();

                    // Crear un marker (chincheta) – usaremos GMarkerGoogle (por ejemplo, red_dot)
                    GMapMarker marker = new GMarkerGoogle(punto, GMarkerGoogleType.red_dot);
                    // Asignar los datos al Tag para usarlos en el click
                    marker.Tag = restaurantInfo;
                    // Opcional: asignar un ToolTip con la leyenda
                    marker.ToolTipText = $"Nombre: {restaurantInfo.Name}\nApertura: {restaurantInfo.OpeningTime?.ToString(@"hh\:mm") ?? "No disponible"}\nCierre: {restaurantInfo.ClosingTime?.ToString(@"hh\:mm") ?? "No disponible"}";

                    overlayRestaurant.Markers.Add(marker);

                    gMapControl1.Refresh();
                    gMapControl1.Invalidate();
                }
                else
                {
                    MessageBox.Show("No se encontraron coordenadas para este restaurante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Evento para click en marker: hacer zoom y mostrar una leyenda
        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (item.Tag is Models.RestaurantInfo info)
            {
                // Asignar el texto de la leyenda al marker
                item.ToolTipMode = MarkerTooltipMode.Always; // Siempre mostrar la leyenda tras hacer clic
                item.ToolTipText = $"📍 {info.Name}\n🕒 Apertura: {info.OpeningTime:hh\\:mm} - Cierre: {info.ClosingTime:hh\\:mm}";

                // Hacer zoom al marker
                gMapControl1.Position = item.Position;
                gMapControl1.Zoom = 15;

                // Refrescar el mapa para que la leyenda aparezca
                gMapControl1.Refresh();
            }
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
    }
}
