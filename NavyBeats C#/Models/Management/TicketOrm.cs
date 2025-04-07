using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NavyBeats_C_.Models
{
    public static class TicketOrm
    {
        /// <summary>
        /// Inserts a new ticket into the database.
        /// </summary>
        public static bool InsertTicket(TicketInfo ticketInfo)
        {
            try
            {
                using (var context = new NaivyBeatsEntities())
                {
                    // Convertimos las fechas a string con el formato "yyyy-MM-dd HH:mm:ss"
                    var ticket = new Ticket
                    {
                        type = ticketInfo.QueryType,
                        subject = ticketInfo.Subject,
                        description = ticketInfo.Description,
                        user_id = ticketInfo.UserId,
                        status = ticketInfo.Status,
                        creation_date = ticketInfo.CreationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                        closing_date = ticketInfo.ClosingDate.HasValue ? ticketInfo.ClosingDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : null
                    };

                    context.Ticket.Add(ticket);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting ticket: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Gets the list of pending (unresolved) tickets.
        /// </summary>
        public static List<TicketInfo> GetTicketsPendientes()
        {
            using (var context = new NaivyBeatsEntities())
            {
                var tickets = (from t in context.Ticket
                               join u in context.Super_User on t.user_id equals u.user_id_admin
                               where t.status == false
                               orderby t.creation_date descending
                               select new TicketInfo
                               {
                                   TicketId = t.ticket_id,
                                   QueryType = t.type,
                                   Subject = t.subject,
                                   Description = t.description,
                                   UserId = (int)t.user_id,
                                   Status = t.status,
                                   // Parseamos las fechas que vienen en formato string
                                   CreationDate = DateTime.Parse(t.creation_date),
                                   ClosingDate = t.closing_date != null ? DateTime.Parse(t.closing_date) : (DateTime?)null,
                                   Username = u.name
                               }).ToList();

                return tickets;
            }
        }

        /// <summary>
        /// Gets all tickets.
        /// </summary>
        public static List<TicketInfo> GetAllTickets()
        {
            using (var context = new NaivyBeatsEntities())
            {
                return (from t in context.Ticket
                        orderby t.creation_date descending
                        select new TicketInfo
                        {
                            TicketId = t.ticket_id,
                            QueryType = t.type,
                            Subject = t.subject,
                            Description = t.description,
                            UserId = (int)t.user_id,
                            Status = t.status,
                            CreationDate = DateTime.Parse(t.creation_date),
                            ClosingDate = t.closing_date != null ? DateTime.Parse(t.closing_date) : (DateTime?)null
                        }).ToList();
            }
        }

        /// <summary>
        /// Marks a ticket as resolved, setting status to true, closing_date to now, and recording the admin user who resolved it.
        /// </summary>
        public static bool MarkTicketAsResolved(int ticketId, int adminUserId)
        {
            try
            {
                using (var context = new NaivyBeatsEntities())
                {
                    var ticket = context.Ticket.FirstOrDefault(t => t.ticket_id == ticketId);
                    if (ticket != null)
                    {
                        ticket.status = true;
                        ticket.closing_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        ticket.user_id_admin = adminUserId;
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error marking ticket as resolved: " + ex.Message);
                return false;
            }
        }
    }
}
