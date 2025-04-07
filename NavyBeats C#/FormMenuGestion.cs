using System;
using System.Drawing;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormMenuGestion: Form
    {
        Super_User userLogin;

        public FormMenuGestion(Super_User user)
        {
            InitializeComponent();

            userLogin = user;

            ClickControles(panelSistema);
            ClickControles(panelLocal);
            ClickControles(panelArtista);
        }

        private void ClickControles(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                c.Click += (o, ev) => panel_Click(panel, ev);
            }
        }

        private void FormMenuGestion_Load(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(216, 255, 255, 255);
        }

        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_Click(object panel, EventArgs e)
        {
            if (panel == panelSistema)
            {
                if (userLogin.role.Equals("Super"))
                {
                    FormUsuarios usuarios = new FormUsuarios(userLogin);
                    usuarios.Show();

                    usuarios.FormClosed += (s, args) => this.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No tienes permiso para acceder a esta opción.");
                }
            }
            else
            {
                bool local = true;

                if (panel == panelArtista)
                {
                    local = false;
                }

                if (userLogin.role.Equals("Mantenimiento"))
                {
                    FormLocalMusico localMusico = new FormLocalMusico(local);
                    localMusico.Show();

                    localMusico.FormClosed += (s, args) => this.Show();
                    this.Hide();
                }
                else
                {
                    FormLocalMusicoSA localMusico = new FormLocalMusicoSA(local);
                    localMusico.Show();

                    localMusico.FormClosed += (s, args) => this.Show();
                    this.Hide();
                }
            }
        }
    }
}
