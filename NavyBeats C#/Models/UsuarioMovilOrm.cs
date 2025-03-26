using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavyBeats_C_.Models
{
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