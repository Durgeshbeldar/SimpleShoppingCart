using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    internal class Order
    {
        private int orderId;
        private DateTime dateTime;
        private List<LineItem> items;

        public int OrderId
        {
            get { return orderId; }
            private set { orderId = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
            private set { dateTime = value; }
        }

        public List<LineItem> Items
        {
            get { return items; }
            private set { items = value; }
        }

        public Order(int orderId, DateTime dateTime)
        {
           
            OrderId = orderId;
            DateTime = dateTime;
            Items = new List<LineItem>();

        }

        
        public override string ToString()
        {
            
            string result = 
                $"\nOrder Id : {OrderId}\n" +
                $"Order Date : {DateTime}\n";
            foreach (LineItem item in Items) 
            {
                result += $"\nLineItemId : {item.Id} || Product Id : {item.Product.ProductId} || Product Name : {item.Product.ProductName} || Quantity {item.Quantity}" +
                    $" || Unit Price : {item.Product.Price} || Discount Off Per Unit : {item.Product.DiscountPrice} " +
                    $"|| Unit Cost After Discount : {item.Product.CalculateDiscountedPrice()}" +
                    $" || Total Cost : {item.CalculateCost()}\n";
               
            }
            return result + $"\n\nTotal Order Cost : { TotalCost()}\n";
        }


        public double TotalCost()
        {
            double total = 0;
            foreach (LineItem item in Items)
            {
                total = total + item.CalculateCost();
            }
            return total;
        }
    }
}
