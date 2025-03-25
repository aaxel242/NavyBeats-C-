using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
                 where user.delete_at == null
                 select user).ToList();

            return _users;
        }

        public static bool Insert(Super_User _user)
        {
            bool insert;

            Orm.bd.Super_User.Add(_user);
            Orm.bd.SaveChanges();

            insert = true;

            return insert;
        }

        public static bool Delete(int _id)
        {
            bool delete;

            var user = selectById(_id);

            if (user != null)
            {
                user.delete_at = DateTime.Today;

                Orm.bd.SaveChanges();
            }

            delete = true;

            return delete;
        }

        public static Super_User selectById (int _id)
        {
            Super_User _user =
                (Super_User) (from user in Orm.bd.Super_User
                    where user.user_id_admin == _id
                    select user).FirstOrDefault();

            return _user;
        }
    }
}
