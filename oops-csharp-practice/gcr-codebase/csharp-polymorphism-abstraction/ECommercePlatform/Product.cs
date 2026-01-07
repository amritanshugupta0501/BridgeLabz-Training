using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.ECommercePlatform
{
    internal abstract class Product
    {
        private string ProductId;
        private string ProductName;
        private double ProductPrice;

        public Product(string productId, string name, double price)
        {
            ProductId = productId;
            ProductName = name;
            ProductPrice = price;
        }

        public string GetProductId()
        {
            return ProductId;
        }

        public void SetProductId(string productId)
        {
            this.ProductId = productId;
        }

        public string GetName()
        {
            return ProductName;
        }

        public void SetName(string name)
        {
            this.ProductName = name;
        }

        public double GetPrice()
        {
            return ProductPrice;
        }

        public void SetPrice(double price)
        {
            this.ProductPrice = price;
        }

        public abstract double CalculateDiscount();
    }
}
