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
    
    public partial class User_Style
    {
        public int user_id { get; set; }
        public int style_id { get; set; }
        public System.DateTime creation_date { get; set; }
    
        public virtual Musician Musician { get; set; }
    }
}
