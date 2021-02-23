﻿using System;
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
                        Price = 9.95f,
                        Pages = 1488
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
                         Price = 14.58f,
                         Pages = 944
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
                         Price = 21.54f,
                         Pages = 832
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
                         Price = 11.61f,
                         Pages = 864
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
                         Price = 13.33f,
                         Pages = 528
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
                         Price = 15.95f,
                         Pages = 288
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
                         Price = 14.99f,
                         Pages = 304
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
                         Price = 21.66f,
                         Pages = 240
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
                         Price = 29.16f,
                         Pages = 400
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
                         Price = 15.03f,
                         Pages = 642
                     },

                     new Book
                     {
                         Title = "The Book of Mormon, Another Testament of Jesus Christ",
                         AuthorFirstName = "Ancient",
                         AuthorLastName = "Prophets",
                         Publisher = "The Church of Jesus Christ of Latter Day Saints",
                         ISBN = "978-0385513166",
                         Classification = "Non-Fiction",
                         Category = "Thrillers",
                         Price = 3.21f,
                         Pages = 238
                     },

                     new Book
                     {
                         Title = "Runny Babbit",
                         AuthorFirstName = "Shel",
                         AuthorLastName = "Silverstein",
                         Publisher = "Harper Festival",
                         ISBN = "978-0060256531",
                         Classification = "Sook",
                         Category = "Billy",
                         Price = 17.49f,
                         Pages = 96
                     },

                     new Book
                     {
                         Title = "Pro ASP.NET Core 3: Develop Cloud-Ready Web Applications Using MVC, Blazor",
                         AuthorFirstName = "Adam",
                         AuthorLastName = "Freeman",
                         Publisher = "Apress",
                         ISBN = "978-1484254400",
                         Classification = "Information",
                         Category = "Thrillers",
                         Price = 62.39f,
                         Pages = 1080
                     }
                );

                context.SaveChanges();
            }
        }
    }
}
