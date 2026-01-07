using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.ECommercePlatform
{
    internal class Electronics : Product,ITaxable
    {
        public Electronics(string productId, string name, double price)
        : base(productId, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return GetPrice() * 0.10;
        }

        public double CalculateTax()
        {
            return GetPrice() * 0.18;
        }

        public string GetTaxDetails()
        {
            return "Electronics Tax (18%)";
        }
    }   
}
