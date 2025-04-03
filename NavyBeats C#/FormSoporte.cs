using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormSoporte : Form
    {
        private int logedUserId;

        public FormSoporte(Super_User user)
        {
            InitializeComponent();
            logedUserId = user.user_id_admin;
        }

        public FormSoporte() { }

        private void FormSoporte_Load(object sender, EventArgs e)
        {
            panelSoporte.BackColor = Color.FromArgb(216, 255, 255, 255);

            // Centrar el formulario en la pantalla
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

            AplicarEsquinasRedondeadas(panelFormulario, 30);
            AjustarRadioButtons();

            // Ajuste de tamaño y márgenes de los TextBox
            txtBoxNombre.Size = new Size(300, 40);
            txtBoxAsunto.Size = new Size(300, 40);
            txtBoxAsunto.Margin = new Padding(0, 5, 0, 0);
        }

        private void AjustarRadioButtons()
        {
            // Configuración de los RadioButton para simular botones
            radioButtonTipo.Appearance = Appearance.Button;
            radioButtonTipo.AutoSize = false;
            radioButtonTipo.Size = new Size(30, 30);

            radioButtonTipo2.Appearance = Appearance.Button;
            radioButtonTipo2.AutoSize = false;
            radioButtonTipo2.Size = new Size(30, 30);

            // Aplicar color inicial dependiendo del estado
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

        private void AplicarEsquinasRedondeadas(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            // Esquina superior izquierda
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90);
            // Línea superior
            path.AddLine(radio, 0, panel.Width - radio, 0);
            // Esquina superior derecha
            path.AddArc(panel.Width - radio * 2, 0, radio * 2, radio * 2, 270, 90);
            // Línea derecha
            path.AddLine(panel.Width, radio, panel.Width, panel.Height - radio);
            // Esquina inferior derecha
            path.AddArc(panel.Width - radio * 2, panel.Height - radio * 2, radio * 2, radio * 2, 0, 90);
            // Línea inferior
            path.AddLine(panel.Width - radio, panel.Height, 0, panel.Height);
            // Línea izquierda
            path.AddLine(0, panel.Height, 0, radio);
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
            // Seleccionar el tipo de consulta basado en el radio button seleccionado
            string tipoConsulta = radioButtonTipo.Checked ? "Consulta" : (radioButtonTipo2.Checked ? "Incidencia" : "");
            string nombreTicket = txtBoxNombre.Text.Trim();
            string asunto = txtBoxAsunto.Text.Trim();
            string descripcion = txtBoxDescripcion.Text.Trim();

            // Validación de campos obligatorios
            if (string.IsNullOrEmpty(tipoConsulta) || string.IsNullOrEmpty(nombreTicket) || string.IsNullOrEmpty(asunto))
            {
                MessageBox.Show("Por favor, completa todos los campos requeridos.");
                return;
            }

            // Mapeo de los datos del formulario al objeto TicketInfo
            // Se asume que 'nombreTicket' representa el título del ticket.
            // Se combina el 'asunto' y la 'descripcion' en el campo Description.
            TicketInfo ticket = new TicketInfo
            {
                QueryType = tipoConsulta,
                Subject = nombreTicket,
                Description = "Asunto: " + asunto + "\nDescripción: " + descripcion,
                UserId = logedUserId,
                Status = false,
                CreationDate = DateTime.Now,
                ClosingDate = null
            };

            // Insertar el ticket en la base de datos mediante TicketOrm
            bool insertado = TicketOrm.InsertTicket(ticket);
            if (insertado)
            {
                MessageBox.Show("Ticket enviado correctamente.");
                // Limpiar los campos después de enviar el ticket
                txtBoxNombre.Text = "";
                txtBoxAsunto.Text = "";
                txtBoxDescripcion.Text = "";
            }
        }
    }
}
