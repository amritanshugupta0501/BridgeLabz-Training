using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.ECommercePlatform
{
    internal class Groceries : Product
    {
        public Groceries(string productId, string name, double price)
        : base(productId, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return GetPrice() * 0.02;
        }
    }
}
