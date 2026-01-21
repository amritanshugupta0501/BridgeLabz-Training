using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.SupermarketBillingSystem
{
    // Class designed to define all the attributes of a product
    internal class ProductDetails
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCost {  get; set; }

        public override string? ToString()
        {
            return $"Product Id : {ProductId}\nProduct Name : {ProductName}\nProduct Cost : {ProductCost}";
        }
    }
}
