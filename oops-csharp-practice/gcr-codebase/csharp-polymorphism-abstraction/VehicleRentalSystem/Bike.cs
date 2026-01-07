using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.VehicleRentalSystem
{
    internal class Bike : Vehicle,IInsurable
    {
        private string PolicyNumber;

        public Bike(string vehicleNumber, string type, double rentalRate, string policyNumber)
            : base(vehicleNumber, type, rentalRate)
        {
            PolicyNumber = policyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            // Example logic: discount for bikes
            return GetRentalRate() * days * 0.9;
        }

        public double CalculateInsurance()
        {
            return 15.00;
        }

        public string GetInsuranceDetails()
        {
            return "Bike Insurance (Basic)";
        }
    }
}
