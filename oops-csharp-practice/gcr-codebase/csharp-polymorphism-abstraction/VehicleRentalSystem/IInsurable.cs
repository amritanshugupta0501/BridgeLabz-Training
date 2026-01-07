using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.VehicleRentalSystem
{
    internal interface IInsurable
    {
        double CalculateInsurance();
        string GetInsuranceDetails();
    }
}
