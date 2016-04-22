using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Order
    {
        public Order(Customer customer)
        {
            Customer = customer;
            OrderItems = new List<OrderItem>();
            Number = CreateNumber();
            Date = DateTime.Now;

        }

        private string CreateNumber()
        {
            var number = new Random().Next(1000).ToString().PadLeft(5, '0');
            return number;
        }

        public Customer Customer { get; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public string Number { get; }

        public DateTime Date { get; }

        public double TotalPrice()
        {
            return OrderItems.Sum(orderItem => orderItem.TotalPrice());
        }
    }
}