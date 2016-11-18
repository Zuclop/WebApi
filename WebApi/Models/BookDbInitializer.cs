using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApi.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            var genre1 = new Genre() { Name = "Романы" };
            var genre2 = new Genre() { Name = "Детективы" };
            var genre3 = new Genre() { Name = "Фэнтези" };
            var book1 = new Book { Name = "Война и мир", Author = "Л. Толстой", Year = 1863, PublishingHouse = "Москва Печать", genre = genre1 };
            var book2 = new Book { Name = "Отцы и дети", Author = "И. Тургенев", Year = 1862, PublishingHouse = "Киев Печать", genre = genre2 };
            var book3 = new Book { Name = "Чайка", Author = "А. Чехов", Year = 1896, PublishingHouse = "Днепр Печать", genre = genre1 };

            db.Genres.Add(genre1);
            db.Genres.Add(genre2);
            db.Genres.Add(genre3);
            db.Books.Add(book1);
            db.Books.Add(book2);
            db.Books.Add(book3);

            base.Seed(db);
        }
    }
}