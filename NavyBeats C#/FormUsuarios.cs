using System;
using System.Collections.Generic;
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
            bindingSourceUsuarios.DataSource = UsuarioEscritorioOrm.SelectUsers();

            userLogin = user;

            filterTimer = new Timer();
            filterTimer.Interval = 100;
            filterTimer.Tick += FilterTimer_Tick;
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(216, 255, 255, 255);
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonRedondoCrear_Click(object sender, EventArgs e)
        {
            Super_User user = new Super_User();
            created = true;

            FormInfoUsusario crear = new FormInfoUsusario(user, created);

            if (crear.ShowDialog() == DialogResult.OK)
            {
                bindingSourceUsuarios.DataSource = UsuarioEscritorioOrm.SelectUsers();
            }
        }

        private void customBotonModificar_Click(object sender, EventArgs e)
        {
            Super_User user = usuarioSeleccionado();
            created = false;

            if (user == userLogin)
            {
                MessageBox.Show("No puedes modificar tu propio usuario.");
            }
            else
            {
                FormInfoUsusario modificar = new FormInfoUsusario(user, created);
                if (modificar.ShowDialog() == DialogResult.OK)
                {
                    bindingSourceUsuarios.DataSource = UsuarioEscritorioOrm.SelectUsers();
                }
            }
        }

        private void botonRedondoEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Estas seguro de eliminar al usuario?", "Confirmar", MessageBoxButtons.YesNo);
            bool delete = false;

            if (confirm == DialogResult.Yes)
            {
                Super_User user = usuarioSeleccionado();

                if (user == userLogin)
                {
                    MessageBox.Show("No puedes eliminar tu propio usuario.");
                }
                else
                {
                    delete = UsuarioEscritorioOrm.Delete(user);
                }
            }

            if (delete)
            {
                bindingSourceUsuarios.DataSource = UsuarioEscritorioOrm.SelectUsers();
            }
        }

        private void checkedListBoxUsuarios_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            filterTimer.Stop();
            filterTimer.Start();
        }

        private Super_User usuarioSeleccionado()
        {
            int rowSelected = dataGridView.CurrentCell.RowIndex;
            int id = (int)dataGridView.Rows[rowSelected].Cells["useridadminDataGridViewTextBoxColumn"].Value;
            Super_User user = UsuarioEscritorioOrm.selectById(id);

            return user;
        }

        private void FilterTimer_Tick(object sender, EventArgs e)
        {
            filterTimer.Stop();
            var users = UsuarioEscritorioOrm.SelectUsers();
            var selectedRole = checkedListBoxUsuarios.CheckedItems.Cast<string>().ToList();

            if (selectedRole.Count == 0)
            {
                bindingSourceUsuarios.DataSource = users;
            }
            else
            {
                filter(users, selectedRole);
            }
        }

        private void filter(List<Super_User> users, List<string> selectedRole)
        {
            var filteredItems = users.Where(item => selectedRole.Contains(item.role)).ToList();
            bindingSourceUsuarios.DataSource = filteredItems;
        }
    }
}
