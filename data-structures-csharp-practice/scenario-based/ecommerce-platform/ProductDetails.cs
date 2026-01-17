using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.ecommerceplatform
{
    // Class designed to define the characteristics of the products
    internal class ProductDetails
    {
        string ProductName;
        string ProductId;
        double ProductCost;
        double ProductDiscount;
        public ProductDetails(string productName, string productId, double productCost, double productDiscount) 
        {
            ProductName = productName;
            ProductId = productId;
            ProductCost = productCost;
            ProductDiscount1 = productDiscount;
        }
        public double ProductDiscount1 { get => ProductDiscount; set => ProductDiscount = value; }
        public override string? ToString()
        {
            return $"Product Name : {ProductName}\nProduct Id : {ProductId}\nProduct Actual Cost : {ProductCost}\nProduct Discount : {ProductDiscount1}";
        }
    }
}
