using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.OnlineFoodDeliverySystem
{
    internal interface IDiscountable
    {
        double ApplyDiscount(double totalCost);
        string GetDiscountDetails();
    }
}
