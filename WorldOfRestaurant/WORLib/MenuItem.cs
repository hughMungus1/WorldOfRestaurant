using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORLib
{
    /// <summary>
    /// Элемент меню
    /// </summary>
    public class MenuItem : Entity
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Discription { get; set; }

        /// <summary>
        /// Рейтинг
        /// </summary>
        public int Raiting { get; private set; }

        /// <summary>
        /// Цена
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="discription">Описание</param>
        /// <param name="price">Цена</param>
        public MenuItem(string name, string discription = "discription", int price = 0)
            : base()
        {
            Name = name;
            Discription = discription;
            Price = price;
            Raiting = 0;
        }
    }
}
