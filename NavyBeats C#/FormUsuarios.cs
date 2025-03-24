using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormUsuarios: Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
            bindingSourceUsuarios.DataSource = UsuarioEscritorioOrm.SelectUsers();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
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

        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonRedondoCrear_Click(object sender, EventArgs e)
        {
            FormCrearUsusario crear = new FormCrearUsusario();
            crear.Show();
        }
    }
}
