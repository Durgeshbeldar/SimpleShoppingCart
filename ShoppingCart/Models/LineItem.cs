using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ShoppingCart.Models
{
    internal class LineItem
    {
        private int id;
        private int quantity;
        private Product product;

        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Product Product
        {
            get { return product; }
            private set { product = value; }
        }

        // Constructor
        public LineItem(int id, int quantity, Product product)
        {
            Id = id;
            Quantity = quantity;
            Product = product;
        }

        // Calculate Line Item cost
        public double CalculateCost()
        {
            return Quantity * Product.CalculateDiscountedPrice();
        }
    }
}
