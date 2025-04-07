using System;
using System.Drawing;
using System.Windows.Forms;

namespace NavyBeats_C_
{
    public partial class FormIdiomas: Form
    {
        public FormIdiomas()
        {
            InitializeComponent();
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
