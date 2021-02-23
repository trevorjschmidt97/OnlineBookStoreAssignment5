using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace OnlineBookstore.Models
{
    public class SeedData
    {
        // Checks the database from the startup file, if empty then it seeds the db
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookStoreDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookStoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95f
                    },

                     new Book
                     {
                         Title = "Team of Rivals",
                         AuthorFirstName = "Doris Kearns",
                         AuthorLastName = "Goodwin",
                         Publisher = "Simon & Schuster",
                         ISBN = "978-0743270755",
                         Classification = "Non-Fiction",
                         Category = "Biography",
                         Price = 14.58f
                     },

                     new Book
                     {
                         Title = "The Snowball",
                         AuthorFirstName = "Alice",
                         AuthorLastName = "Schroeder",
                         Publisher = "Bantam",
                         ISBN = "978-0553384611",
                         Classification = "Non-Fiction",
                         Category = "Biography",
                         Price = 21.54f
                     },

                     new Book
                     {
                         Title = "American Ulysses",
                         AuthorFirstName = "Ronald C.",
                         AuthorLastName = "White",
                         Publisher = "Random House",
                         ISBN = "978-0812981254",
                         Classification = "Non-Fiction",
                         Category = "Biography",
                         Price = 11.61f
                     },

                     new Book
                     {
                         Title = "Unbroken",
                         AuthorFirstName = "Laura",
                         AuthorLastName = "Hillenbrand",
                         Publisher = "Random House",
                         ISBN = "978-0812974492",
                         Classification = "Non-Fiction",
                         Category = "Historical",
                         Price = 13.33f
                     },

                     new Book
                     {
                         Title = "The Great Train Robbery",
                         AuthorFirstName = "Michael",
                         AuthorLastName = "Crichton",
                         Publisher = "Vintage",
                         ISBN = "978-0804171281",
                         Classification = "Fiction",
                         Category = "Historical Fiction",
                         Price = 15.95f
                     },

                     new Book
                     {
                         Title = "Deep Work",
                         AuthorFirstName = "Cal",
                         AuthorLastName = "Newport",
                         Publisher = "Grand Central Publishing",
                         ISBN = "978-1455586691",
                         Classification = "Non-Fiction",
                         Category = "Self-Help",
                         Price = 14.99f
                     },

                     new Book
                     {
                         Title = "It's Your Ship",
                         AuthorFirstName = "Michael",
                         AuthorLastName = "Abrashoff",
                         Publisher = "Grand Central Publishing",
                         ISBN = "978-1455523023",
                         Classification = "Non-Fiction",
                         Category = "Self-Help",
                         Price = 21.66f
                     },

                     new Book
                     {
                         Title = "The Virgin Way",
                         AuthorFirstName = "Richard",
                         AuthorLastName = "Branson",
                         Publisher = "Portfolio",
                         ISBN = "978-1591847984",
                         Classification = "Non-Fiction",
                         Category = "Business",
                         Price = 29.16f
                     },

                     new Book
                     {
                         Title = "Sycamore Row",
                         AuthorFirstName = "John",
                         AuthorLastName = "Grisham",
                         Publisher = "Bantam",
                         ISBN = "978-0553393613",
                         Classification = "Fiction",
                         Category = "Thrillers",
                         Price = 15.03f
                     }
                );

                context.SaveChanges();
            }
        }
    }
}
