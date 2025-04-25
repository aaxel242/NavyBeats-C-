using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavyBeats_C_.Models
{
    public static class MunicipiosOrm
    {
        /// <summary>
        /// Selecciona todos los municipios de la base de datos.
        /// </summary>
        /// <returns></returns>
        public static List<Municipality> Select()
        {
            List<Municipality> _municipio =
                (from municipio in Orm.bd.Municipality
                             select municipio).ToList();

            return _municipio;
        }

        public static Municipality SelectById(int? municipality_id)
        {
            Municipality _municipio =
                (from municipio in Orm.bd.Municipality
                 where municipio.municipality_id == municipality_id
                 select municipio).FirstOrDefault();

            return _municipio;
        }
    }
}