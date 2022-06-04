namespace BooksAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BooksAPI.Data.BooksAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

      protected override void Seed(BooksAPI.Data.BooksAPIContext context)
      {
         context.Authors.AddOrUpdate(new Models.Author[] {
        new Models.Author() { AuthorId = 1, Name = "Ralls, Kim" },
        new Models.Author() { AuthorId = 2, Name = "Corets, Eva" },
        new Models.Author() { AuthorId = 3, Name = "Randall, Cynthia" },
        new Models.Author() { AuthorId = 4, Name = "Thurman, Paula" }
        });

         context.Books.AddOrUpdate(new Models.Book[] {
        new Models.Book() { BookId = 1,  Title= "Midnight Rain", Genre = "Fantasy",
        PublishDate = new DateTime(2000, 12, 16), AuthorId = 1, Description =
        "A former architect battles an evil sorceress.", Price = 14.95M },

        new Models.Book() { BookId = 2, Title = "Maeve Ascendant", Genre = "Fantasy",
            PublishDate = new DateTime(2000, 11, 17), AuthorId = 2, Description =
            "After the collapse of a nanotechnology society, the young" +
            "survivors lay the foundation for a new society.", Price = 12.95M },

        new Models.Book() { BookId = 3, Title = "The Sundered Grail", Genre = "Fantasy",
            PublishDate = new DateTime(2001, 09, 10), AuthorId = 2, Description =
            "The two daughters of Maeve battle for control of England.", Price = 12.95M },

        new Models.Book() { BookId = 4, Title = "Lover Birds", Genre = "Romance",
            PublishDate = new DateTime(2000, 09, 02), AuthorId = 3, Description =
            "When Carla meets Paul at an ornithology conference, tempers fly.", Price = 7.99M },

        new Models.Book() { BookId = 5, Title = "Splish Splash", Genre = "Romance",
            PublishDate = new DateTime(2000, 11, 02), AuthorId = 4, Description =
            "A deep sea diver finds true love 20,000 leagues beneath the sea.", Price = 6.99M},
    });
      }
   }
}
