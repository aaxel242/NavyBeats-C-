using System;

namespace NavyBeats_C_.Models
{
    public class TicketInfo
    {
        public int TicketId { get; set; }
        public string QueryType { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int CreatedBySuperUserId { get; set; } // Reemplaza UserId
        public bool Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ClosingDate { get; set; }
        public string Username { get; set; }
        public int? ClosedBySuperUserId { get; set; } // Nuevo campo
    }
}