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
    public partial class FormLocalMusico: Form
    {
        public FormLocalMusico(bool local)
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

        private void FormLocalMusico_Load(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(216, 255, 255, 255);
        }

        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
