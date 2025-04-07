using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace NavyBeats_C_.Models
{
    public static class CalendarioOrm
    {
        /// <summary>
        /// Inserta 5 ofertas de prueba en las tablas Offer_dir y Offer_In.
        /// Se insertan solo si no existen ofertas previas.
        /// Se usan valores válidos para musician_id y restaurant_id.
        /// Los campos publish_date y event_date se almacenan como string.
        /// </summary>
        public static void InsertOffers()
        {
            using (var context = new NaivyBeatsEntities())
            {
                if (context.Offer_dir.Any() || context.Offer_In.Any())
                    return;

                int validMusicianId = context.Musician
                    .Where(m => m.user_id > 0)
                    .Select(m => m.user_id)
                    .FirstOrDefault();
                if (validMusicianId == 0)
                    throw new Exception("No se encontró un Musician válido.");

                int validRestaurantId = context.Restaurant
                    .Where(r => r.user_id > 0)
                    .Select(r => r.user_id)
                    .FirstOrDefault();
                if (validRestaurantId == 0)
                    throw new Exception("No se encontró un Restaurant válido.");

                for (int i = 0; i < 5; i++)
                {
                    DateTime fechaEvento = new DateTime(2025, 4, 1).AddDays(i * 3);
                    var offerDir = new Offer_dir
                    {
                        publish_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        salary = 1000 + (i * 100),
                        event_date = fechaEvento.ToString("yyyy-MM-dd HH:mm:ss"),
                        agreement = 1,
                        done = 0,
                        restaurant_id = validRestaurantId,
                        musician_id = validMusicianId
                    };
                    context.Offer_dir.Add(offerDir);
                }

                for (int i = 0; i < 5; i++)
                {
                    DateTime fechaEvento = new DateTime(2025, 4, 1).AddDays(i * 3);
                    var offerIn = new Offer_In
                    {
                        publish_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        salary = 1000 + (i * 100),
                        event_date = fechaEvento.ToString("yyyy-MM-dd HH:mm:ss"),
                        music_id_final = validMusicianId,
                        restaurant_id = validRestaurantId
                    };
                    context.Offer_In.Add(offerIn);
                }

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Obtiene una lista de fechas de eventos a partir de Offer_dir y Offer_In.
        /// </summary>
        public static List<DateTime> GetEventDates()
        {
            using (var context = new NaivyBeatsEntities())
            {
                var offerDirDates = context.Offer_dir
                    .Where(o => o.agreement == 1 && o.done == 0 && o.event_date != null)
                    .AsEnumerable()
                    .Select(o => DateTime.Parse(o.event_date))
                    .ToList();

                var offerInDates = context.Offer_In
                    .Where(o => o.music_id_final != null && o.event_date != null)
                    .AsEnumerable()
                    .Select(o => DateTime.Parse(o.event_date))
                    .ToList();

                return offerDirDates.Concat(offerInDates).ToList();
            }
        }

        /// <summary>
        /// Obtiene la lista de eventos para una fecha específica.
        /// Convierte el event_date (string) a DateTime para su comparación y formateo.
        /// </summary>
        public static List<EventoInfo> ObtenerEventosConPosicion(DateTime fecha)
        {
            DateTime fechaSinHora = fecha.Date;
            List<EventoInfo> eventos = new List<EventoInfo>();

            using (var context = new NaivyBeatsEntities())
            {
                // Eventos de Offer_dir
                var eventosDir = (from o in context.Offer_dir
                                  join mu in context.Users on o.musician_id equals mu.user_id
                                  join ru in context.Users on o.restaurant_id equals ru.user_id
                                  where o.agreement == 1 && o.done == 0 && o.event_date != null
                                  select new
                                  {
                                      o.event_date,
                                      o.salary,
                                      Musico = mu.name,
                                      Local = ru.name
                                  })
                                  .AsEnumerable()
                                  .Where(o => DateTime.TryParse(o.event_date, out DateTime dt) && dt.Date == fechaSinHora)
                                  .Select(o => new EventoInfo
                                  {
                                      Musico = o.Musico,
                                      Local = o.Local,
                                      // Convertir el string a DateTime y luego formatearlo a string para su uso en el form
                                      Horario = DateTime.Parse(o.event_date).ToString("yyyy-MM-dd HH:mm:ss"),
                                      Salario = (int)o.salary
                                  })
                                  .ToList();

                // Eventos de Offer_In
                var eventosIn = (from o in context.Offer_In
                                 join mu in context.Users on o.music_id_final equals mu.user_id
                                 join ru in context.Users on o.restaurant_id equals ru.user_id
                                 where o.music_id_final != null && o.event_date != null
                                 select new
                                 {
                                     o.event_date,
                                     o.salary,
                                     Musico = mu.name,
                                     Local = ru.name
                                 })
                                 .AsEnumerable()
                                 .Where(o => DateTime.TryParse(o.event_date, out DateTime dt) && dt.Date == fechaSinHora)
                                 .Select(o => new EventoInfo
                                 {
                                     Musico = o.Musico,
                                     Local = o.Local,
                                     Horario = DateTime.Parse(o.event_date).ToString("yyyy-MM-dd HH:mm:ss"),
                                     Salario = (int)o.salary
                                 })
                                 .ToList();

                eventos = eventosDir.Concat(eventosIn)
                                     .OrderBy(e => DateTime.Parse(e.Horario))
                                     .ToList();
            }
            return eventos;
        }
    }
}
