﻿using System;
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
    public partial class FormLocalMusicoSA: Form
    {
        public FormLocalMusicoSA()
        {
            InitializeComponent();
        }

        private void FormLocalMusicoSA_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Add(new object[] { "Mohamed", "example@gmail.com", "1234", "12/04/2005", 1 });
            dataGridView.Rows.Add(new object[] { "Mohamed", "example@gmail.com", "1234", "12/04/2005", 0 });
            dataGridView.Rows.Add(new object[] { "Mohamed", "example@gmail.com", "1234", "12/04/2005", 1 });
        }
    }
}
