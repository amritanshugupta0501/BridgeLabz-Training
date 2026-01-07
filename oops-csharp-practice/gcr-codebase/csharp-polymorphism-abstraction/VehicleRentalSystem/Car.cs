using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.VehicleRentalSystem
{
    internal class Car : Vehicle,IInsurable
    {
        private string PolicyNumber;

        public Car(string vehicleNumber, string type, double rentalRate, string policyNumber)
            : base(vehicleNumber, type, rentalRate)
        {
            PolicyNumber = policyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return GetRentalRate() * days;
        }

        public double CalculateInsurance()
        {
            return 50.00;
        }

        public string GetInsuranceDetails()
        {
            return "Car Insurance (Standard)";
        }
    }
}
