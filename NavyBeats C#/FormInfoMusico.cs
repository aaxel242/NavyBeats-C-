using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormInfoMusico: Form
    {
        private Users _user;
        private Musician _musician;
        private bool _created;

        public FormInfoMusico(Musician musician, bool created)
        {
            InitializeComponent();

            _musician = musician;
            _created = created;

            customComboBoxMunicipio.DataSource = MunicipiosOrm.Select();
            customComboBoxMunicipio.DisplayMember = "name";
            customComboBoxMunicipio.ValueMember = "municipality_id";
            customComboBoxMunicipio.SelectedIndex = -1;

            listBoxEstilos.DataSource = EstilosOrm.Select();
            listBoxEstilos.DisplayMember = "name";
            listBoxEstilos.ValueMember = "style_id";
            listBoxEstilos.SelectedIndex = -1;

            if (!created)
            {
                _user = UsuarioMovilOrm.SelectUserById(musician.user_id);
                Municipality municipio = MunicipiosOrm.SelectById(_user.municipality_id);

                textBoxNombre.Texts = _user.name;
                textBoxTelefono.Texts = _user.phone_number.ToString();
                textBoxCorreo.Texts = _user.email;
                textBoxCorreo.Texts = _user.email;
                customComboBoxMunicipio.SelectedIndex = municipio.municipality_id - 1;
                textBoxContra.Texts = _user.password;
                textBoxConfirmar.Texts = _user.password;
                textBoxLongitud.Texts = _user.longitud.ToString();
                textBoxLatitud.Texts = _user.latitud.ToString();

                foreach (User_Style _style in musician.User_Style)
                {
                    for (int i = 0; i < listBoxEstilos.Items.Count; i++)
                    {
                        if (((Style)listBoxEstilos.Items[i]).style_id == _style.style_id)
                        {
                            listBoxEstilos.SetSelected(i, true);
                        }
                    }
                }
            }
        }

        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonRedondoGuardar_Click(object sender, EventArgs e)
        {
            string name = textBoxNombre.Texts.Trim();
            int phone;
            string email = textBoxCorreo.Texts.Trim();
            Municipality municipaly = (Municipality)customComboBoxMunicipio.SelectedItem;
            string psswd = textBoxContra.Texts.Trim();
            string confirm = textBoxConfirmar.Texts.Trim();
            decimal latitud;
            decimal longitud;
            List<Style> styles = listBoxEstilos.SelectedItems.Cast<Style>().ToList();

            bool validPhone = int.TryParse(textBoxTelefono.Texts.Trim(), out phone);
            bool validLatitud = decimal.TryParse(textBoxLatitud.Texts.Trim(), out latitud);
            bool validLongitud = decimal.TryParse(textBoxLongitud.Texts.Trim(), out longitud);

            if (string.IsNullOrEmpty(name) || !validPhone || phone <0 || string.IsNullOrEmpty(email) || municipaly == null ||
                string.IsNullOrEmpty(psswd) || string.IsNullOrEmpty(confirm) || municipaly == null || !validLatitud || latitud == null || !validLongitud || longitud == null)
            {
                MessageBox.Show("Completa todos los campos correctamente.");
            }
            else
            {
                if (!psswd.Equals(confirm))
                {
                    MessageBox.Show("La contraseña no coincide.");
                }
                else
                {
                    Users newUser = new Users();
                    newUser.name = name;
                    newUser.phone_number = phone.ToString();
                    newUser.email = email;
                    newUser.municipality_id = municipaly.municipality_id;
                    newUser.password = psswd;
                    newUser.latitud = latitud;
                    newUser.longitud = longitud;
                    newUser.creation_date = DateTime.Today.ToString();
                    newUser.edition_date = DateTime.Today.ToString();

                    if (_created)
                    {
                        int _id = UsuarioMovilOrm.InsertUser(newUser);
                        Musician newMusician = new Musician();
                        newMusician.user_id = _id;

                        newMusician.User_Style = styles.Select(style => new User_Style
                        {
                            user_id = newMusician.user_id,
                            style_id = style.style_id,
                            creation_date = DateTime.Now
                        }).ToList();
                        bool save = false;
                        
                        save = UsuarioMovilOrm.InsertMusician(newMusician, styles);

                        if (save)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        int _id = UsuarioMovilOrm.UpdateUser(_user, newUser);
                        Musician newMusician = new Musician();
                        newMusician.user_id = _id;

                        newMusician.User_Style = styles.Select(style => new User_Style
                        {
                            user_id = newMusician.user_id,
                            style_id = style.style_id,
                            creation_date = DateTime.Now
                        }).ToList();
                        bool save = false;
                        
                        save = UsuarioMovilOrm.UpdateMusician(_musician, newMusician, styles);

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