using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace NavyBeats_C_
{
    public partial class FormSoporte : Form
    {
        public FormSoporte()
        {
            InitializeComponent();
        }

        private void FormSoporte_Load(object sender, EventArgs e)
        {
            AplicarEsquinasRedondeadas(panelFormulario, 30);
            ajustarRadioButton();
            txtBoxNombre.Size = new Size(300, 40);
            txtBoxAsunto.Size = new Size(300, 40);
            txtBoxNombre.Margin = new Padding(0, 5, 0, 0);
            txtBoxAsunto.Margin = new Padding(0, 5, 0, 0);
        }

        private void ajustarRadioButton()
        {
            // Configurar el CheckBox existente
            radioButtonTipo.Appearance = Appearance.Button;
            radioButtonTipo.AutoSize = false;
            radioButtonTipo.Size = new Size(30, 30);

            radioButtonTipo2.Appearance = Appearance.Button;
            radioButtonTipo2.AutoSize = false;
            radioButtonTipo2.Size = new Size(30, 30);

            // Aplicar color inicial
            radioButtonTipo.BackColor = radioButtonTipo.Checked
                ? Color.FromArgb(229, 177, 129)
                : Color.White;

            radioButtonTipo2.BackColor = radioButtonTipo2.Checked
                ? Color.FromArgb(229, 177, 129)
                : Color.White;

            radioButtonTipo.CheckedChanged += CheckBoxTipo_CheckedChanged;
            radioButtonTipo2.CheckedChanged += CheckBoxTipo_CheckedChanged;
        }
        private void CheckBoxTipo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                radioButton.BackColor = radioButton.Checked
                    ? Color.FromArgb(229, 177, 129)
                    : Color.White;
            }
        }
        private void AplicarEsquinasRedondeadas(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            // Esquina superior izquierda (redondeada)
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90);

            // Línea superior
            path.AddLine(radio, 0, panel.Width - radio, 0);

            // Esquina superior derecha (redondeada)
            path.AddArc(panel.Width - radio * 2, 0, radio * 2, radio * 2, 270, 90);

            // Línea derecha
            path.AddLine(panel.Width, radio, panel.Width, panel.Height - radio);

            // Esquina inferior derecha (redondeada)
            path.AddArc(panel.Width - radio * 2, panel.Height - radio * 2, radio * 2, radio * 2, 0, 90);

            // Línea inferior
            path.AddLine(panel.Width - radio, panel.Height, 0, panel.Height);

            // Línea izquierda
            path.AddLine(0, panel.Height, 0, radio);

            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void pboxAtras_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void lblConsulta_Click(object sender, EventArgs e)
        {
            radioButtonTipo.Checked = true;
        }

        private void lblIncidencia_Click(object sender, EventArgs e)
        {
            radioButtonTipo2.Checked = true;    
        }
    }
}