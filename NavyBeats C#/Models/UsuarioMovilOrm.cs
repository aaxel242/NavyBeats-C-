using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavyBeats_C_.Models
{
    public class Musico
    {
        public int user_id { get; set; }
        public string name { get; set; }
        public string photo { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int phone_number { get; set; }
        public string municipality { get; set; }
    }

    public class Restaurante
    {
        public int user_id { get; set; }
        public string name { get; set; }
        public string photo { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int phone_number { get; set; }
        public string municipality { get; set; }
        public Nullable<decimal> latitud { get; set; }
        public Nullable<decimal> longitud { get; set; }
    }


    public static class UsuarioMovilOrm
    {
        public static Users SelectUsers()
        {
            Users _user =
                (Users)(from user in Orm.bd.Users
                    select user).FirstOrDefault();

            return _user;
        }
    }
}