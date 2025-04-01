using System;
using System.Drawing;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormLocalMusicoSA: Form
    {
        public FormLocalMusicoSA(bool local)
        {
            InitializeComponent();

            if (local)
            {
                bindingSourceMusicos.DataSource = MusicoOrm.SelectMusician();
            }
        }

        private void FormLocalMusicoSA_Load(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(216, 255, 255, 255);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
