using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStore.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Кобзар", Author = "Т.Г. Шевченко", Price = 220 });
            db.Books.Add(new Book { Name = "Зона покриття", Author = "Стівен Кінг", Price = 180 });
            db.Books.Add(new Book { Name = "Сяйво", Author = "Стівен Кінг", Price = 200 });
            db.Books.Add(new Book { Name = "Захар Беркут", Author = "Іван Франко", Price = 160 });
            base.Seed(db);
        }
    }
}