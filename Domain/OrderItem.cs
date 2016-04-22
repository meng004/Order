using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class OrderItem
    {
        public OrderItem(Order order,Product product)
        {
            Order = order;
            Product = product;
        }
        public Product Product { get;  }

        private Order _order;

        public Order Order
        {
            get { return _order; }
            set
            {
                _order = value;
                _order.OrderItems.Add(this);
            }
        }

        public int Count { get; set; }

        public double TotalPrice()
        {
            return Product.Price*Count;
        }
    }
}