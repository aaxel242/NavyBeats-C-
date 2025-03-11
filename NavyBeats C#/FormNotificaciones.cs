using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavyBeats_C_
{
    public partial class FormNotificaciones: Form
    {
        public FormNotificaciones()
        {
            InitializeComponent();
        }

        private void FormNotificaciones_Load(object sender, EventArgs e)
        {
            panelNotificaciones.BackColor = Color.FromArgb(216, 255, 255, 255);
            AplicarEsquinasRedondeadas(panelNotificaciones2, 30);

        }

        private void AplicarEsquinasRedondeadas(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            // Esquina superior izquierda (redondeada)
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90);

            // Línea superior
            path.AddLine(radio, 0, panel.Width - radio, 0);

            // Esquina superior derecha (redondeada)
            path.AddArc(panel.Width - radio * 2, 0, radio * 2, radio * 2, 270, 90);

            // Línea derecha
            path.AddLine(panel.Width, radio, panel.Width, panel.Height - radio);

            // Esquina inferior derecha (redondeada)
            path.AddArc(panel.Width - radio * 2, panel.Height - radio * 2, radio * 2, radio * 2, 0, 90);

            // Línea inferior
            path.AddLine(panel.Width - radio, panel.Height, radio, panel.Height);

            // Esquina inferior izquierda (redondeada)
            path.AddArc(0, panel.Height - radio * 2, radio * 2, radio * 2, 90, 90);

            // Línea izquierda
            path.AddLine(0, panel.Height - radio, 0, radio);

            path.CloseFigure();
            panel.Region = new Region(path);
        }

    }
}
