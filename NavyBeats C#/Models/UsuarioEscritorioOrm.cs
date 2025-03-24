using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static List<Super_User>SelectUsers()
        {
            List<Super_User> _users =
                (from user in Orm.bd.Super_User
                 select user).ToList();

            return _users;
        }

        public static void Insert(Super_User _user)
        {
            Orm.bd.Super_User.Add(_user);
            Orm.bd.SaveChanges();
        }
    }
}
