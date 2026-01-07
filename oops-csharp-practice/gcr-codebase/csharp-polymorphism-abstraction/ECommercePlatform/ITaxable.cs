using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.ECommercePlatform
{
    internal interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }
}
