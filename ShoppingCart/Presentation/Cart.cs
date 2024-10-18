using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Presentation
{
    internal class Cart
    {
        public static void ShoppingCartUI()
        {
            Customer customer = new Customer(1001, "Shyam Kumavat");

            Order order1 = new Order(1, DateTime.Now);
            Order order2 = new Order(2, DateTime.Now);

            Product product1 = new Product(1000, "Asus Laptop", 42000, 5000);
            Product product2 = new Product(2000, "Vivo V40 Pro", 50000, 5000);
            Product product3 = new Product(3000, "Realme 5 Pro", 15000, 2000);
            Product product4 = new Product(4000, "Iphone 15", 65000, 9000);

            LineItem item1 = new LineItem(11, 2, product1);
            LineItem item2 = new LineItem(12, 2, product2);
            LineItem item3 = new LineItem(21, 5, product3);
            LineItem item4 = new LineItem(22, 1, product4);

            order1.Items.Add(item1);
            order1.Items.Add(item2);
            order2.Items.Add(item3);
            order2.Items.Add(item4);

            customer.Orders.Add(order1);
            customer.Orders.Add(order2);

            // Dummy Data is above 

            // Printing Details 

            Console.WriteLine(customer.PrintCustomer());

            for (int i = 0; i < customer.Orders.Count; i++)
            {
                Console.WriteLine(customer.Orders[i].ToString());
            }

            Console.WriteLine($"\n--------------------------------------------------------------------------------\n" +
                $"Total Orders Cost To Customer : {customer.GetTotalOrdersCost()}\n\n" +
                $"Cart is Printed as per Assignment... Thank You!\n");
        }
    }
}
