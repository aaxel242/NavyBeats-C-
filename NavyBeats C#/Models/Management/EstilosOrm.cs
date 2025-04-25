using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavyBeats_C_.Models
{
    public static class EstilosOrm
    {
        /// <summary>
        /// Obtiene la lista de estilos de música.
        /// </summary>
        /// <returns></returns>
        public static List<Style> Select()
        {
            List<Style> _estilo =
                (from municipio in Orm.bd.Style
                 select municipio).ToList();

            return _estilo;
        }
    }
}
