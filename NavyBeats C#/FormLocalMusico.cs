using System;
using System.Drawing;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormLocalMusico: Form
    {
        bool local;
        bool created;
        public FormLocalMusico(bool _local)
        {
            InitializeComponent();

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

        private void FormLocalMusico_Load(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(216, 255, 255, 255);
        }

        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
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
