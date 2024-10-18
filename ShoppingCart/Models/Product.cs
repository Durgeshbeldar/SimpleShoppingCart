using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    internal class Product
    {
        private int productId;
        private string productName;
        private double price;
        private double discountPrice;

        // We Can Used Auto Properties as well but Class Diagrams having the Getter Setter Methods...

        public int ProductId
        {
            get { return productId; }
            private set { productId = value; }
        }

        public string ProductName
        {
            get { return productName; }
            private set { productName = value; }
        }

        public double Price
        {
            get { return price; }
            private set { price = value; }
        }

        public double DiscountPrice
        {
            get { return discountPrice; }
            private set { discountPrice = value; }
        }

        // Constructor for initializing
        public Product(int productId, string productName, double price, double discountPrice)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            DiscountPrice = discountPrice;
        }

        // Calculate Discounted Price
        public double CalculateDiscountedPrice()
        {
            return Price - DiscountPrice; // Assuming DiscountPrice is the amount of discount
        }
    }
}
