using System;
using System.Collections.Generic;
using System.Text;

namespace Project_2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;
        public ICollection <Loan> Loans { get; set; } = new List<Loan>();
    }
}
