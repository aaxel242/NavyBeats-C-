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
            loggedUserId = user.user_id_admin; // Variable que guarda el id del super_user logueado
        }

        public FormSoporte() { }
        /// <summary>
        /// Inicializa el formulario de soporte mas configuraciones extras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSoporte_Load(object sender, EventArgs e)
        {
            panelSoporte.BackColor = Color.FromArgb(216, 255, 255, 255);

            //Configuración del formulario
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            ApplyRoundedCorners(panelFormulario, 30);
            AdjustRadioButtons();

            // Pone los margins para los textboxes
            txtBoxAsunto.Size = new Size(300, 40);
            txtBoxAsunto.Margin = new Padding(0, 5, 0, 0);
        }
        /// <summary>
        /// Configura los RadioButtons para que aparezcan como botones y cambia su color de fondo al ser seleccionados.
        /// </summary>
        private void AdjustRadioButtons()
        {
            // Configurar los RadioButtons para que aparezcan como botones
            radioButtonTipo.Appearance = Appearance.Button;
            radioButtonTipo.AutoSize = false;
            radioButtonTipo.Size = new Size(30, 30);

            radioButtonTipo2.Appearance = Appearance.Button;
            radioButtonTipo2.AutoSize = false;
            radioButtonTipo2.Size = new Size(30, 30);

            // Establecer colores iniciales según el estado marcado
            radioButtonTipo.BackColor = radioButtonTipo.Checked ? Color.FromArgb(229, 177, 129) : Color.White;
            radioButtonTipo2.BackColor = radioButtonTipo2.Checked ? Color.FromArgb(229, 177, 129) : Color.White;

            radioButtonTipo.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonTipo2.CheckedChanged += RadioButton_CheckedChanged;
        }
        /// <summary>
        /// Manejador de eventos para cambiar el color de fondo del RadioButton al ser seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
            {
                rb.BackColor = rb.Checked ? Color.FromArgb(229, 177, 129) : Color.White;
            }
        }
        /// <summary>
        /// Aplica esquinas redondeadas a un panel.
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="radius"></param>
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
        /// <summary>
        /// Cambiar el RadioButton seleccionado al hacer clic en la etiqueta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblConsulta_Click(object sender, EventArgs e)
        {
            radioButtonTipo.Checked = true;
        }
        /// <summary>
        /// Cambiar el RadioButton seleccionado al hacer clic en la etiqueta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblIncidencia_Click(object sender, EventArgs e)
        {
            radioButtonTipo2.Checked = true;
        }
        /// <summary>
        /// Manejador de eventos para el botón de atrás. Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Valida los campos y envía el ticket.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviarForm_Click(object sender, EventArgs e)
        {
            try
            {
                // Determinar el tipo de consulta en función del botón de opción seleccionado
                string queryType = radioButtonTipo.Checked ? "Consulta" : (radioButtonTipo2.Checked ? "Incidencia" : "");
                string subject = txtBoxAsunto.Text.Trim();
                string description = txtBoxDescripcion.Text.Trim();

                // Valida los campos necesarios
                if (string.IsNullOrEmpty(queryType) || string.IsNullOrEmpty(subject))
                {
                    MessageBox.Show("Completa tots els camps.");
                }

                // Asigna los datos del formulario a un objeto TicketInfo.
                TicketInfo ticket = new TicketInfo
                {
                    QueryType = queryType,
                    Subject = subject,
                    Description = description,
                    CreatedBySuperUserId = loggedUserId,
                    Status = false,
                    CreationDate = DateTime.Now
                };

                // Insertar el ticket en la base de datos usando TicketOrm
                bool inserted = TicketOrm.InsertTicket(ticket);
                if (inserted)
                {
                    MessageBox.Show("Ticket enviat correctament.");
                    // Limpiar los campos del formulario tras el envío
                    txtBoxAsunto.Text = "";
                    txtBoxDescripcion.Text = "";
                }   
                else
                {
                    MessageBox.Show("Error al enviar ticket.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting ticket: " + ex.Message +
                                "\nInner Exception: " + ex.InnerException?.Message);
            }
        }
    }
}
