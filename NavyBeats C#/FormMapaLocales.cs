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
        // Límites para restringir el movimiento del mapa.
        private readonly double minLat = 40.5;
        private readonly double maxLat = 42.9;
        private readonly double minLng = 0.15;
        private readonly double maxLng = 3.33;

        // Overlay para los markers de restaurantes.
        private GMapOverlay overlayRestaurant = new GMapOverlay("markersRestaurant");

        public FormMapaLocales()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento de carga del formulario + configuraciones de mapa y FlowLayoutPanel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMapaLocales_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox con los restaurantes (usuarios que son locales).
            var restaurants = Models.RestaurantsOrm.GetRestaurants();
            cBoxMunicipios.DataSource = restaurants;
            cBoxMunicipios.DisplayMember = "name";
            cBoxMunicipios.ValueMember = "user_id";
            cBoxMunicipios.TabStop = false;

            // Llenar el FlowLayoutPanel con las tarjetas de información de los restaurantes.
            ConfigurarFlowLayoutPanelRestaurantes(flowLayoutPanelLocales);

            panelMapa.BackColor = Color.FromArgb(216, 255, 255, 255);

            // Configuraciónes del formulario.
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

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
            gMapControl1.Position = new PointLatLng(41.3851, 2.1734);
            gMapControl1.MinZoom = 6;
            gMapControl1.MaxZoom = 18;
            gMapControl1.Zoom = 8;

            // Agregar el overlay para markers.
            gMapControl1.Overlays.Add(overlayRestaurant);

            // Suscribirse al evento de click en marker.
            gMapControl1.OnMarkerClick += new MarkerClick(gMapControl1_OnMarkerClick);

            // Manejar el evento para restringir el movimiento dentro de Cataluña.
            gMapControl1.OnMapDrag += GMapControl1_OnMapDrag;

            // Mostrar el marker del restaurante seleccionado (si ya hay alguno seleccionado).
            MostrarMarkerEnMapa();
        }

        /// <summary>
        /// Configura el FlowLayoutPanel para mostrar la información de los restaurantes.
        /// </summary>
        /// <param name="flowLayoutPanel"></param>
        private void ConfigurarFlowLayoutPanelRestaurantes(FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.WrapContents = false;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Controls.Clear();

            var restaurantList = Models.RestaurantsOrm.GetRestaurantInfoList();

            foreach (var restaurant in restaurantList)
            {
                // Panel contenedor para la tarjeta.
                Panel panelRestaurante = new Panel();
                panelRestaurante.Size = new Size(220, 90);
                panelRestaurante.BackColor = Color.FromArgb(134, 187, 216);
                panelRestaurante.Margin = new Padding(5);

                // Label para el nombre.
                Label lblNombre = new Label();
                lblNombre.Text = restaurant.Name;
                lblNombre.Font = new Font("Montserrat", 10, FontStyle.Bold);
                lblNombre.Location = new Point(10, 5);
                lblNombre.AutoSize = true;

                // Label para el email.
                Label lblEmail = new Label();
                lblEmail.Text = restaurant.Email;
                lblEmail.Font = new Font("Montserrat", 9, FontStyle.Regular);
                lblEmail.Location = new Point(10, 25);
                lblEmail.AutoSize = true;

                // Label para el municipio.
                Label lblMunicipio = new Label();
                lblMunicipio.Text = restaurant.Municipality;
                lblMunicipio.Font = new Font("Montserrat", 9, FontStyle.Regular);
                lblMunicipio.Location = new Point(10, 45);
                lblMunicipio.AutoSize = true;

                // Label para el horario (apertura y cierre).
                Label lblHorario = new Label();
                string openingTime = !string.IsNullOrEmpty(restaurant.OpeningTime) ? restaurant.OpeningTime : "No disponible";
                string closingTime = !string.IsNullOrEmpty(restaurant.ClosingTime) ? restaurant.ClosingTime : "No disponible";
                lblHorario.Text = $"Apertura: {openingTime} - Cierre: {closingTime}";
                lblHorario.Font = new Font("Montserrat", 8, FontStyle.Regular);
                lblHorario.Location = new Point(10, 65);
                lblHorario.AutoSize = true;

                // Agregar los labels al panel.
                panelRestaurante.Controls.Add(lblNombre);
                panelRestaurante.Controls.Add(lblEmail);
                panelRestaurante.Controls.Add(lblMunicipio);
                panelRestaurante.Controls.Add(lblHorario);

                // Agregar el panel al FlowLayoutPanel.
                flowLayoutPanel.Controls.Add(panelRestaurante);
            }
        }
        /// <summary>
        /// Evento para restringir el movimiento del mapa dentro de los límites definidos.
        /// </summary>
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
        /// <summary>
        /// Evento para cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento para mostrar el marker del restaurante seleccionado en el ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBoxMunicipios_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MostrarMarkerEnMapa();
        }

        /// <summary>
        /// Muestra el marker del restaurante seleccionado en el mapa.
        /// </summary>
        private void MostrarMarkerEnMapa()
        {
            if (cBoxMunicipios.SelectedValue is int selectedUserId)
            {
                // Obtener RestaurantInfo para este restaurante.
                var restaurantInfo = Models.RestaurantsOrm.GetRestaurantInfoList()
                    .FirstOrDefault(r => r.UserId == selectedUserId);

                if (restaurantInfo != null && restaurantInfo.Latitud.HasValue && restaurantInfo.Longitud.HasValue)
                {
                    double lat = restaurantInfo.Latitud.Value;
                    double lng = restaurantInfo.Longitud.Value;
                    PointLatLng punto = new PointLatLng(lat, lng);

                    // Eliminar cualquier marker previo.
                    overlayRestaurant.Markers.Clear();

                    // Crear un marker GMarkerGoogle.
                    GMapMarker marker = new GMarkerGoogle(punto, GMarkerGoogleType.red_dot);
                    // Asignar los datos al Tag para usarlos en el click.
                    marker.Tag = restaurantInfo;
                    // Asignar un ToolTip con la leyenda usando las cadenas de horario directamente.
                    marker.ToolTipText = $"Nombre: {restaurantInfo.Name}\nApertura: {restaurantInfo.OpeningTime ?? "No disponible"}\nCierre: {restaurantInfo.ClosingTime ?? "No disponible"}";

                    overlayRestaurant.Markers.Add(marker);

                    gMapControl1.Refresh();
                    gMapControl1.Invalidate();
                }
                else
                {
                    MessageBox.Show(Resources.Strings.msgCoordRestaurante, Resources.Strings.msgError, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        /// <summary>
        /// Evento para manejar el clic en un marker del mapa.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="e"></param>
        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (item.Tag is Models.RestaurantInfo info)
            {
                // Mostrar siempre el ToolTip al hacer clic.
                item.ToolTipMode = MarkerTooltipMode.Always;
                item.ToolTipText = $"📍 {info.Name}\n🕒 Apertura: {info.OpeningTime ?? "No disponible"} - Cierre: {info.ClosingTime ?? "No disponible"}";

                // Hacer zoom al marker.
                gMapControl1.Position = item.Position;
                gMapControl1.Zoom = 15;

                gMapControl1.Refresh();
            }
        }
    }
}
