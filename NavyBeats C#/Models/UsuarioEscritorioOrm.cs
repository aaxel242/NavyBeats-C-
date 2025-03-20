using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavyBeats_C_.Models
{
    public static class UsuarioEscritorioOrm
    {
        public static Super_User SelectLogin(string email, string psswd)
        {
            Super_User _user =
                (Super_User)(from user in Orm.bd.Super_User
                    where user.email == email && user.password == psswd
                    select user).FirstOrDefault();

            return _user;
        }
    }
}
