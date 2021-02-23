using System;
using System.Linq;

namespace OnlineBookstore.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookStoreDbContext _context;

        public EFBookRepository(BookStoreDbContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
        
    }
}
