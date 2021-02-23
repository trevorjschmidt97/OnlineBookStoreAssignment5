using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineBookstore.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string Publisher { get; set; }

        // Includes regex check for isbn number xxx-xxxxxxxxxx
        [RegularExpression("\\d{3}-\\d{10}")]
        public string ISBN { get; set; }
        public float Price { get; set; }
        public string Classification { get; set; }
        public string Category { get; set; }

        
    }
}
