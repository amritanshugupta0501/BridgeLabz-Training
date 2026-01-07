using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.VehicleRentalSystem
{
    internal class Truck : Vehicle,IInsurable
    {
        private string PolicyNumber;

        public Truck(string vehicleNumber, string type, double rentalRate, string policyNumber)
            : base(vehicleNumber, type, rentalRate)
        {
            PolicyNumber = policyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            // Example logic: Flat fee added for heavy load handling
            return (GetRentalRate() * days) + 100.00;
        }

        public double CalculateInsurance()
        {
            return 120.00;
        }

        public string GetInsuranceDetails()
        {
            return "Truck Insurance (Commercial)";
        }
    }
}
