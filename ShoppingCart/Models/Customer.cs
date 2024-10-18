using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    internal class Customer
    {
        private int customerId;
        private string customerName;
        private List<Order> orders;

        public int CustomerId
        {
            get { return customerId; }
            private set { customerId = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            private set { customerName = value; }
        }

        public List<Order> Orders
        {
            get { return orders; }
            private set { orders = value; }
        }

        // Constructor
        public Customer(int customerId, string customerName)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            Orders = new List<Order>();
        }

        // Print the Customer Details
        public string PrintCustomer()
        {
            return $"\nCustomer Name : {CustomerName}\n" +
                $"Customer Id : {CustomerId}\n" +
                $"Order Count : {Orders.Count}\n\n";
        }

        // All the methods are like a chain because every Class from Customer to  Line Items Used HAS-A Relationship

        public double GetTotalOrdersCost()
        {
            double totalOrdersCost = 0;
            foreach (Order order in Orders)
            {
                totalOrdersCost = totalOrdersCost + order.TotalCost();
            }
            return totalOrdersCost;
        }
    }
   

}
