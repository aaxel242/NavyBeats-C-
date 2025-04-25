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
        /// <summary>
        /// Selecciona un usuario de la base de datos basado en su email y contraseña.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="psswd"></param>
        /// <returns></returns>
        public static Super_User SelectLogin(string email, string psswd)
        {
            Super_User _user =
                (from user in Orm.bd.Super_User
                    where user.email == email && user.password == psswd
                    select user).FirstOrDefault();

            if (_user != null)
            {
                return new Super_User
                {
                    user_id_admin = _user.user_id_admin,
                    name = _user.name,
                    email = _user.email,
                    password = _user.password,
                    role = _user.role
                };
            }

            return null;
        }

        /// <summary>
        /// Selecciona todos los usuarios de la base de datos.
        /// </summary>
        /// <returns></returns>
        public static List<Super_User> SelectUsers()
        {
            List<Super_User> _users =
                (from user in Orm.bd.Super_User
                 where user.delete_at == null
                 select user).ToList();

            return _users;
        }

        /// <summary>
        /// Selecciona un usuario de la base de datos basado en su ID.
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public static Super_User SelectById(int _id)
        {
            Super_User _user =
                (from user in Orm.bd.Super_User
                             where user.user_id_admin == _id
                             select user).FirstOrDefault();

            return _user;
        }

        /// <summary>
        /// Inserta un nuevo usuario en la base de datos.
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        public static bool Insert(Super_User _user)
        {
            bool insert;

            Orm.bd.Super_User.Add(_user);
            Orm.bd.SaveChanges();

            insert = true;

            return insert;
        }

        /// <summary>
        /// Elimina un usuario de la base de datos.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Actualiza un usuario en la base de datos.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="newUser"></param>
        /// <returns></returns>
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
