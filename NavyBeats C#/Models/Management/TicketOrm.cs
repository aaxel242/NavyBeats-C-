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
                using (var context = new dam04Entities())
                {
                    var ticket = new Ticket
                    {
                        type = ticketInfo.QueryType,
                        subject = ticketInfo.Subject,
                        description = ticketInfo.Description,
                        created_by_super_user_id = ticketInfo.CreatedBySuperUserId, // Campo actualizado
                        status = ticketInfo.Status,
                        creation_date = ticketInfo.CreationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                        closing_date = ticketInfo.ClosingDate?.ToString("yyyy-MM-dd HH:mm:ss")
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
            using (var context = new dam04Entities())
            {
                var query = (from t in context.Ticket
                             join su in context.Super_User
                                 on t.created_by_super_user_id equals su.user_id_admin // Join con Super_User
                             where t.status == false
                             orderby t.creation_date descending
                             select new
                             {
                                 TicketId = t.ticket_id,
                                 QueryType = t.type,
                                 Subject = t.subject,
                                 Description = t.description,
                                 CreatedBySuperUserId = t.created_by_super_user_id,
                                 Status = t.status,
                                 CreationDateStr = t.creation_date,
                                 ClosingDateStr = t.closing_date,
                                 Username = su.name // Nombre del Super_User
                             });

                var tickets = query.AsEnumerable().Select(x => new TicketInfo
                {
                    TicketId = x.TicketId,
                    QueryType = x.QueryType,
                    Subject = x.Subject,
                    Description = x.Description,
                    CreatedBySuperUserId = x.CreatedBySuperUserId, // Mapeo correcto
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
            using (var context = new dam04Entities())
            {
                var query = (from t in context.Ticket
                             join su in context.Super_User
                                 on t.created_by_super_user_id equals su.user_id_admin 
                             orderby t.creation_date descending
                             select new
                             {
                                 TicketId = t.ticket_id,
                                 QueryType = t.type,
                                 Subject = t.subject,
                                 Description = t.description,
                                 CreatedBySuperUserId = t.created_by_super_user_id,
                                 Status = t.status,
                                 CreationDateStr = t.creation_date,
                                 ClosingDateStr = t.closing_date,
                                 Username = su.name, 
                                 ClosedBySuperUserId = t.closed_by_super_user_id 
                             });

                var tickets = query.AsEnumerable().Select(x => new TicketInfo
                {
                    TicketId = x.TicketId,
                    QueryType = x.QueryType,
                    Subject = x.Subject,
                    Description = x.Description,
                    CreatedBySuperUserId = x.CreatedBySuperUserId, // Mapeo correcto
                    Status = x.Status,
                    CreationDate = DateTime.Parse(x.CreationDateStr),
                    ClosingDate = x.ClosingDateStr != null ? (DateTime?)DateTime.Parse(x.ClosingDateStr) : null,
                    Username = x.Username,
                    ClosedBySuperUserId = x.ClosedBySuperUserId // Si tu modelo lo requiere
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
                using (var context = new dam04Entities())
                {
                    var ticket = context.Ticket.FirstOrDefault(t => t.ticket_id == ticketId);
                    if (ticket != null)
                    {
                        ticket.status = true;
                        ticket.closing_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        ticket.closed_by_super_user_id = adminUserId; // Campo actualizado
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
