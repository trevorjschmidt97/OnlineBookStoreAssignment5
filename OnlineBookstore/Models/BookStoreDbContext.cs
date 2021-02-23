using System;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookstore.Models
{
    public class BookStoreDbContext: DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base (options) { }

        public DbSet<Book> Books { get; set; }
    }
}
