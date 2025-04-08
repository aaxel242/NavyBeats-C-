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

        private void FormNotificaciones_Load(object sender, EventArgs e)
        {
            panelNotificaciones.BackColor = Color.FromArgb(216, 255, 255, 255);
            ApplyRoundedCorners(panelNotificaciones2, 30);
            CenterForm();
            LoadNotifications();
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

        private void LoadNotifications()
        {
            List<TicketInfo> pendingTickets = TicketOrm.GetTicketsPendientes();
            flowLayoutPanelTickets.Controls.Clear();

            foreach (var ticket in pendingTickets)
            {
                Panel panelTicket = new Panel
                {
                    Size = new Size(flowLayoutPanelTickets.Width - 20, 100),
                    Padding = new Padding(5),
                    Margin = new Padding(5),
                    BackColor = Color.FromArgb(8, 61, 119),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label lblTicketInfo = new Label
                {
                    Text = $"User: {ticket.Username} | Tipo: {ticket.QueryType} | Date: {ticket.CreationDate:dd/MM/yyyy HH:mm} \n | Asunto: {ticket.Subject} | {ticket.Description}" +
                    $"",
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    ForeColor = Color.Black,
                    Location = new Point(10, 10)
                };

                Button btnResolve = new Button
                {
                    Text = "Resolve Ticket",
                    Size = new Size(100, 30),
                    Location = new Point(panelTicket.Width - 110, 60),
                    BackColor = Color.FromArgb(229, 177, 129),
                    ForeColor = Color.White
                };
                btnResolve.Click += (s, e) => MarkTicketResolved(ticket.TicketId);

                panelTicket.Controls.Add(lblTicketInfo);
                panelTicket.Controls.Add(btnResolve);
                flowLayoutPanelTickets.Controls.Add(panelTicket);
            }
        }

        private void MarkTicketResolved(int ticketId)
        {
            bool resolved = TicketOrm.MarkTicketAsResolved(ticketId, loggedUserId);
            if (resolved)
            {
                MessageBox.Show("Ticket marked as resolved.");
                LoadNotifications();
            }
            else
            {
                MessageBox.Show("Failed to mark ticket as resolved.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
