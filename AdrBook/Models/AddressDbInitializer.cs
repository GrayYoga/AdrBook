using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace AdrBook.Models
{
    public class AddressDbInitializer : DropCreateDatabaseAlways<AddressContext>
    {
        protected override void Seed(AddressContext db)
        {
            db.Addresses.Add(new Address { DateCreate = DateTime.Now, Country = "Россия", City = "Ульяновск", Street = "Маяковского", House = 1, PostIndex = "432071" });
            db.Addresses.Add(new Address { DateCreate = DateTime.Now, Country = "Россия", City = "Москва", Street = "Ленина", House = 5, PostIndex = "123000" });
            db.Addresses.Add(new Address { DateCreate = DateTime.Now, Country = "Россия", City = "Санкт-Петербург", Street = "Невский пр-т.", House = 14, PostIndex = "587235" });
            db.Addresses.Add(new Address { DateCreate = DateTime.Now, Country = "Россия", City = "Киев", Street = "Б. Хитрово", House = 48, PostIndex = "025874" });
            db.Addresses.Add(new Address { DateCreate = DateTime.Now, Country = "Россия", City = "Ульяновск", Street = "Любови Шевцовой", House = 54, PostIndex = "432025" });
            base.Seed(db);
        }
    }
}