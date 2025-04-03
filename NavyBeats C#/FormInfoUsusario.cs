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
    public partial class FormInfoUsusario: Form
    {
        private Super_User _user;
        private bool _created;

        public FormInfoUsusario(Super_User user, bool created)
        {
            InitializeComponent();
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
                MessageBox.Show("No dejes campos vacíos.");
            }
            else
            {
                if (!psswd.Equals(confirm))
                {
                    MessageBox.Show("La contraseña no coincide.");
                }
                else
                {
                    Super_User newUser = new Super_User();
                    newUser.name = name;
                    newUser.email = email;
                    newUser.password = psswd;
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
                        save = UsuarioEscritorioOrm.Update(_user, newUser);

                        if (save)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    clearInfo();
                    this.Close();
                }
            }
        }

        private void clearInfo()
        {
            textBoxNombre.Texts = "";
            textBoxCorreo.Texts = "";
            textBoxContra.Texts = "";
            textBoxConfirmar.Texts = "";
            customComboBoxRol.Texts = "Rol";
        }
    }
}
