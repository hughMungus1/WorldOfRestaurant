using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORLib
{
    /// <summary>
    /// Класс для ресторана
    /// </summary>
    public class Restaurant : Entity
    {
        /// <summary>
        /// Название ресторана
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Рейтинг ресторана
        /// </summary>
        public int Raiting { get; private set; }

        /// <summary>
        /// Список MenuItem, который является меню;
        /// </summary>
        public List<MenuItem> MenuItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Название</param>
        public Restaurant(string name) : base()
        {
            Name = name;
            Raiting = 0;
            MenuItems = new List<MenuItem>();
        }
    }
}
