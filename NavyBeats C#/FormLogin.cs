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
    public partial class FormLogin: Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(216, 255, 255, 255);
        }

        private void botonRedondoLogin_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();

            menu.FormClosed += (s, args) => this.Show();
            this.Hide();
        }
    }
}
