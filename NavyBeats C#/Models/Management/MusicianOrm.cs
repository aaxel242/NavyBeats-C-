using System.Collections.Generic;
using System.Linq;

namespace NavyBeats_C_.Models
{
    public static class MusicianOrm
    {
        /// <summary>
        /// Obtiene la lista de músicos con sus datos completos desde Users.
        /// </summary>
        /// <returns>Lista de User con músicos.</returns>
        public static List<Users> GetMusicians()
        {
            using (var context = new dam04Entities())
            {
                var musicians = (from m in context.Musician
                                 join u in context.Users on m.user_id equals u.user_id
                                 orderby u.name
                                 select u).ToList();
                return musicians;
            }
        }

        /// <summary>
        /// Obtiene un músico con su latitud y longitud basado en el user_id.
        /// </summary>
        /// <param name="userId">El ID del músico.</param>
        /// <returns>El usuario con sus coordenadas o null si no existe.</returns>
        public static Users GetMusicianById(int userId)
        {
            using (var context = new dam04Entities())
            {
                var musician = (from m in context.Musician
                                join u in context.Users on m.user_id equals u.user_id
                                where u.user_id == userId
                                select u).FirstOrDefault();
                return musician;
            }
        }

        /// <summary>
        /// Obtiene la lista de músicos con sus datos completos (nombre, municipalidad y email)
        /// mediante un join entre Musician, Users y Municipality.
        /// </summary>
        /// <returns>Lista de MusicianInfo.</returns>
        public static List<MusicianInfo> GetMusicianInfoList()
        {
            using (var context = new dam04Entities())
            {
                var query = from m in context.Musician
                            join u in context.Users on m.user_id equals u.user_id
                            join mun in context.Municipality on u.municipality_id equals mun.municipality_id
                            orderby u.name
                            select new MusicianInfo
                            {
                                UserId = u.user_id,
                                Name = u.name,
                                Municipality = mun.name, 
                                Email = u.email
                            };
                return query.ToList();
            }
        }
    }
}
