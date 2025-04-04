using System;
using System.Collections.Generic;
using System.Linq;

namespace NavyBeats_C_.Models
{
    public static class RestaurantsOrm
    {
        // Método para obtener todos los restaurantes
        public static List<Users> GetRestaurants()
        {
            using (var context = new NavyBeatsEntities())
            {
                var restaurants = (from r in context.Restaurant
                                   join u in context.Users on r.user_id equals u.user_id
                                   orderby u.name
                                   select u).ToList();
                return restaurants;
            }
        }

        // Método para obtener un restaurante por su ID
        public static Users GetRestaurantById(int userId)
        {
            using (var context = new NavyBeatsEntities())
            {
                var restaurant = (from r in context.Restaurant
                                  join u in context.Users on r.user_id equals u.user_id
                                  where u.user_id == userId
                                  select u).FirstOrDefault();
                return restaurant;
            }
        }

        // Método para obtener la información detallada de los restaurantes
        public static List<RestaurantInfo> GetRestaurantInfoList()
        {
            using (var context = new NavyBeatsEntities())
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
                                OpeningTime = r.opening_time.HasValue ? r.opening_time.Value : (TimeSpan?)null,
                                ClosingTime = r.closing_time.HasValue ? r.closing_time.Value : (TimeSpan?)null,
                                Latitud = (double?)u.latitud,
                                Longitud = (double?)u.longitud
                            };
                return query.ToList();
            }
        }
    }
}
