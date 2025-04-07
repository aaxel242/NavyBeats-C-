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
            loggedUserId = user.user_id_admin; // Se usa user_id_admin para identificar al usuario logueado
        }

        public FormSoporte() { }

        private void FormSoporte_Load(object sender, EventArgs e)
        {
            panelSoporte.BackColor = Color.FromArgb(216, 255, 255, 255);

            // Center the form on the screen
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

            ApplyRoundedCorners(panelFormulario, 30);
            AdjustRadioButtons();

            // Set sizes and margins for the TextBoxes
            txtBoxAsunto.Size = new Size(300, 40);
            txtBoxAsunto.Margin = new Padding(0, 5, 0, 0);
        }

        private void AdjustRadioButtons()
        {
            // Configure the RadioButtons to appear as buttons
            radioButtonTipo.Appearance = Appearance.Button;
            radioButtonTipo.AutoSize = false;
            radioButtonTipo.Size = new Size(30, 30);

            radioButtonTipo2.Appearance = Appearance.Button;
            radioButtonTipo2.AutoSize = false;
            radioButtonTipo2.Size = new Size(30, 30);

            // Set initial colors based on checked state
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
            // Top-left arc
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            // Top line
            path.AddLine(radius, 0, panel.Width - radius, 0);
            // Top-right arc
            path.AddArc(panel.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            // Right line
            path.AddLine(panel.Width, radius, panel.Width, panel.Height - radius);
            // Bottom-right arc
            path.AddArc(panel.Width - radius * 2, panel.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            // Bottom line
            path.AddLine(panel.Width - radius, panel.Height, 0, panel.Height);
            // Left line
            path.AddLine(0, panel.Height, 0, radius);
            path.CloseFigure();
            panel.Region = new Region(path);
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

        private void btnEnviarForm_Click(object sender, EventArgs e)
        {
            // Determine query type based on the selected RadioButton
            string queryType = radioButtonTipo.Checked ? "Inquiry" : (radioButtonTipo2.Checked ? "Issue" : "");
            string subject = txtBoxAsunto.Text.Trim();
            string description = txtBoxDescripcion.Text.Trim();

            // Validate required fields
            if (string.IsNullOrEmpty(queryType) || string.IsNullOrEmpty(subject))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Map the form data to a TicketInfo object.
            TicketInfo ticket = new TicketInfo
            {
                QueryType = queryType,
                Subject = subject, // Aseguramos que se asigne el subject
                Description = "Subject: " + subject + "\nDescription: " + description,
                UserId = loggedUserId,
                Status = false,
                CreationDate = DateTime.Now,
                ClosingDate = null
            };

            // Insert the ticket into the database using TicketOrm
            bool inserted = TicketOrm.InsertTicket(ticket);
            if (inserted)
            {
                MessageBox.Show("Ticket sent successfully.");
                // Clear the fields after sending the ticket
                txtBoxAsunto.Text = "";
                txtBoxDescripcion.Text = "";
            }
        }
    }
}
