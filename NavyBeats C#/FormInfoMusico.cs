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

            AplicarTexto();
            ConfigurarComboBox();
            ConfigurarListBox();

            if (!created)
            {
                AplicarInfo(musician);
            }
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
        /// Guarda la información del músico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            // Variables para poder validar que el campo esta completo
            bool validPhone = int.TryParse(textBoxTelefono.Texts.Trim(), out phone);
            bool validLatitud = decimal.TryParse(textBoxLatitud.Texts.Trim(), out latitud);
            bool validLongitud = decimal.TryParse(textBoxLongitud.Texts.Trim(), out longitud);

            if (string.IsNullOrEmpty(name) || !validPhone || phone <0 || string.IsNullOrEmpty(email) || municipaly == null ||
                string.IsNullOrEmpty(psswd) || string.IsNullOrEmpty(confirm) || municipaly == null || !validLatitud || latitud == null || !validLongitud || longitud == null)
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

                    // Si el músico esta siendo creado
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
                    // Si el músico esta siendo editado
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

        /// <summary>
        /// Aplica los textos localizados
        /// </summary>
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
            labelEstilos.Text = Resources.Strings.lblEstilos;
            botonRedondoGuardar.Text = Resources.Strings.btnGuardar;
        }

        /// <summary>
        /// Configura el comboBox de los municipios
        /// </summary>
        private void ConfigurarComboBox()
        {
            customComboBoxMunicipio.DataSource = MunicipiosOrm.Select();
            customComboBoxMunicipio.DisplayMember = "name";
            customComboBoxMunicipio.ValueMember = "municipality_id";
            customComboBoxMunicipio.SelectedIndex = -1;
        }

        /// <summary>
        /// Configura el listBox de los municipios
        /// </summary>
        private void ConfigurarListBox()
        {
            listBoxEstilos.DataSource = EstilosOrm.Select();
            listBoxEstilos.DisplayMember = "name";
            listBoxEstilos.ValueMember = "style_id";
            listBoxEstilos.SelectedIndex = -1;
        }

        /// <summary>
        /// Rellena el form con la información del músico
        /// </summary>
        /// <param name="musician"></param>
        private void AplicarInfo(Musician musician)
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
}