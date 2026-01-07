using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.ECommercePlatform
{
    internal class Clothing : Product,ITaxable
    {
        public Clothing(string productId, string name, double price) : base(productId, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return GetPrice() * 0.15;
        }

        public double CalculateTax()
        {
            return GetPrice() * 0.05;
        }

        public string GetTaxDetails()
        {
            return "Clothing Tax (5%)";
        }
    }
}
