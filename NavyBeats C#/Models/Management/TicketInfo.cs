using System;

namespace NavyBeats_C_.Models
{
    public class TicketInfo
    {
        public int TicketId { get; set; }             // Identificador único del ticket
        public string QueryType { get; set; }          // Tipo de consulta (por ejemplo: "Inquiry" o "Issue")
        public string Subject { get; set; }            // Asunto del ticket (título)
        public string Description { get; set; }        // Descripción detallada del ticket
        public int UserId { get; set; }                // Identificador del usuario que envía el ticket
        public bool Status { get; set; }               // Estado del ticket (false = pending, true = resolved)
        public DateTime CreationDate { get; set; }     // Fecha de creación del ticket
        public DateTime? ClosingDate { get; set; }     // Fecha de cierre del ticket (si está resuelto)
    }
}
