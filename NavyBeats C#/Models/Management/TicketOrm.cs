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
                using (var context = new NavyBeatsEntities())
                {
                    var ticket = new Ticket
                    {
                        type = ticketInfo.QueryType,  // Mapea 'QueryType' a 'type'
                        subject = ticketInfo.Subject,          // Mapea 'Subject' a 'subject'
                        description = ticketInfo.Description,  // Mapea 'Description' a 'description'
                        user_id = ticketInfo.UserId,           // Mapea 'UserId' a 'user_id'
                        status = ticketInfo.Status,            // Mapea 'Status' a 'status'
                        creation_date = ticketInfo.CreationDate,  // Mapea 'CreationDate' a 'creation_date'
                        closing_date = ticketInfo.ClosingDate // Mapea 'ClosingDate' a 'closing_date'
                    };

                    context.Ticket.Add(ticket);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el ticket: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Obtiene la lista de tickets pendientes (no resueltos).
        /// Debido a que las fechas se almacenan como string en la BD, se hace la conversión a DateTime en memoria.
        /// </summary>
        public static List<TicketInfo> GetTicketsPendientes()
        {
            using (var context = new NavyBeatsEntities())
            {
                var tickets = (from t in context.Ticket
                               where t.status == false  // Filtra por tickets no resueltos (status = false)
                               orderby t.creation_date descending
                               select new TicketInfo
                               {
                                   TicketId = t.ticket_id,            // Mapea 'ticket_id'
                                   QueryType = t.type,                // Mapea 'type'
                                   Subject = t.subject,               // Mapea 'subject'
                                   Description = t.description,       // Mapea 'description'
                                   UserId = (int)t.user_id,                // Mapea 'user_id'
                                   Status = t.status,                 // Mapea 'status'
                                   CreationDate = (DateTime)t.creation_date,    // Mapea 'creation_date'
                                   ClosingDate = t.closing_date       // Mapea 'closing_date'
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
            using (var context = new NavyBeatsEntities())
            {
                return (from t in context.Ticket
                        orderby t.creation_date descending
                        select new TicketInfo
                        {
                            TicketId = t.ticket_id,            // Mapea 'ticket_id'
                            QueryType = t.type,                // Mapea 'type'
                            Subject = t.subject,               // Mapea 'subject'
                            Description = t.description,       // Mapea 'description'
                            UserId = (int)t.user_id,                // Mapea 'user_id'
                            Status = t.status,                 // Mapea 'status'
                            CreationDate = (DateTime)t.creation_date,    // Mapea 'creation_date'
                            ClosingDate = t.closing_date       // Mapea 'closing_date'
                        }).ToList();

                return tickets;
            }
        }

        /// <summary>
        /// Marca un ticket como resuelto (cambia el status a true y establece la fecha de cierre).
        /// </summary>
        public static bool MarcarTicketComoResuelto(int ticketId, int adminUserId)
        {
            try
            {
                using (var context = new NavyBeatsEntities())
                {
                    var ticket = context.Ticket.FirstOrDefault(t => t.ticket_id == ticketId);
                    if (ticket != null)
                    {
                        ticket.status = true;  // Marcar como resuelto (status = true)
                        ticket.closing_date = DateTime.Now;  // Asignar la fecha de cierre
                        ticket.user_id_admin = adminUserId;  // Asignar el id del superusuario que resuelve el ticket
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al marcar el ticket como resuelto: " + ex.Message);
                return false;
            }
        }
    }
}
