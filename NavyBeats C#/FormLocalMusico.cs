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

            AplicarTexto();

            if (local)
            {
                AsignarDataGridLocal();
            }
            else
            {
                AsignarDataGridMusico();
            }
        }

        // Configura el color de fondo
        private void FormLocalMusico_Load(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(216, 255, 255, 255);
        }

        // Cierra el form
        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Abre un form para modificar el usuario seleccionado
        private void customBotonModificar_Click(object sender, EventArgs e)
        {
            // Abre el FormInfoLocal
            if (local)
            {
                Restaurant user = RestauranteSeleccionado();
                created = false;

                FormInfoLocal modificar = new FormInfoLocal(user, created);

                if (modificar.ShowDialog() == DialogResult.OK)
                {
                    BindingDataGridViewRestaurante();
                }
            }
            // Abre el FormInfoMusico
            else
            {
                Musician user = MusicoSeleccionado();
                created = false;

                FormInfoMusico modificar = new FormInfoMusico(user, created);

                if (modificar.ShowDialog() == DialogResult.OK)
                {
                    BindingDataGridViewMusico();
                }
            }
        }

        // Aplica los textos localizados
        private void AplicarTexto()
        {
            customBotonModificar.Text = Resources.Strings.btnModificar;
        }

        // Asocia los datos dependiendo de si es Restaurante o Musico al DataGridView
        private void AsignarDataGridLocal()
        {
            dataGridView.DataSource = bindingSourceLocales;
            BindingDataGridViewRestaurante();

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

        private void AsignarDataGridMusico()
        {
            dataGridView.DataSource = bindingSourceMusicos;
            BindingDataGridViewMusico();

            dataGridView.Columns["user_id"].HeaderText = "Id";
            dataGridView.Columns["name"].HeaderText = "Nombre";
            dataGridView.Columns["email"].HeaderText = "Correo";
            dataGridView.Columns["password"].HeaderText = "Contraseña";
            dataGridView.Columns["phone_number"].HeaderText = "Tel.";
            dataGridView.Columns["municipality"].HeaderText = "Municipio";

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Asocia los datos dependiendo de si es Restaurante o Musico al DataGridView
        private void BindingDataGridViewRestaurante()
        {
            bindingSourceLocales.DataSource = UsuarioMovilOrm.SelectRestaurant();
        }

        private void BindingDataGridViewMusico()
        {
            bindingSourceMusicos.DataSource = UsuarioMovilOrm.SelectMusician();
        }

        // Obtiene el el usuario (dependiendo de lo necesario Restaurante, Musico o Usuario) seleccionado en el DataGridView
        private Restaurant RestauranteSeleccionado()
        {
            int id = SeleccionarFila();
            Restaurant user = UsuarioMovilOrm.SelectRestaurantById(id);

            return user;
        }

        private Musician MusicoSeleccionado()
        {
            int id = SeleccionarFila();
            Musician user = UsuarioMovilOrm.SelectMusicianById(id);

            return user;
        }

        // Selecciona la fila actual en el DataGridView y devuelve su ID
        private int SeleccionarFila()
        {
            int rowSelected = dataGridView.CurrentCell.RowIndex;
            int id = (int)dataGridView.Rows[rowSelected].Cells[0].Value;

            return id;
        }
    }
}
