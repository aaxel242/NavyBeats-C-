using System;
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

            AplicarTexto();
            ConfigurarComboBox();

            if (!created)
            {
                AplicarInfo(restaurant);
            }
        }

        // Cierra el form
        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Guarda la información del restaurante
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
                    Users newUser = new Users();
                    newUser.name = name;
                    newUser.phone_number = phone.ToString();
                    newUser.email = email;
                    newUser.municipality_id = municipaly.municipality_id;
                    newUser.password = Encrypt.Encriptar(psswd);
                    newUser.latitud = latitud;
                    newUser.longitud = longitud;
                    newUser.creation_date = DateTime.Today.ToString();
                    newUser.edition_date = DateTime.Today.ToString();

                    // Si estan creado el restaurante
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
                    // Si el restaurante esta siendo editado
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

        // Aplica los textos localizados
        private void AplicarTexto()
        {
            labelNombre.Text = Resources.Strings.lblNombre;
            labelCorreo.Text = Resources.Strings.lblCorreo;
            labelContra.Text = Resources.Strings.lblContra;
            labelConf.Text = Resources.Strings.lblConfContra;
            labelTel.Text = Resources.Strings.lblTel;
            labelMunicipio.Text = Resources.Strings.lblMunicipio;
            labelLongitud.Text = Resources.Strings.lblLongitud;
            labelLatitud.Text = Resources.Strings.lblLatitud;
            labelApertura.Text = Resources.Strings.lblApertura;
            labelCierre.Text = Resources.Strings.lblCierre;
            botonRedondoGuardar.Text = Resources.Strings.btnGuardar;
        }

        // Configura el comboBox de los municipios
        private void ConfigurarComboBox()
        {
            customComboBoxMunicipio.DataSource = MunicipiosOrm.Select();
            customComboBoxMunicipio.DisplayMember = "name";
            customComboBoxMunicipio.ValueMember = "municipality_id";
            customComboBoxMunicipio.SelectedIndex = -1;
        }

        // Rellena el form con la información del restaurante
        private void AplicarInfo(Restaurant restaurant)
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
}