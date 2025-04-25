using System;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Collections.Generic;

namespace NavyBeats_C_
{
    public partial class FormMapaMenu : Form
    {
        // Limites de Cataluña.
        private readonly double minLat = 40.5;  
        private readonly double maxLat = 42.9;  
        private readonly double minLng = 0.15; 
        private readonly double maxLng = 3.33;


        public FormMapaMenu()
        {
            InitializeComponent();

            labelDispoMusico.Text = Resources.Strings.lblDispoMusico;
            labelVisualizar.Text = Resources.Strings.lblVisuLocales;
        }
        /// <summary>
        /// Método que se ejecuta al cargar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMapaMenu_Load(object sender, EventArgs e)
        {
            panelMapa.BackColor = Color.FromArgb(216, 255, 255, 255);

            // Configuraciones iniciales del formulario.
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Configuración de imágenes.
            Image imgMusicoOriginal = Properties.Resources.imgArtista;
            Image imgMusico = new Bitmap(imgMusicoOriginal, new Size(121, 140));
            Image imgLocalOriginal = Properties.Resources.Local;
            Image imgLocal = new Bitmap(imgLocalOriginal, new Size(127, 140));

            btnMusicoMapa.Image = imgMusico;
            btnLocalMapa.Image = imgLocal;

            // Configuración del mapa.
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.ShowCenter = false;
            gMapControl1.IgnoreMarkerOnMouseWheel = false;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;

            // Seleccionar Google Maps como proveedor.
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            // Posición inicial en el centro de Barcelona.
            gMapControl1.Position = new PointLatLng(41.3851, 2.1734);

            // Configuración de zoom.
            gMapControl1.MinZoom = 6;
            gMapControl1.MaxZoom = 18;
            gMapControl1.Zoom = 8;

        
        }

        /// <summary>
        /// Abre el mapa de los locales.
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
        /// Abre el mapa de los músicos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMusicoMapa_Click(object sender, EventArgs e)
        {
            using (FormMapaArtistas formMapaArtistas = new FormMapaArtistas())
            {
                this.Hide();
                formMapaArtistas.ShowDialog();
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
