using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavyBeats_C_
{
    public partial class FormCrearUsusario: Form
    {
        public FormCrearUsusario()
        {
            InitializeComponent();
        }

        private void FormCrear_Load(object sender, EventArgs e)
        {
            customComboBoxRol.Items.Add("Super");
            customComboBoxRol.Items.Add("Admin");
            customComboBoxRol.Items.Add("Mantenimiento");
        }
    }
}
