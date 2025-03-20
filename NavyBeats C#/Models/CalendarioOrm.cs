using System;
using System.Collections.Generic;
using System.Linq;

namespace NavyBeats_C_.Models
{
    public static class CalendarioOrm
    {
        // Inserta 10 ofertas de prueba si no hay ninguna oferta en la base de datos
        public static void InsertDummyOffers()
        {
            using (var context = new Dam04Entities())
            {
                // Si ya existen ofertas, no inserta de nuevo
                if (context.Offer_dir.Any())
                    return;

                // Crear 10 ofertas de prueba con diferentes fechas de evento
                for (int i = 0; i < 10; i++)
                {
                    var offer = new Offer_dir
                    {
                        publish_date = DateTime.Now,
                        salary = 1000 + (i * 100),
                        // Asigna fechas de evento diferentes: el 1 de abril de 2025 + 5*i días
                        event_date = new DateTime(2025, 4, 1).AddDays(i * 5),
                        agreement = $"Agreement {i + 1}",
                        done = false,
                        restaurant_id = i + 1,
                        // Se asigna un musician_id (no nulo) para simular que hay un músico asociado.
                        musician_id = 101 + i
                    };
                    context.Offer_dir.Add(offer);
                }
                context.SaveChanges();
            }
        }

        // Retorna todas las ofertas donde musician_id no es null
        public static List<Offer_dir> GetOffers()
        {
            using (var context = new Dam04Entities())
            {
                return context.Offer_dir
                              .Where(o => o.musician_id != null)
                              .ToList();
            }
        }
    }
}
