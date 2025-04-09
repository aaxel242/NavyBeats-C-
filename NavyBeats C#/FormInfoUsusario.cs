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

            labelNombre.Text = Resources.Strings.lblNombre;
            labelCorreo.Text = Resources.Strings.lblCorreo;
            labelContra.Text = Resources.Strings.lblContra;
            labelConf.Text = Resources.Strings.lblConfContra;
            customComboBoxRol.Text = Resources.Strings.lblRol;
            botonRedondoGuardar.Text = Resources.Strings.btnGuardar;

            _user = user;
            _created = created;

            if (!created)
            {
                textBoxNombre.Texts = user.name;
                textBoxCorreo.Texts = user.email;
                textBoxContra.Texts = user.password;
                textBoxConfirmar.Texts = user.password;
                customComboBoxRol.SelectedItem = user.role;
            }
        }

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

                    if (_created)
                    {
                        save = UsuarioEscritorioOrm.Insert(newUser);

                        if (save)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        save = UsuarioEscritorioOrm.Upadate(_user, newUser);

                        if (save)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    this.Close();
                }
            }
        }
    }
}
