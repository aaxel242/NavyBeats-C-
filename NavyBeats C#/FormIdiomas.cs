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

            ClickControles(panelCatalan);
            ClickControles(panelEspañol);
            ClickControles(panelIngles);
        }

        private void ClickControles(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                c.Click += (o, ev) => panel_Click(panel, ev);
            }
        }

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

        private void AplicarTexto()
        {
            ManageString.CambiarIdioma();

            lblIdiomas.Text = Resources.Strings.lblSelecIdioma;
        }

        private void FormIdiomas_Load(object sender, EventArgs e)
        {
            panelIdiomas.BackColor = Color.FromArgb(216, 255, 255, 255);
        }

        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
