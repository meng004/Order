using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Order
    {
        public Customer Customer { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public string Number { get; set; }

        public DateTime Date { get; set; }

        public double TotalPrice()
        {
            var totalPrice = 0.0d;
            foreach (var orderItem in OrderItems)
            {
                totalPrice += orderItem.TotalPrice();
            }
            return totalPrice;
        }
    }
}