using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORLib
{
    /// <summary>
    /// Класс Пользователя
    /// </summary>
    public class User : Entity
    {
        /// <summary>
        /// Логин
        /// </summary>
        string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        string Password { get; set; }

        public User() : base()
        {
            Login = "undefined";
            Password = "undefined";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
