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
            dataGridView.Rows.Add(new object[] { "Mohamed", "Bar los porrillos", "20:00-23:00", "50€" });
            dataGridView.Rows.Add(new object[] { "Mohamed", "Bar los porrillos", "20:00-23:00", "50€" });
            dataGridView.Rows.Add(new object[] { "Mohamed", "Bar los porrillos", "20:00-23:00", "50€" });

            panel.BackColor = Color.FromArgb(216, 255, 255, 255);

            // Centrar el formulario
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            int formWidth = this.Width;
            int formHeight = this.Height;

            int positionX = (screenWidth - formWidth) / 2;
            int positionY = (screenHeight - formHeight) / 2;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(positionX, positionY);
        }
    }
}
