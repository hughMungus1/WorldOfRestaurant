using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORLib
{
    /// <summary>
    /// Работник ресторана. Может редактировать меню ресторана
    /// </summary>
    public class EmployeeUser : User
    {
        public List<Guid> RestaurantsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="restaurant">Ресторан в котором работает</param>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        public EmployeeUser(Restaurant restaurant, string login, string password)
            : base(login, password)
        {
            RestaurantsId = new List<Guid>();
        }
    }
}
