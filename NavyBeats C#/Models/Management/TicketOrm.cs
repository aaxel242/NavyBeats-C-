using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NavyBeats_C_.Models
{
    public static class TicketOrm
    {
        /// <summary>
        /// Inserta un nuevo ticket en la base de datos.
        /// </summary>
        public static bool InsertTicket(TicketInfo ticketInfo)
        {
            try
            {
                using (var context = new NaivyBeatsEntities())
                {
                    // Convertir las fechas a string con el formato adecuado, ya que en la BD son cadenas.
                    var ticket = new Ticket
                    {
                        type = ticketInfo.QueryType,              // Mapea 'QueryType' a 'type'
                        subject = ticketInfo.Subject,             // Mapea 'Subject' a 'subject'
                        description = ticketInfo.Description,     // Mapea 'Description' a 'description'
                        user_id = ticketInfo.UserId,              // Mapea 'UserId' a 'user_id'
                        status = ticketInfo.Status,               // Mapea 'Status' a 'status'
                        creation_date = ticketInfo.CreationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                        closing_date = ticketInfo.ClosingDate.HasValue
                                        ? ticketInfo.ClosingDate.Value.ToString("yyyy-MM-dd HH:mm:ss")
                                        : null,
                        // Se asigna el id del superusuario en MarkTicketAsResolved, si es necesario.
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
        /// Obtiene la lista de tickets pendientes (no resueltos).
        /// Debido a que las fechas se almacenan como string en la BD, se hace la conversión a DateTime en memoria.
        /// </summary>
        public static List<TicketInfo> GetTicketsPendientes()
        {
            using (var context = new NaivyBeatsEntities())
            {
                // Obtener datos sin conversión a DateTime
                var query = (from t in context.Ticket
                             join u in context.Super_User on t.user_id equals u.user_id_admin
                             where t.status == false
                             orderby t.creation_date descending
                             select new
                             {
                                 TicketId = t.ticket_id,
                                 QueryType = t.type,
                                 Subject = t.subject,
                                 Description = t.description,
                                 UserId = (int)t.user_id,
                                 Status = t.status,
                                 CreationDateStr = t.creation_date,
                                 ClosingDateStr = t.closing_date,
                                 Username = u.name
                             });
                // Conversión en memoria
                var tickets = query.AsEnumerable().Select(x => new TicketInfo
                {
                    TicketId = x.TicketId,
                    QueryType = x.QueryType,
                    Subject = x.Subject,
                    Description = x.Description,
                    UserId = x.UserId,
                    Status = x.Status,
                    CreationDate = DateTime.Parse(x.CreationDateStr),
                    ClosingDate = x.ClosingDateStr != null ? (DateTime?)DateTime.Parse(x.ClosingDateStr) : null,
                    Username = x.Username
                }).ToList();

                return tickets;
            }
        }

        /// <summary>
        /// Obtiene todos los tickets registrados.
        /// Se realiza la conversión de las fechas en memoria.
        /// </summary>
        public static List<TicketInfo> GetAllTickets()
        {
            using (var context = new NaivyBeatsEntities())
            {
                var query = (from t in context.Ticket
                             orderby t.creation_date descending
                             select new
                             {
                                 TicketId = t.ticket_id,
                                 QueryType = t.type,
                                 Subject = t.subject,
                                 Description = t.description,
                                 UserId = (int)t.user_id,
                                 Status = t.status,
                                 CreationDateStr = t.creation_date,
                                 ClosingDateStr = t.closing_date
                             });
                var tickets = query.AsEnumerable().Select(x => new TicketInfo
                {
                    TicketId = x.TicketId,
                    QueryType = x.QueryType,
                    Subject = x.Subject,
                    Description = x.Description,
                    UserId = x.UserId,
                    Status = x.Status,
                    CreationDate = DateTime.Parse(x.CreationDateStr),
                    ClosingDate = x.ClosingDateStr != null ? (DateTime?)DateTime.Parse(x.ClosingDateStr) : null
                }).ToList();

                return tickets;
            }
        }

        /// <summary>
        /// Marca un ticket como resuelto (cambia el status a true, asigna la fecha de cierre y registra el admin).
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
                        ticket.status = true; // Marcar como resuelto
                        // Convertir la fecha actual a string
                        ticket.closing_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        ticket.user_id_admin = adminUserId; // Asignar el id del superusuario que resuelve el ticket
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
