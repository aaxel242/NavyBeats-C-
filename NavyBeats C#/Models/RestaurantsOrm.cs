using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavyBeats_C_.Models
{
    class RestaurantsOrm
    {
        public static List<Users> GetRestaurants()
        {
            using (var context = new NaivyBeatsEntities())
            {
                var restaurants = (from r in context.Restaurant
                                 join u in context.Users on r.user_id equals u.user_id
                                 orderby u.name
                                 select u).ToList();
                return restaurants;
            }
        }
        public static Users GetRestaurantById(int userId)
        {
            using (var context = new NaivyBeatsEntities())
            {
                var restaurant = (from r in context.Restaurant
                                  join u in context.Users on r.user_id equals u.user_id
                                  where u.user_id == userId
                                  select u).FirstOrDefault();
                return restaurant;
            }
        }

        public static List<RestaurantInfo> GetRestaurantInfoList()
        {
            using (var context = new NaivyBeatsEntities())
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
                                //OpeningTime = r.opening_time,
                                //ClosingTime = r.closing_time,
                                Latitud = (double?)u.latitud,  
                                Longitud = (double?)u.longitud 
                            };
                return query.ToList();
            }
        }

    }
}