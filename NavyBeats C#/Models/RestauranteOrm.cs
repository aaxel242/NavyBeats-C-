using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavyBeats_C_.Models
{
    public static class RestauranteOrm
    {
        public static Restaurant SelectRestaurant()
        {
            Restaurant _user =
                (from user in Orm.bd.Restaurant
                    select user).FirstOrDefault();

            return _user;
        }
    }
}