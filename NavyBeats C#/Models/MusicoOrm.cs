using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavyBeats_C_.Models
{
    public static class MusicoOrm
    {
        public static Musician SelectMusician()
        {
            Musician _user =
                (Musician)(from user in Orm.bd.Musician
                    select user).FirstOrDefault();

            return _user;
        }
    }
}