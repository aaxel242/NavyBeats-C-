using System;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormInfoUsusario: Form
    {
        private Super_User _user;
        private bool _created;

        public FormInfoUsusario(Super_User user, bool created)
        {
            InitializeComponent();

            _user = user;
            _created = created;

            AplicarTexto();

            if (!created)
            {
                AplicarInfo(user);
            }
        }

        // Cierra el form
        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Guarda la información del usuario
        private void botonRedondoGuardar_Click(object sender, EventArgs e)
        {
            string name = textBoxNombre.Texts.Trim();
            string email = textBoxCorreo.Texts.Trim();
            string psswd = textBoxContra.Texts.Trim();
            string confirm = textBoxConfirmar.Texts.Trim();
            string role = customComboBoxRol.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(psswd) || string.IsNullOrEmpty(confirm) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show(Resources.Strings.msgCompleta);
            }
            else
            {
                if (!psswd.Equals(confirm))
                {
                    MessageBox.Show(Resources.Strings.msgContra);
                }
                else
                {
                    Super_User newUser = new Super_User();
                    newUser.name = name;
                    newUser.email = email;
                    newUser.password = Encrypt.Encriptar(psswd);
                    newUser.role = role;

                    bool save = false;

                    // Si el usuario esta siendo creado
                    if (_created)
                    {
                        save = UsuarioEscritorioOrm.Insert(newUser);

                        if (save)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    // Si el usuario esta siendo editado
                    else
                    {
                        save = UsuarioEscritorioOrm.Update(_user, newUser);

                        if (save)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    this.Close();
                }
            }
        }

        // Aplica los textos localizados
        private void AplicarTexto()
        {
            labelNombre.Text = Resources.Strings.lblNombre;
            labelCorreo.Text = Resources.Strings.lblCorreo;
            labelContra.Text = Resources.Strings.lblContra;
            labelConf.Text = Resources.Strings.lblConfContra;
            customComboBoxRol.Text = Resources.Strings.lblRol;
            botonRedondoGuardar.Text = Resources.Strings.btnGuardar;
        }

        // Rellena el form con la información del usuario
        private void AplicarInfo(Super_User user)
        {
            textBoxNombre.Texts = user.name;
            textBoxCorreo.Texts = user.email;
            textBoxContra.Texts = user.password;
            textBoxConfirmar.Texts = user.password;
            customComboBoxRol.SelectedItem = user.role;
        }
    }
}
