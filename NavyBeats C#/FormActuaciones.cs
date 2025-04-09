using System;
using System.Drawing;
using System.Windows.Forms;

namespace NavyBeats_C_
{
    public partial class FormActuaciones : Form
    {
        public FormActuaciones()
        {
            InitializeComponent();
        }

        private void FormActuaciones_Load(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(216, 255, 255, 255);

            lblDiaSeleccionado.Text = Resources.Strings.lblDiaSeleccionado;
        }
    }
}