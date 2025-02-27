using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavyBeats_C_
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            // Centrar el formulario
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            int formWidth = this.Width;
            int formHeight = this.Height;

            int positionX = (screenWidth - formWidth) / 2;
            int positionY = (screenHeight - formHeight) / 2;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(positionX, positionY);
            
            PrivateFontCollection fonts = new PrivateFontCollection();
            fonts.AddFontFile("Resources\\Fonts\\Montserrat-Regular.ttf");

            lblCerrarSesion.Font = new Font(fonts.Families[0], 8, FontStyle.Bold);
            lblGestionUsuarios.Font = new Font(fonts.Families[0], 18, FontStyle.Bold);
            lblNotificaciones.Font = new Font(fonts.Families[0], 18, FontStyle.Bold);
            lblCalendario.Font = new Font(fonts.Families[0], 18, FontStyle.Bold);
            lblInformesYEstadisticas.Font = new Font(fonts.Families[0], 18, FontStyle.Bold);    
            lblMapa.Font = new Font(fonts.Families[0], 18, FontStyle.Bold);
            lblCambiarIdioma.Font = new Font(fonts.Families[0], 18, FontStyle.Bold); 
            lblRegistro.Font = new Font(fonts.Families[0], 18, FontStyle.Bold);
            lblSoporteTecnico.Font = new Font(fonts.Families[0], 18, FontStyle.Bold);       

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }

        private void pbAtras_Click(object sender, EventArgs e)
        {

        }
    }
}
