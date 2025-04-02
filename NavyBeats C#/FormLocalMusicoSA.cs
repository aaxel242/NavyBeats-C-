using System;
using System.Drawing;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormLocalMusicoSA: Form
    {
        public FormLocalMusicoSA(bool local)
        {
            InitializeComponent();

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
    }
}
