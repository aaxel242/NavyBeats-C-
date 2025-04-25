using System;
using System.Drawing;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormMenuGestion : Form
    {
        Super_User userLogin;

        public FormMenuGestion(Super_User user)
        {
            InitializeComponent();

            userLogin = user;

            AplicarTexto();
            ClickPanel();
        }

        /// <summary>
        /// Configura el color de fondo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMenuGestion_Load(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(216, 255, 255, 255);
        }

        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Maneja el clic en los paneles, abriendo diferentes forms
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="e"></param>
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
                    MessageBox.Show(Resources.Strings.msgPermiso);
                }
            }
            else
            {
                bool local = true;
                if (panel == panelArtista) local = false;

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

        /// <summary>
        /// Aplica los textos localizados
        /// </summary>
        private void AplicarTexto()
        {
            labelArtista.Text = Resources.Strings.lblMusico;
            labelLocal.Text = Resources.Strings.lblLocal;
            labelUsuario.Text = Resources.Strings.lblUsuario;
        }

        /// <summary>
        /// Configura los controles de los paneles para que respondan al clic
        /// </summary>
        private void ClickPanel()
        {
            ClickControles(panelSistema);
            ClickControles(panelLocal);
            ClickControles(panelArtista);
        }

        /// <summary>
        /// Asocia el evento de clic a cada control dentro de un panel
        /// </summary>
        /// <param name="panel"></param>
        private void ClickControles(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                c.Click += (o, ev) => panel_Click(panel, ev);
            }
        }
    }
}
