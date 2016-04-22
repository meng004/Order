using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;


namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_Number.Enabled = false;
            txt_Date.Enabled = false;
            txt_Product1TotalPrice.Enabled = false;
            txt_Product2TotalPrice.Enabled = false;
            txt_OrderTotalPrice.Enabled = false;
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            //customer
            var customer = new Customer()
            {
                Address = txt_Address.Text,
                Name = txt_CustomerName.Text,
                Phone = txt_Phone.Text
            };
            //order
            var order = new Order(customer);
            //product
            var product1 = new Product()
            {
                Name = txt_Product1Name.Text,
                Price = double.Parse(txt_Product1Price.Text)
            };
            var product2 = new Product()
            {
                Name = txt_Product2Name.Text,
                Price = double.Parse(txt_Product2Price.Text)
            };
            //orderitem
            var orderitem1=new OrderItem(order,product1)
            {
                Count = int.Parse(txt_Product1Count.Text)
            };
            var orderitem2 = new OrderItem(order, product2)
            {
                Count = int.Parse(txt_Product2Count.Text)
            };
            //ShowOrder
            ShowOrder(order);
        }

        private void ShowOrder(Order order)
        {
            txt_Number.Text = order.Number;
            txt_Date.Text = order.Date.ToString();
            txt_Product1TotalPrice.Text = order.OrderItems.ToArray()[0].TotalPrice().ToString();
            txt_Product2TotalPrice.Text = order.OrderItems.ToArray()[1].TotalPrice().ToString();
            txt_OrderTotalPrice.Text = order.TotalPrice().ToString();
        }
    }
}
