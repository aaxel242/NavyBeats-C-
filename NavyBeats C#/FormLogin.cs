using System;
using System.Drawing;
using System.Windows.Forms;
using NavyBeats_C_.Entitites;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // Configura el color del panel.
        private void FormLogin_Load(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(216, 255, 255, 255);
        }

        // Maneja el clic en el botón de login y encripta la contraseña
        private void botonRedondoLogin_Click(object sender, EventArgs e)
        {
            string contra = Encrypt.Encriptar(textBoxContra.Texts.Trim());
            Super_User user = UsuarioEscritorioOrm.SelectLogin(textBoxCorreo.Texts.Trim(), contra);

            if (user != null)
            {
                textBoxCorreo.Texts = "";
                textBoxContra.Texts = "";

                FormMenu menu = new FormMenu(user);
                menu.Show();

                menu.FormClosed += (s, args) =>
                {
                    this.Show();
                    AplicarTexto();
                };
                this.Hide();
            }
            else
            {
                MessageBox.Show(Resources.Strings.msgUsuarioContra);
                textBoxContra.Texts = "";
            }
        }

        // Maneja el clic en las imágenes de cambio de idioma
        private void imageClick(object sender, EventArgs e)
        {
            if (sender == pictureBoxCatalan)
            {
                ManageString.idioma = "ca";
            }
            else if (sender == pictureBoxIngles)
            {
                ManageString.idioma = "en";
            }
            else
            {
                ManageString.idioma = "es";
            }

            AplicarTexto();
        }

        // Aplica textos localizados del form
        private void AplicarTexto()
        {
            ManageString.CambiarIdioma();

            labelCorreo.Text = Resources.Strings.lblCorreo;
            labelContra.Text = Resources.Strings.lblContra;
            customBotonLogin.Text = Resources.Strings.btnEntrar;
        }
    }
}
