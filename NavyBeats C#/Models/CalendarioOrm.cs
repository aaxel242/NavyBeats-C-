using System;
using System.Linq;

namespace NavyBeats_C_.Models
{
    public static class CalendarioOrm
    {
        /// <summary>
        /// Inserta 10 ofertas de prueba en la tabla Offer_dir.
        /// Solo se insertan si no existen registros previos.
        /// </summary>
        public static void InsertOffers()
        {
            // Usar el contexto correcto (asegúrate de que el nombre coincide: "dam04Entities")
            using (var context = new dam04Entities())
            {
                // Evitar duplicar la inserción si ya existen ofertas
                if (context.Offer_dir.Any())
                    return;

                for (int i = 0; i < 10; i++)
                {
                    // Fecha de evento: Comenzando el 1 de abril de 2025 y sumándole 5 días por cada iteración.
                    DateTime fechaEvento = new DateTime(2025, 4, 1).AddDays(i * 5);

                    // Usamos un musician_id válido (por ejemplo, 1) y un restaurant_id válido (por ejemplo, 1)
                    var offer = new Offer_dir
                    {
                        publish_date = DateTime.Now,
                        salary = 1000 + (i * 100),
                        event_date = fechaEvento,
                        agreement = 1,  // Asegúrate de que la propiedad es de tipo string
                        done = 0,                       // Asegúrate de que la propiedad es de tipo bool
                        restaurant_id = 1,                  // Asigna un valor que exista en la tabla Restaurant
                        musician_id = 1                     // Asigna un valor que exista en la tabla Musician
                    };

                    context.Offer_dir.Add(offer);
                }
                context.SaveChanges();
            }
        }
    }
}
