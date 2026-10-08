using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1.Models
{
    public class OrderDetail
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}
