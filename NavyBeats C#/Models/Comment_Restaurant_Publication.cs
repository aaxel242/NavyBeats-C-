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
    
    public partial class Comment_Restaurant_Publication
    {
        public int comment_id { get; set; }
        public string content { get; set; }
        public Nullable<int> publication_id { get; set; }
        public Nullable<int> user_id { get; set; }
    
        public virtual Publication Publication { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
