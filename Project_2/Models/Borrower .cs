using System;
using System.Collections.Generic;
using System.Text;

namespace Project_2.Models
{
    public class Borrower
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime MemberShipDate { get; set; }
        public ICollection<Loan> Loans {get; set; } = new List<Loan>();
    }
}
