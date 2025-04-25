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
        public string phone_number { get; set; }
        public string municipality { get; set; }
        public Nullable<decimal> latitud { get; set; }
        public Nullable<decimal> longitud { get; set; }
    }

    public class Restaurante
    {
        public int user_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phone_number { get; set; }
        public string municipality { get; set; }
        public double? latitud { get; set; }
        public double? longitud { get; set; }
        public string opening_time { get; set; }
        public string closing_time { get; set; }
    }

    public static class UsuarioMovilOrm
    {
        /// <summary>
        /// Obtiene la lista de musicos de la base de datos.
        /// </summary>
        /// <returns></returns>
        public static List<Musico> SelectMusician()
        {
            List<Musico> _musician = (from user in Orm.bd.Users
                             join muni in Orm.bd.Municipality on user.municipality_id equals muni.municipality_id into municipalityJoin
                             from municipality in municipalityJoin.DefaultIfEmpty()
                             join mus in Orm.bd.Musician on user.user_id equals mus.user_id
                             where user.deleted_at == null
                             select new Musico
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

            return _musician;
        }

        /// <summary>
        /// Obtiene la lista de restaurantes de la base de datos.
        /// </summary>
        /// <returns></returns>
        public static List<Restaurante> SelectRestaurant()
        {
            List<Restaurante> _restaurant = (from user in Orm.bd.Users
                                      join muni in Orm.bd.Municipality on user.municipality_id equals muni.municipality_id into municipalityJoin
                                      from municipality in municipalityJoin.DefaultIfEmpty()
                                      join res in Orm.bd.Restaurant on user.user_id equals res.user_id
                                      where user.deleted_at == null
                                      select new Restaurante
                                      {
                                          user_id = user.user_id,
                                          name = user.name,
                                          email = user.email,
                                          password = user.password,
                                          phone_number = user.phone_number,
                                          municipality = municipality != null ? municipality.name : "Sin ciudad",
                                          latitud = (double?)user.latitud,
                                          longitud = (double?)user.longitud,
                                          opening_time = res.opening_time,
                                          closing_time = res.closing_time
                                      })
                             .ToList();

            return _restaurant;
        }

        /// <summary>
        /// Obtiene un usuario por su ID.
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public static Users SelectUserById(int _id)
        {
            Users _user =
                (from user in Orm.bd.Users
                 where user.user_id == _id
                           select user).FirstOrDefault();

            return _user;
        }

        /// <summary>
        /// Obtiene un músico por su ID.
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public static Musician SelectMusicianById(int _id)
        {
            Musician _user =
                (from user in Orm.bd.Musician
                    where user.user_id == _id
                 select user).FirstOrDefault();

            return _user;
        }

        /// <summary>
        /// Obtiene un restaurante por su ID.
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public static Restaurant SelectRestaurantById(int _id)
        {
            Restaurant _user =
                (from user in Orm.bd.Restaurant
                             where user.user_id == _id
                           select user).FirstOrDefault();

            return _user;
        }

        /// <summary>
        /// Obtiene un músico con su latitud y longitud basado en el user_id.
        /// </summary>
        /// <param name="userId">El ID del músico.</param>
        /// <returns>El usuario con sus coordenadas o null si no existe.</returns>
        public static Users SelectMusicianByIdFromUsers(int userId)
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
        /// Obtiene un restaurante con su latitud y longitud basado en el user_id.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static Users SelectRestaurantByIdFromUsers(int userId)
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

        /// <summary>
        /// Inserta un nuevo usuario en la base de datos.
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        public static int InsertUser(Users _user)
        {
            Orm.bd.Users.Add(_user);
            Orm.bd.SaveChanges();

            return _user.user_id;
        }

        /// <summary>
        /// Inserta un nuevo músico en la base de datos.
        /// </summary>
        /// <param name="_user"></param>
        /// <param name="styles"></param>
        /// <returns></returns>
        public static bool InsertMusician(Musician _user, List<Style> styles)
        {
            bool insert;

            Orm.bd.Musician.Add(_user);
            Orm.bd.SaveChanges();

            foreach (var style in styles)
            {
                bool exists = Orm.bd.User_Style.Any(us => us.user_id == _user.user_id && us.style_id == style.style_id);
                if (!exists)
                {
                    User_Style userStyle = new User_Style
                    {
                        user_id = _user.user_id,
                        style_id = style.style_id,
                        creation_date = DateTime.Now
                    };
                    Orm.bd.User_Style.Add(userStyle);
                }
            }
            Orm.bd.SaveChanges();

            insert = true;

            return insert;
        }

        /// <summary>
        /// Inserta un nuevo restaurante en la base de datos.
        /// </summary>
        /// <param name="_restaurant"></param>
        /// <returns></returns>
        public static bool InsertRestaurant(Restaurant _restaurant)
        {
            bool insert;

            Orm.bd.Restaurant.Add(_restaurant);
            Orm.bd.SaveChanges();

            insert = true;

            return insert;
        }

        /// <summary>
        /// Actualiza un usuario existente en la base de datos.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="newUser"></param>
        /// <returns></returns>
        public static int UpdateUser(Users user, Users newUser) 
        {
            int id = user.user_id;
            if (user != null)
            {
                user.name = newUser.name;
                user.phone_number = newUser.phone_number;
                user.email = newUser.email;
                user.municipality_id = newUser.municipality_id;
                user.password = newUser.password;
                user.latitud = newUser.latitud;
                user.longitud = newUser.longitud;
                user.edition_date = DateTime.Today.ToString();

                Orm.bd.SaveChanges();
            }

            return id;
        }

        /// <summary>
        /// Actualiza un músico existente en la base de datos.
        /// </summary>
        /// <param name="musician"></param>
        /// <param name="newMusician1"></param>
        /// <param name="styles"></param>
        /// <returns></returns>
        public static bool UpdateMusician(Musician musician, Musician newMusician1, List<Style> styles)
        {
            bool update;

            if (musician != null)
            {
                
                var existingStyles = Orm.bd.User_Style.Where(mus => mus.user_id == musician.user_id).ToList();
                foreach (var existingStyle in existingStyles)
                {
                    Orm.bd.User_Style.Remove(existingStyle);
                }

                foreach (var style in styles)
                {
                    User_Style userStyle = new User_Style
                    {
                        user_id = musician.user_id,
                        style_id = style.style_id,
                        creation_date = DateTime.Now
                    };
                    Orm.bd.User_Style.Add(userStyle);
                }

                Orm.bd.SaveChanges();
            }

            update = true;

            return update;
        }

        /// <summary>
        /// Actualiza un restaurante existente en la base de datos.
        /// </summary>
        /// <param name="restaurant"></param>
        /// <param name="newRestaurant"></param>
        /// <returns></returns>
        public static bool UpdateRestaurant(Restaurant restaurant, Restaurant newRestaurant)
        {
            bool update;

            if (restaurant != null)
            {
                restaurant.opening_time = newRestaurant.opening_time;
                restaurant.closing_time = newRestaurant.closing_time;
                Orm.bd.SaveChanges();
            }

            update = true;

            return update;
        }

        /// <summary>
        /// Elimina un usuario de la base de datos actualizando su atributo deleted_at.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool Delete(Users user)
        {
            bool delete;

            if (user != null)
            {
                user.deleted_at = DateTime.Today.ToString();

                Orm.bd.SaveChanges();
            }

            delete = true;

            return delete;
        }
    }
}