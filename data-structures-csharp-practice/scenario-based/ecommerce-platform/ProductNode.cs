using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.ecommerceplatform
{
    // Node class for a list of products
    internal class ProductNode
    {
        public ProductDetails Product;
        public ProductNode Next;
        public ProductNode(ProductDetails product)
        {
            Product = product;
            Next = null;
        }
    }
}
