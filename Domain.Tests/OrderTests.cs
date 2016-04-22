using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void TotalPrice_TwoThirtyAndOneForty_ReturnOneHundred()
        {
            //arrange
            var order = new Order(new Customer());
            var orderitem1 = new OrderItem(order, new Product() { Price = 30 }) { Count = 2 };
            var orderitem2 = new OrderItem(order, new Product() { Price = 40 }) { Count = 1 };
            var expected = 100.0d;
            //act
            var actual = order.TotalPrice();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
