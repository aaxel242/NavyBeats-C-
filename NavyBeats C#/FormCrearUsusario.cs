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
    public partial class FormCrearUsusario: Form
    {
        public FormCrearUsusario()
        {
            InitializeComponent();
        }

        private void FormCrear_Load(object sender, EventArgs e)
        {
            customComboBoxRol.Items.Add("Super");
            customComboBoxRol.Items.Add("Admin");
            customComboBoxRol.Items.Add("Mantenimiento");
        }

        private void botonRedondoEntrar_Click(object sender, EventArgs e)
        {
            string name = textBoxNombre.Texts.Trim();
            string email = textBoxCorreo.Texts.Trim();
            string psswd = textBoxContra.Texts.Trim();
            string confirm = textBoxConfirmar.Texts.Trim();
            string role = customComboBoxRol.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(psswd) || string.IsNullOrEmpty(confirm) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Completa todos los campos.");
            }
            else
            {
                if (psswd.Equals(confirm))
                {
                    Super_User user = new Super_User();
                    user.name = name;
                    user.email = email;
                    user.password = psswd;
                    user.role = role;

                    clearInfo();
                    bool insert = UsuarioEscritorioOrm.Insert(user);
                    
                    if (insert)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
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
