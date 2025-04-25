using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormNotificaciones : Form
    {
        private int loggedUserId;
        public FormNotificaciones(int userId)
        {
            InitializeComponent();
            loggedUserId = userId;
        }

        public FormNotificaciones() { }

        /// <summary>
        /// Método que se ejecuta al cargar el formulario + modificaciones de estilo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormNotificaciones_Load(object sender, EventArgs e)
        {
            panelNotificaciones.BackColor = Color.FromArgb(216, 255, 255, 255);
            ApplyRoundedCorners(panelNotificaciones2, 30);
            LoadNotifications(); //Llamamos a la función que carga las notificaciones.
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        /// <summary>
        /// Aplica esquinas redondeadas a un panel.
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="radius"></param>
        private void ApplyRoundedCorners(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            // Esquina superior izquierda
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            // Línea superior
            path.AddLine(radius, 0, panel.Width - radius, 0);
            // Esquina superior derecha
            path.AddArc(panel.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            // Línea derecha
            path.AddLine(panel.Width, radius, panel.Width, panel.Height - radius);
            // Esquina inferior derecha
            path.AddArc(panel.Width - radius * 2, panel.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            // Esquina inferior izquierda
            path.AddArc(0, panel.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }
        /// <summary>
        /// Carga las notificaciones de tickets pendientes en el panel.
        /// </summary>
        private void LoadNotifications()
        {
            List<TicketInfo> pendingTickets = TicketOrm.GetTicketsPendientes();
            flowLayoutPanelTickets.Controls.Clear();

            foreach (var ticket in pendingTickets)
            {
                // Crear un panel para cada notificación.
                Panel panelTicket = new Panel
                {
                    Width = flowLayoutPanelTickets.Width - 40,
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5)
                };

                // Crear un RichTextBox para mostrar el contenido formateado.
                RichTextBox rtb = new RichTextBox
                {
                    ReadOnly = true,
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.White,
                    Location = new Point(10, 10),
                    Width = panelTicket.Width - 20,
                    ScrollBars = RichTextBoxScrollBars.Vertical,
                    Font = new Font("Montserrat", 12, FontStyle.Regular)
                };

                // Generar el contenido en RTF con los títulos en negrita y cada título en línea separada.
                string rtfContent = @"{\rtf1\ansi\deff0 
                {\fonttbl{\f0 Montserrat;}}
                \fs24
                \b Nombre: \b0 " + ticket.Username + @"\par " +
                @"\b Tipo: \b0 " + ticket.QueryType + @"\par " +
                @"\b Fecha: \b0 " + ticket.CreationDate.ToString("dd/MM/yyyy HH:mm") + @"\par " +
                @"\b Asunto: \b0 " + ticket.Subject + @"\par\par " +
                ticket.Description +
                @"}";
                rtb.Rtf = rtfContent;

                rtb.Height = 140;  // Aumentamos la altura base.

                // Crear el botón "Resolve Ticket" y posicionarlo en la esquina inferior derecha.
                Button btnResolve = new Button
                {
                    Text = "Cerrar Ticket",
                    Size = new Size(100, 30),
                    BackColor = Color.FromArgb(229, 177, 129),
                    ForeColor = Color.White
                };

                // Posicionar el botón debajo del RichTextBox.
                btnResolve.Location = new Point(panelTicket.Width - btnResolve.Width - 10, rtb.Bottom + 10);

                btnResolve.Click += (s, e) => MarkTicketResolved(ticket.TicketId);
                panelTicket.Height = btnResolve.Bottom + 10;

                // Agregar controles al panel.
                panelTicket.Controls.Add(rtb);
                panelTicket.Controls.Add(btnResolve);

                // Agregar el panel al FlowLayoutPanel.
                flowLayoutPanelTickets.Controls.Add(panelTicket);
            }
        }
        /// <summary>
        /// Marca un ticket como resuelto y actualiza la interfaz.
        /// </summary>
        /// <param name="ticketId"></param>
        private void MarkTicketResolved(int ticketId)
        {
            bool resolved = TicketOrm.MarkTicketAsResolved(ticketId, loggedUserId);
            if (resolved)
            {
                MessageBox.Show("Ticket marked as resolved.");
                LoadNotifications(); // Recargar las notificaciones después de resolver una.
            }
            else
            {
                MessageBox.Show("Failed to mark ticket as resolved.");
            }
        }
        /// <summary>
        /// Cerrar formulario al hacer clic en el botón de atrás.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
