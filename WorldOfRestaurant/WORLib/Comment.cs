using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORLib
{
    /// <summary>
    /// Коментарий позьзователя о ресторане
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// Кол-во лайков
        /// </summary>
        public int Likes { get; set; }

        /// <summary>
        /// Дата отправки
        /// </summary>
        public DateTime DateSend { get; set; }

        /// <summary>
        /// Сам коментарий
        /// </summary>
        public string Comment { get; set; }

        public Comment(string comment)
        {
            DateSend = DateTime.Now;
            Likes = 0;
            Comment = comment;
        }
    }
}
