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
using static MetroFramework.Drawing.MetroPaint;

namespace NavyBeats_C_
{
    public partial class FormSoporte : Form
    {
        public FormSoporte()
        {
            InitializeComponent();
        }

        private void FormSoporte_Load(object sender, EventArgs e)
        {
            AplicarEsquinasRedondeadas(panelFormulario, 30);
        }




















        private void AplicarEsquinasRedondeadas(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90);
            path.AddArc(panel.Width - (radio * 2), 0, radio * 2, radio * 2, 270, 90);
            path.AddArc(panel.Width - (radio * 2), panel.Height - (radio * 2), radio * 2, radio * 2, 0, 90);
            path.AddArc(0, panel.Height - (radio * 2), radio * 2, radio * 2, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }
    }
}
