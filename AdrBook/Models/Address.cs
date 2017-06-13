using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdrBook.Models
{
    public class Address
    {
        // id записи
        public int Id { get; set; }
        // Дата и время создания записи
        public DateTime DateCreate { get; set; }
        // Cтрана
        public String Country { get; set; }
        // Город
        public String City { get; set; }
        // Улица
        public String Street { get; set; }
        // Номер дома
        public int House { get; set; }
        // Индекс
        public String PostIndex { get; set; }
    }
}