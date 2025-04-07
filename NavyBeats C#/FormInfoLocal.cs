﻿using System;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormInfoLocal: Form
    {
        private Users _user;
        private Restaurant _restaurant;
        private bool _created;
        public FormInfoLocal(Restaurant restaurant, bool created)
        {
            InitializeComponent();

            _restaurant = restaurant;
            _created = created;

            customComboBoxMunicipio.DataSource = MunicipiosOrm.Select();
            customComboBoxMunicipio.DisplayMember = "name";
            customComboBoxMunicipio.ValueMember = "municipality_id";
            customComboBoxMunicipio.SelectedIndex = -1;

            if (!created)
            {
                _user = UsuarioMovilOrm.SelectUserById(restaurant.user_id);
                Municipality municipio = MunicipiosOrm.SelectById(_user.municipality_id);

                textBoxNombre.Texts = _user.name;
                textBoxTelefono.Texts = _user.phone_number.ToString();
                textBoxCorreo.Texts = _user.email;
                customComboBoxMunicipio.SelectedIndex = municipio.municipality_id - 1;
                textBoxContra.Texts = _user.password;
                textBoxConfirmar.Texts = _user.password;
                textBoxLongitud.Texts = _user.longitud.ToString();
                textBoxLatitud.Texts = _user.latitud.ToString();
                textBoxApertura.Texts = _restaurant.opening_time;
                textBoxCierre.Texts = _restaurant.closing_time;
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
            string openingTime = textBoxApertura.Texts.Trim();
            string closingTime = textBoxCierre.Texts.Trim();

            bool validPhone = int.TryParse(textBoxTelefono.Texts.Trim(), out phone);
            bool validLatitud = decimal.TryParse(textBoxLatitud.Texts.Trim(), out latitud);
            bool validLongitud = decimal.TryParse(textBoxLongitud.Texts.Trim(), out longitud);

            if (string.IsNullOrEmpty(name) || !validPhone || phone < 0 || string.IsNullOrEmpty(email) || municipaly == null ||
                string.IsNullOrEmpty(psswd) || string.IsNullOrEmpty(confirm) || municipaly == null || !validLatitud || latitud == null
                || !validLongitud || longitud == null || string.IsNullOrEmpty(openingTime) || string.IsNullOrEmpty(closingTime))
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
                        Restaurant newRestaurant = new Restaurant();
                        newRestaurant.user_id = _id;
                        newRestaurant.opening_time = openingTime;
                        newRestaurant.closing_time = closingTime;

                        bool save = false;

                        save = UsuarioMovilOrm.InsertRestaurant(newRestaurant);

                        if (save)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        int _id = UsuarioMovilOrm.UpdateUser(_user, newUser);
                        Restaurant newRestaurant = new Restaurant();
                        newRestaurant.user_id = _id;
                        newRestaurant.opening_time = openingTime;
                        newRestaurant.closing_time = closingTime;

                        bool save = false;

                        save = UsuarioMovilOrm.UpdateRestaurant(_restaurant, newRestaurant);

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