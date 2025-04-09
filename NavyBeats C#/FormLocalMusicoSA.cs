using System;
using System.Drawing;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormLocalMusicoSA: Form
    {
        bool local;
        bool created;

        public FormLocalMusicoSA(bool _local)
        {
            InitializeComponent();

            customBotonCrear.Text = Resources.Strings.btnCrear;
            customBotonModificar.Text = Resources.Strings.btnModificar;
            customBotonEliminar.Text = Resources.Strings.btnEliminar;

            local = _local;

            if (local)
            {
                dataGridView.DataSource = bindingSourceLocales;
                bindingSourceLocales.DataSource = UsuarioMovilOrm.SelectRestaurant();

                dataGridView.Columns["user_id"].HeaderText = "Id";
                dataGridView.Columns["name"].HeaderText = "Nombre";
                dataGridView.Columns["email"].HeaderText = "Correo";
                dataGridView.Columns["password"].HeaderText = "Contraseña";
                dataGridView.Columns["phone_number"].HeaderText = "Tel.";
                dataGridView.Columns["municipality"].HeaderText = "Municipio";
                dataGridView.Columns["latitud"].HeaderText = "Latitud";
                dataGridView.Columns["longitud"].HeaderText = "Longitud";
                dataGridView.Columns["opening_time"].HeaderText = "Apertura";
                dataGridView.Columns["closing_time"].HeaderText = "Cierre";

                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            }
            else
            {
                dataGridView.DataSource = bindingSourceMusicos;
                bindingSourceMusicos.DataSource = UsuarioMovilOrm.SelectMusician();

                dataGridView.Columns["user_id"].HeaderText = "Id";
                dataGridView.Columns["name"].HeaderText = "Nombre";
                dataGridView.Columns["email"].HeaderText = "Correo";
                dataGridView.Columns["password"].HeaderText = "Contraseña";
                dataGridView.Columns["phone_number"].HeaderText = "Tel.";
                dataGridView.Columns["municipality"].HeaderText = "Municipio";

                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void FormLocalMusicoSA_Load(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(216, 255, 255, 255);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonRedondoCrear_Click(object sender, EventArgs e)
        {
            if (local)
            {
                Restaurant user = new Restaurant();
                created = true;

                FormInfoLocal crear = new FormInfoLocal(user, created);

                if (crear.ShowDialog() == DialogResult.OK)
                {
                    bindingSourceLocales.DataSource = UsuarioMovilOrm.SelectRestaurant();
                }
            }
            else
            {
                Musician user = new Musician();
                created = true;

                FormInfoMusico crear = new FormInfoMusico(user, created);

                if (crear.ShowDialog() == DialogResult.OK)
                {
                    bindingSourceMusicos.DataSource = UsuarioMovilOrm.SelectMusician();
                }
            }
        }

        private void customBotonModificar_Click(object sender, EventArgs e)
        {
            if (local)
            {
                Restaurant user = restauranteSeleccionado();
                created = false;

                FormInfoLocal modificar = new FormInfoLocal(user, created);

                if (modificar.ShowDialog() == DialogResult.OK)
                {
                    bindingSourceLocales.DataSource = UsuarioMovilOrm.SelectRestaurant();
                }
            }
            else
                {
                Musician user = musicoSeleccionado();
                created = false;

                FormInfoMusico modificar = new FormInfoMusico(user, created);

                if (modificar.ShowDialog() == DialogResult.OK)
                {
                    bindingSourceMusicos.DataSource = UsuarioMovilOrm.SelectMusician();
                }
            }
        }

        private void botonRedondoEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(Resources.Strings.msgEliminar, Resources.Strings.msgConfirmar, MessageBoxButtons.YesNo);
            bool delete = false;

            if (confirm == DialogResult.Yes)
            {
                Users user = usuarioSeleccionado();

                delete = UsuarioMovilOrm.Delete(user);
            }

            if (delete)
            {
                if (local)
                {
                    bindingSourceLocales.DataSource = UsuarioMovilOrm.SelectRestaurant();

                }
                else
                {
                    bindingSourceMusicos.DataSource = UsuarioMovilOrm.SelectMusician();
                }
            }
        }

        private Users usuarioSeleccionado()
        {
            int rowSelected = dataGridView.CurrentCell.RowIndex;
            int id = (int)dataGridView.Rows[rowSelected].Cells[0].Value;
            Users user = UsuarioMovilOrm.SelectUserById(id);

            return user;
        }

        private Musician musicoSeleccionado()
        {
            int rowSelected = dataGridView.CurrentCell.RowIndex;
            int id = (int)dataGridView.Rows[rowSelected].Cells[0].Value;
            Musician user = UsuarioMovilOrm.SelectMusicianById(id);

            return user;
        }

        private Restaurant restauranteSeleccionado()
        {
            int rowSelected = dataGridView.CurrentCell.RowIndex;
            int id = (int)dataGridView.Rows[rowSelected].Cells[0].Value;
            Restaurant user = UsuarioMovilOrm.SelectRestaurantById(id);

            return user;
        }
    }
}
