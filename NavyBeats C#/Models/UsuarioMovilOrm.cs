using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace NavyBeats_C_.Models
{
    public class Musico
    {
        public int user_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int phone_number { get; set; }
        public string municipality { get; set; }
    }

    public class Restaurante
    {
        public int user_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int phone_number { get; set; }
        public string municipality { get; set; }
        public Nullable<decimal> latitud { get; set; }
        public Nullable<decimal> longitud { get; set; }
        public System.TimeSpan opening_time { get; set; }
        public System.TimeSpan closing_time { get; set; }
    }

    public static class UsuarioMovilOrm
    {
        public static List<Musico> SelectMusician()
        {
            List<Musico> _musician = (from user in Orm.bd.Users
                             join muni in Orm.bd.Municipality on user.municipality_id equals muni.municipality_id into municipalityJoin
                             from municipality in municipalityJoin.DefaultIfEmpty()
                             join mus in Orm.bd.Musician on user.user_id equals mus.user_id
                             select new Musico
                             {
                                 user_id = user.user_id,
                                 name = user.name,
                                 email = user.email,
                                 password = user.password,
                                 phone_number = user.phone_number,
                                 municipality = municipality != null ? municipality.name : "Sin ciudad"
                             })
                             .ToList();

            return _musician;
        }

        public static List<Restaurante> SelectRestaurant()
        {
            List<Restaurante> _restaurant = (from user in Orm.bd.Users
                                      join muni in Orm.bd.Municipality on user.municipality_id equals muni.municipality_id into municipalityJoin
                                      from municipality in municipalityJoin.DefaultIfEmpty()
                                      join res in Orm.bd.Restaurant on user.user_id equals res.user_id
                                      select new Restaurante
                                      {
                                          user_id = user.user_id,
                                          name = user.name,
                                          email = user.email,
                                          password = user.password,
                                          phone_number = user.phone_number,
                                          municipality = municipality != null ? municipality.name : "Sin ciudad",
                                          latitud = user.latitud,
                                          longitud = user.longitud
                                      })
                             .ToList();

            return _restaurant;
        }
    }
}