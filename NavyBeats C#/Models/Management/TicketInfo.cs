using System;

namespace NavyBeats_C_.Models
{
    public class TicketInfo
    {
        public int TicketId { get; set; }             // Unique ticket identifier
        public string QueryType { get; set; }          // Type of query (e.g., "Inquiry" or "Issue")
        public string Subject { get; set; }            // Ticket subject (title)
        public string Description { get; set; }        // Detailed description of the ticket
        public int UserId { get; set; }                // Identifier of the user who sends the ticket
        public bool Status { get; set; }               // Ticket status (false = pending, true = resolved)
        public DateTime CreationDate { get; set; }     // Ticket creation date
        public DateTime? ClosingDate { get; set; }     // Ticket closing date (if resolved)
        public string Username { get; set; }           // Username of the ticket sender (optional)
    }
}
