using System;
using System.Drawing;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormMenu : Form
    {
        Super_User userLogin;

        public FormMenu(Super_User user)
        {
            InitializeComponent();

            AplicarTexto();

            ClickControles(panelUsuarios);
            ClickControles(panelNotificaciones);
            ClickControles(panelCalendario);
            ClickControles(panelMapa);
            ClickControles(panelIdioma);
            ClickControles(panelSoporte);

            userLogin = user;
        }

        private void AplicarTexto()
        {
            lblGestionUsuarios.Text = Resources.Strings.lblGestion;
            lblNotificaciones.Text = Resources.Strings.lblNoti;
            lblCalendario.Text = Resources.Strings.lblCalendario;
            lblMapa.Text = Resources.Strings.lblMapa;
            lblCambiarIdioma.Text = Resources.Strings.lblIdioma;
            lblSoporteTecnico.Text = Resources.Strings.lblSoporte;
        }

        private void ClickControles(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                c.Click += (o, ev) => panel_Click(panel, ev);
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(216, 255, 255, 255);
        }

        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_Click(object panel, EventArgs e)
        {
            if (panel == panelUsuarios)
            {
                FormMenuGestion menuGestion = new FormMenuGestion(userLogin);
                menuGestion.Show();

                menuGestion.FormClosed += (s, args) => this.Show();
                this.Hide();
            }
            else if (panel == panelNotificaciones)
            {
                FormNotificaciones notificaciones = new FormNotificaciones(userLogin.user_id_admin);
                notificaciones.Show();

                notificaciones.FormClosed += (s, args) => this.Show();
                this.Hide();
            }
            else if (panel == panelCalendario)
            {
                FormCalendario calendario = new FormCalendario();
                calendario.Show();

                calendario.FormClosed += (s, args) => this.Show();
                this.Hide();
            }
            else if (panel == panelMapa)
            {
                FormMapaMenu mapa = new FormMapaMenu();
                mapa.Show();

                mapa.FormClosed += (s, args) => this.Show();
                this.Hide();
            }
            else if (panel == panelIdioma)
            {
                FormIdiomas idiomas = new FormIdiomas();
                idiomas.Show();

                idiomas.FormClosed += (s, args) =>
                {
                    this.Show();
                    AplicarTexto();
                };
                this.Hide();
            }
            else if (panel == panelSoporte)
            {
                FormSoporte soporte = new FormSoporte(userLogin);
                soporte.Show();

                soporte.FormClosed += (s, args) => this.Show();
                this.Hide();
            }
        }
    }
}
