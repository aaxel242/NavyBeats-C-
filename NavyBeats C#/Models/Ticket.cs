//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NavyBeats_C_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int ticket_id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string creation_date { get; set; }
        public string closing_date { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> user_id_admin { get; set; }
        public string subject { get; set; }
        public bool status { get; set; }
    
        public virtual Super_User Super_User { get; set; }
        public virtual Users Users { get; set; }
    }
}
