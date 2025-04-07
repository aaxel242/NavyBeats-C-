using System;
using System.Drawing;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormLogin: Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(216, 255, 255, 255);
        }

        private void botonRedondoLogin_Click(object sender, EventArgs e)
        {       
            Super_User user = UsuarioEscritorioOrm.SelectLogin("laura.rodriguez@maintenance.net", "password123");
            //"saramant@politecnics.barcelona", "1234" MANTENIMIENTO
            //"jcampsv2324@politecnics.barcelona", "1234" SUPERUSER
            //textBoxCorreo.Texts.Trim(), textBoxContra.Texts.Trim()
            if (user != null)
            {
                textBoxCorreo.Texts = "";
                textBoxContra.Texts = "";

                FormMenu menu = new FormMenu(user);
                menu.Show();

                menu.FormClosed += (s, args) => this.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto");
                textBoxContra.Texts = "";
            }
        }
    }
}
