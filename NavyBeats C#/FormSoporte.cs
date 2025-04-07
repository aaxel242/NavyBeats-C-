using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormSoporte : Form
    {
        private int loggedUserId;

        public FormSoporte(Super_User user)
        {
            InitializeComponent();
            // Usamos el campo user_id_admin (o el que corresponda para identificar al usuario logueado)
            loggedUserId = user.user_id_admin;
        }

        public FormSoporte() { }

        private void FormSoporte_Load(object sender, EventArgs e)
        {
            panelSoporte.BackColor = Color.FromArgb(216, 255, 255, 255);
            CenterForm();

            ApplyRoundedCorners(panelFormulario, 30);
            AdjustRadioButtons();

            txtBoxNombre.Size = new Size(300, 40);
            txtBoxAsunto.Size = new Size(300, 40);
            txtBoxNombre.Margin = new Padding(0, 5, 0, 0);
            txtBoxAsunto.Margin = new Padding(0, 5, 0, 0);
        }

        private void CenterForm()
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;
            int positionX = (screenWidth - formWidth) / 2;
            int positionY = (screenHeight - formHeight) / 2;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(positionX, positionY);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void AdjustRadioButtons()
        {
            radioButtonTipo.Appearance = Appearance.Button;
            radioButtonTipo.AutoSize = false;
            radioButtonTipo.Size = new Size(30, 30);

            radioButtonTipo2.Appearance = Appearance.Button;
            radioButtonTipo2.AutoSize = false;
            radioButtonTipo2.Size = new Size(30, 30);

            radioButtonTipo.BackColor = radioButtonTipo.Checked ? Color.FromArgb(229, 177, 129) : Color.White;
            radioButtonTipo2.BackColor = radioButtonTipo2.Checked ? Color.FromArgb(229, 177, 129) : Color.White;

            radioButtonTipo.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonTipo2.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
            {
                rb.BackColor = rb.Checked ? Color.FromArgb(229, 177, 129) : Color.White;
            }
        }

        private void ApplyRoundedCorners(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddLine(radius, 0, panel.Width - radius, 0);
            path.AddArc(panel.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddLine(panel.Width, radius, panel.Width, panel.Height - radius);
            path.AddArc(panel.Width - radius * 2, panel.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddLine(panel.Width - radius, panel.Height, 0, panel.Height);
            path.AddLine(0, panel.Height, 0, radius);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void btnEnviarForm_Click(object sender, EventArgs e)
        {
            string queryType = radioButtonTipo.Checked ? "Inquiry" : (radioButtonTipo2.Checked ? "Issue" : "");
            string ticketTitle = txtBoxNombre.Text.Trim();
            string subject = txtBoxAsunto.Text.Trim();
            string description = txtBoxDescripcion.Text.Trim();

            if (string.IsNullOrEmpty(queryType) || string.IsNullOrEmpty(ticketTitle) || string.IsNullOrEmpty(subject))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            TicketInfo ticket = new TicketInfo
            {
                QueryType = queryType,
                Subject = ticketTitle,
                Description = "Subject: " + subject + "\nDescription: " + description,
                UserId = loggedUserId,
                Status = false,
                CreationDate = DateTime.Now,
                ClosingDate = null
            };

            bool inserted = TicketOrm.InsertTicket(ticket);
            if (inserted)
            {
                MessageBox.Show("Ticket sent successfully.");
                txtBoxNombre.Text = "";
                txtBoxAsunto.Text = "";
                txtBoxDescripcion.Text = "";
            }
        }

        private void lblConsulta_Click(object sender, EventArgs e)
        {
            radioButtonTipo.Checked = true;
        }

        private void lblIncidencia_Click(object sender, EventArgs e)
        {
            radioButtonTipo2.Checked = true;
        }

        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
