using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using NavyBeats_C_.Entitites;

namespace NavyBeats_C_
{
    public partial class FormIdiomas: Form
    {
        public FormIdiomas()
        {
            InitializeComponent();

            AplicarTexto();
            ClickPanel();
        }

        /// <summary>
        /// Configura el color de fondo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormIdiomas_Load(object sender, EventArgs e)
        {
            panelIdiomas.BackColor = Color.FromArgb(216, 255, 255, 255);
        }

        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Maneja el clic en los paneles, cambiando el idioma
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="e"></param>
        private void panel_Click(object panel, EventArgs e)
        {
            if (panel == panelCatalan)
            {
                ManageString.idioma = "ca";
            }
            else if (panel == panelIngles)
            {
                ManageString.idioma = "en";
            }
            else
            {
                ManageString.idioma = "es";
            }

            AplicarTexto();
        }

        /// <summary>
        /// Aplica los textos localizados
        /// </summary>
        private void AplicarTexto()
        {
            ManageString.CambiarIdioma();

            lblIdiomas.Text = Resources.Strings.lblSelecIdioma;
        }

        /// <summary>
        /// Configura los controles de los paneles para que respondan al clic
        /// </summary>
        private void ClickPanel()
        {
            ClickControles(panelCatalan);
            ClickControles(panelEspañol);
            ClickControles(panelIngles);
        }

        /// <summary>
        /// Asocia el evento de clic a cada control dentro de un panel
        /// </summary>
        /// <param name="panel"></param>
        private void ClickControles(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                c.Click += (o, ev) => panel_Click(panel, ev);
            }
        }
    }
}
