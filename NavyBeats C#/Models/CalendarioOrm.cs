using System;
using System.Collections.Generic;
using System.Linq;

namespace NavyBeats_C_.Models
{
    public static class CalendarioOrm
    {
        /// <summary>
        /// Inserta 5 ofertas de prueba en las tablas Offer_dir y Offer_In.
        /// Se insertan solo si no existen ofertas previas.
        /// Se utilizan valores válidos para musician_id y restaurant_id consultando la base de datos.
        /// Requisitos:
        ///   - En Offer_dir: done = 0 y agreement = 1.
        ///   - En Offer_In: music_id_final no nulo.
        /// </summary>
        public static void InsertOffers()
        {
            using (var context = new dam04Entities())
            {
                // Evitar duplicar la inserción si ya existen ofertas
                if (context.Offer_dir.Any() || context.Offer_In.Any())
                    return;

                // Obtener un musician_id válido (ignorando valores 0)
                int validMusicianId = context.Musician
                    .Where(m => m.user_id > 0)
                    .Select(m => m.user_id)
                    .FirstOrDefault();
                if (validMusicianId == 0)
                    throw new Exception("No se encontró un Musician válido en la base de datos.");

                // Obtener un restaurant_id válido (ignorando valores 0)
                int validRestaurantId = context.Restaurant
                    .Where(r => r.user_id > 0)
                    .Select(r => r.user_id)
                    .FirstOrDefault();
                if (validRestaurantId == 0)
                    throw new Exception("No se encontró un Restaurant válido en la base de datos.");

                // Insertar 5 ofertas en Offer_dir
                for (int i = 0; i < 5; i++)
                {
                    // Fecha de evento: 1 de abril de 2025 + (3 * i) días para variar los días
                    DateTime fechaEvento = new DateTime(2025, 4, 1).AddDays(i * 3);

                    var offerDir = new Offer_dir
                    {
                        publish_date = DateTime.Now,
                        salary = 1000 + (i * 100),
                        event_date = fechaEvento,
                        agreement = 1,    // tinyint: 1 (evento programado)
                        done = 0,         // tinyint: 0 (no realizado)
                        restaurant_id = validRestaurantId,
                        musician_id = validMusicianId
                    };

                    context.Offer_dir.Add(offerDir);
                }
         
                
                // Insertar 5 ofertas en Offer_In
                for (int i = 0; i < 5; i++)
                {
                    // Usar la misma fecha para relacionar la oferta (puedes ajustar si lo prefieres)
                    DateTime fechaEvento = new DateTime(2025, 4, 1).AddDays(i * 3);

                    var offerIn = new Offer_In
                    {
                        publish_date = DateTime.Now,
                        salary = 1000 + (i * 100),
                        event_date = fechaEvento,   
                        music_id_final = validMusicianId, // valor no nulo, indica que hay acuerdo
                        restaurant_id = validRestaurantId
                    };

                    context.Offer_In.Add(offerIn);
                }

                context.SaveChanges();
            }
        }
        /// <summary>
        /// Obtiene las fechas de eventos activos a partir de Offer_dir (agreement = 1 y done = 0)
        /// y de Offer_In (donde music_id_final no es nulo), eliminando duplicados.
        /// </summary>
        /// <returns>Lista de fechas de eventos (DateTime).</returns>
        public static List<DateTime> GetEventDates()
        {
            using (var context = new dam04Entities())
            {
                var offerDirDates = context.Offer_dir
                    .Where(o => o.agreement == 1 && o.done == 0 && o.event_date != null)
                    .Select(o => o.event_date.Value) // Convertir DateTime? a DateTime
                    .ToList();

                var offerInDates = context.Offer_In
                    .Where(o => o.music_id_final != null && o.event_date != null)
                    .Select(o => o.event_date.Value) // Convertir DateTime? a DateTime
                    .ToList();

                // Concatenar las fechas de ambas tablas sin eliminar duplicados
                return offerDirDates.Concat(offerInDates).ToList();
            }
        }


        private List<string> ObtenerEventosDelDia(DateTime fecha)
        {
            List<string> eventos = new List<string>();

            using (var context = new dam04Entities())
            {
                var eventosDir = context.Offer_dir
                    .Where(o => o.event_date.Value.Date == fecha.Date && o.agreement == 1 && o.done == 0)
                    .Select(o => new
                    {
                        Musico = o.Musician.name,
                        Local = o.Local.name,
                        Horario = o.event_date,
                        Salario = o.salary
                    }).ToList();

                var eventosIn = context.Offer_In
                    .Where(o => o.event_date.Value.Date == fecha.Date && o.music_id_final != null)
                    .Select(o => new
                    {
                        Musico = o.Musician.name,
                        Local = o.Local.name,
                        Horario = o.event_date,
                        Salario = o.salary
                    }).ToList();

                // Combinar ambas listas en una sola
                foreach (var evento in eventosDir.Concat(eventosIn))
                {
                    eventos.Add($"Músico: {evento.Musico}\n" +
                                $"Local: {evento.Local}\n" +
                                $"Horario: {evento.Horario.Value.ToString("HH:mm")}\n" +
                                $"Salario: {evento.Salario}€");
                }
            }

            return eventos;
        }
    }
}