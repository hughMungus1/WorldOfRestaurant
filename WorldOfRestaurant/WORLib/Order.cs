using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORLib
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order : Entity
    {
        /// <summary>
        /// ID элементов меню
        /// </summary>
        public List<Guid> MenuItemsId { get; set; }

        /// <summary>
        /// Полная цена заказа
        /// </summary>
        public string Discription { get; set; }

        public Order()
        {
            MenuItemsId = new List<Guid>();
        }
    }
}
