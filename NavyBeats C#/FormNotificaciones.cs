using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormNotificaciones : Form
    {
        private int logedUserId;

        public FormNotificaciones(int userId)
        {
            InitializeComponent();
            logedUserId = userId;
        }

        public FormNotificaciones()
        {
        }

        private void FormNotificaciones_Load(object sender, EventArgs e)
        {
            panelNotificaciones.BackColor = Color.FromArgb(216, 255, 255, 255);

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



            // Cargar las notificaciones del usuario logeado
            CargarNotificaciones();
        }

        private void CargarNotificaciones()
        {
            // Obtener las notificaciones desde el ORM (basado en el estado y el usuario logueado)
            List<TicketInfo> ticketsPendientes = TicketOrm.GetTicketsPendientes();

            // Limpiar el FlowLayoutPanel antes de agregar nuevos controles
            flowLayoutPanelTickets.Controls.Clear();

            // Mostrar las notificaciones en el FlowLayoutPanel
            foreach (var ticket in ticketsPendientes)
            {
                // Crear un panel para cada notificación
                Panel panelTicket = new Panel
                {
                    Size = new Size(flowLayoutPanelTickets.Width - 20, 100), // Ajustar el tamaño del panel
                    Padding = new Padding(5),
                    Margin = new Padding(5),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Etiqueta para mostrar información del ticket
                Label lblTicketInfo = new Label
                {
                    Text = $"ID: {ticket.TicketId} | Tipo: {ticket.QueryType} | Asunto: {ticket.Subject} | Fecha: {ticket.CreationDate.ToString("dd/MM/yyyy HH:mm")}",
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    ForeColor = Color.Black,
                    Location = new Point(10, 10)
                };

                // Botón para ver más detalles
                Button btnVerDetalles = new Button
                {
                    Text = "Ver Detalles",
                    Size = new Size(100, 30),
                    Location = new Point(panelTicket.Width - 110, 60),
                    BackColor = Color.FromArgb(229, 177, 129),
                    ForeColor = Color.White
                };
                btnVerDetalles.Click += (s, e) => MostrarDetalles(ticket);

                // Agregar los controles al panel
                panelTicket.Controls.Add(lblTicketInfo);
                panelTicket.Controls.Add(btnVerDetalles);

                // Agregar el panel al FlowLayoutPanel
                flowLayoutPanelTickets.Controls.Add(panelTicket);
            }
        }

        private void MostrarDetalles(TicketInfo ticket)
        {
            // Mostrar los detalles del ticket en algún panel o control adecuado
            // Ejemplo: Puedes abrir un formulario de detalles o mostrarlo en un Panel en la misma ventana

            MessageBox.Show($"Detalles del Ticket:\n\n" +
                $"ID: {ticket.TicketId}\n" +
                $"Tipo: {ticket.QueryType}\n" +
                $"Asunto: {ticket.Subject}\n" +
                $"Descripción: {ticket.Description}\n" +
                $"Estado: {(ticket.Status ? "Resuelto" : "Pendiente")}\n" +
                $"Fecha de Creación: {ticket.CreationDate.ToString("dd/MM/yyyy HH:mm")}\n" +
                $"Fecha de Cierre: {(ticket.ClosingDate.HasValue ? ticket.ClosingDate.Value.ToString("dd/MM/yyyy HH:mm") : "N/A")}");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
