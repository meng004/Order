using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class OrderItem
    {
        public Product Product { get; set; }

        public Order Order { get; set; }

        public int Count { get; set; }

        public double TotalPrice()
        {
            return Product.Price*Count;
        }
    }
}