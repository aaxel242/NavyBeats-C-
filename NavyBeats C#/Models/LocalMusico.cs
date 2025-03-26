using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavyBeats_C_.Models
{
    public static class LocalMusico
    {
        public static Restaurant SelectRestaurant()
        {
            Users movilUsers = UsuarioMovilOrm.SelectUsers();

            Restaurant _user =
                (Restaurant)(from user in Orm.bd.Restaurant
                    where movilUsers.user_id == user.user_id
                    select user).FirstOrDefault();

            return _user;
        }
    }
}
