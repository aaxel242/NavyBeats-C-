using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormUsuarios : Form
    {
        Super_User userLogin;
        private Timer filterTimer;
        bool created;

        public FormUsuarios(Super_User user)
        {
            InitializeComponent();

            userLogin = user;

            AplicarTexto();
            BindingDataGridView();
            TimerDataGridView();
        }

        // Configura color del panel
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(216, 255, 255, 255);
        }

        // Cierra el formu
        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Abre el FormInfoUsuario para crear un nuevo usuario
        private void customBotonCrear_Click(object sender, EventArgs e)
        {
            Super_User user = new Super_User();
            created = true;

            FormInfoUsusario crear = new FormInfoUsusario(user, created);

            if (crear.ShowDialog() == DialogResult.OK)
            {
                BindingDataGridView();
            }
        }

        // Abre el FormInfoUsuario para modificar el usuario seleccionado, excepto si es el usuario logueado
        private void customBotonModificar_Click(object sender, EventArgs e)
        {
            Super_User user = UsuarioSeleccionado();
            created = false;

            if (user == userLogin)
            {
                MessageBox.Show(Resources.Strings.msgModificar);
            }
            else
            {
                FormInfoUsusario modificar = new FormInfoUsusario(user, created);
                if (modificar.ShowDialog() == DialogResult.OK)
                {
                    BindingDataGridView();
                }
            }
        }

        // Elimina el usuario seleccionado, excepto si es el usuario actual
        private void customBotonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(Resources.Strings.msgEliminar, Resources.Strings.msgConfirmar, MessageBoxButtons.YesNo);
            bool delete = false;

            if (confirm == DialogResult.Yes)
            {
                Super_User user = UsuarioSeleccionado();

                if (user == userLogin)
                {
                    MessageBox.Show(Resources.Strings.msgAutoEliminar);
                }
                else
                {
                    delete = UsuarioEscritorioOrm.Delete(user);
                }
            }

            if (delete)
            {
                BindingDataGridView();
            }
        }

        // Reinicia el temporizador cuando se cambia un ítem del filtro
        private void checkedListBoxUsuarios_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            filterTimer.Stop();
            filterTimer.Start();
        }

        // Aplica textos localizados del form
        private void AplicarTexto()
        {
            customBotonCrear.Text = Resources.Strings.btnCrear;
            customBotonModificar.Text = Resources.Strings.btnModificar;
            customBotonEliminar.Text = Resources.Strings.btnEliminar;
        }

        // Asocia la fuente de datos del DataGridView con la lista de usuarios
        private void BindingDataGridView()
        {
            bindingSourceUsuarios.DataSource = UsuarioEscritorioOrm.SelectUsers();
        }

        // Configura un timer que se usará para filtrar usuarios
        private void TimerDataGridView()
        {
            filterTimer = new Timer();
            filterTimer.Interval = 100;
            filterTimer.Tick += FilterTimer_Tick;
        }

        // Obtiene el usuario seleccionado en el DataGridView
        private Super_User UsuarioSeleccionado()
        {
            int rowSelected = dataGridView.CurrentCell.RowIndex;
            int id = (int)dataGridView.Rows[rowSelected].Cells["useridadminDataGridViewTextBoxColumn"].Value;
            Super_User user = UsuarioEscritorioOrm.SelectById(id);

            return user;
        }

        // Filtra los usuarios mostrados según los roles seleccionados en el CheckedListBox
        private void FilterTimer_Tick(object sender, EventArgs e)
        {
            filterTimer.Stop();
            var users = UsuarioEscritorioOrm.SelectUsers();
            var selectedRole = checkedListBoxUsuarios.CheckedItems.Cast<string>().ToList();

            if (selectedRole.Count == 0)
            {
                BindingDataGridView();
            }
            else
            {
                var filteredItems = users.Where(item => selectedRole.Contains(item.role)).ToList();
                bindingSourceUsuarios.DataSource = filteredItems;
            }
        }
    }
}
