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
    
    public partial class Offer_in_Styles
    {
        public int style_id { get; set; }
        public int id_offer_in { get; set; }
        public string creation_date { get; set; }
    
        public virtual Offer_In Offer_In { get; set; }
        public virtual Style Style { get; set; }
    }
}
