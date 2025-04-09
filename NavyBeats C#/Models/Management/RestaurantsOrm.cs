using System;
using System.Collections.Generic;
using System.Linq;

namespace NavyBeats_C_.Models
{
    public static class RestaurantsOrm
    {
        // Obtiene todos los restaurantes (usuarios que son locales)
        public static List<Users> GetRestaurants()
        {
            using (var context = new dam04Entities())
            {
                var restaurants = (from r in context.Restaurant
                                   join u in context.Users on r.user_id equals u.user_id
                                   orderby u.name
                                   select u).ToList();
                return restaurants;
            }
        }

        // Obtiene un restaurante por su ID
        public static Users GetRestaurantById(int userId)
        {
            using (var context = new dam04Entities())
            {
                var restaurant = (from r in context.Restaurant
                                  join u in context.Users on r.user_id equals u.user_id
                                  where u.user_id == userId
                                  select u).FirstOrDefault();
                return restaurant;
            }
        }

        // Obtiene la información detallada de los restaurantes
        public static List<RestaurantInfo> GetRestaurantInfoList()
        {
            using (var context = new dam04Entities())
            {
                var query = from r in context.Restaurant
                            join u in context.Users on r.user_id equals u.user_id
                            join mun in context.Municipality on u.municipality_id equals mun.municipality_id
                            orderby u.name
                            select new RestaurantInfo
                            {
                                UserId = u.user_id,
                                Name = u.name,
                                Municipality = mun.name,
                                Email = u.email,
                                // Dado que en la BD se almacenan como varchar, se obtienen directamente
                                OpeningTime = r.opening_time,
                                ClosingTime = r.closing_time,
                                Latitud = (double?)u.latitud,
                                Longitud = (double?)u.longitud
                            };
                return query.ToList();
            }
        }
    }
}
