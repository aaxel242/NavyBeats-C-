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

        /// <summary>
        /// Configura color del panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(216, 255, 255, 255);
        }

        /// <summary>
        /// Cierra el formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Abre el FormInfoUsuario para crear un nuevo usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Abre el FormInfoUsuario para modificar el usuario seleccionado, excepto si es el usuario logueado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customBotonModificar_Click(object sender, EventArgs e)
        {
            Super_User user = UsuarioSeleccionado();
            created = false;

            if (user.email == userLogin.email)
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

        /// <summary>
        /// Elimina el usuario seleccionado, excepto si es el usuario actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customBotonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(Resources.Strings.msgEliminar, Resources.Strings.msgConfirmar, MessageBoxButtons.YesNo);
            bool delete = false;

            if (confirm == DialogResult.Yes)
            {
                Super_User user = UsuarioSeleccionado();

                if (user.email == userLogin.email)
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

        /// <summary>
        /// Reinicia el temporizador cuando se cambia un ítem del filtro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBoxUsuarios_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            filterTimer.Stop();
            filterTimer.Start();
        }

        /// <summary>
        /// Aplica textos localizados del form
        /// </summary>
        private void AplicarTexto()
        {
            customBotonCrear.Text = Resources.Strings.btnCrear;
            customBotonModificar.Text = Resources.Strings.btnModificar;
            customBotonEliminar.Text = Resources.Strings.btnEliminar;
        }

        /// <summary>
        /// Asocia la fuente de datos del DataGridView con la lista de usuarios
        /// </summary>
        private void BindingDataGridView()
        {
            bindingSourceUsuarios.DataSource = UsuarioEscritorioOrm.SelectUsers();
        }

        /// <summary>
        /// Configura un timer que se usará para filtrar usuarios
        /// </summary>
        private void TimerDataGridView()
        {
            filterTimer = new Timer();
            filterTimer.Interval = 100;
            filterTimer.Tick += FilterTimer_Tick;
        }

        /// <summary>
        /// Obtiene el usuario seleccionado en el DataGridView
        /// </summary>
        /// <returns></returns>
        private Super_User UsuarioSeleccionado()
        {
            int rowSelected = dataGridView.CurrentCell.RowIndex;
            int id = (int)dataGridView.Rows[rowSelected].Cells["useridadminDataGridViewTextBoxColumn"].Value;
            Super_User user = UsuarioEscritorioOrm.SelectById(id);

            return user;
        }

        /// <summary>
        /// Filtra los usuarios mostrados según los roles seleccionados en el CheckedListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
