using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineBookstore.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(Book book, int quantity)
        {
            CartLine line = Lines.Where(b => b.Book.BookId == book.BookId).FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = quantity
                });
            } else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveItem(Book book) =>
            Lines.RemoveAll(x => x.Book.BookId == book.BookId);

        public virtual void Clear() => Lines.Clear();

        public float ComputeTotalSum() => Lines.Sum(x => x.Book.Price * x.Quantity);

        public class CartLine
        {
            public int CartLineId { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}