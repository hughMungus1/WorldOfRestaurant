using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORLib
{
    /// <summary>
    /// Посетитель ресторана
    /// </summary>
    public class ClientUser : User
    {
        /// <summary>
        /// Имя
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Номер карты
        /// </summary>
        string CardNumber { get; set; }

        public ClientUser() : base()
        {
            Name = "undefined";
            LastName = "undefined";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <param name="name">Имя</param>
        /// <param name="lastName">Фамилия</param>
        public ClientUser(string login, string password, string name, string lastName)
            : base(login, password)
        {
            Name = name;
            LastName = lastName;
        }
    }
}
