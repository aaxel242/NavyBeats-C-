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
            var user = (from u in Orm.bd.Super_User
                        where u.email == email && u.password == psswd
                        select u).FirstOrDefault();

            if (user != null)
            {
                return new Super_User
                {
                    user_id_admin = user.user_id_admin,
                    name = user.name,
                    email = user.email,
                    password = user.password,
                    role = user.role
                };
            }

            return null;
        }

        public static List<Super_User> SelectUsers()
        {
            List<Super_User> _users =
                (from user in Orm.bd.Super_User
                 where user.delete_at == null
                 select user).ToList();

            return _users;
        }

        public static Super_User SelectById(int _id)
        {
            Super_User _user =
                (Super_User)(from user in Orm.bd.Super_User
                             where user.user_id_admin == _id 
                             select user).FirstOrDefault();

            return _user;
        }


        public static bool Insert(Super_User _user)
        {
            bool insert;

            Orm.bd.Super_User.Add(_user);
            Orm.bd.SaveChanges();

            insert = true;

            return insert;
        }

        public static bool Delete(Super_User user)
        {
            bool delete;

            if (user != null)
            {
                user.delete_at = DateTime.Today.ToString();

                Orm.bd.SaveChanges();
            }

            delete = true;

            return delete;
        }

        public static bool Update(Super_User user, Super_User newUser)
        {
            bool update = false;

            if (user != null)
            {
                user.name = newUser.name;
                user.password = newUser.password;
                user.email = newUser.email;
                user.role = newUser.role;

                Orm.bd.SaveChanges();
                update = true;
            }

            return update;
        }



    }
}
