using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.VehicleRentalSystem
{
    internal abstract class Vehicle
    {
        private string VehicleNumber;
        private string Type;
        private double RentalRate;

        public Vehicle(string vehicleNumber, string type, double rentalRate)
        {
            VehicleNumber = vehicleNumber;
            Type = type;
            RentalRate = rentalRate;
        }

        public string GetVehicleNumber()
        {
            return VehicleNumber;
        }

        public void SetVehicleNumber(string vehicleNumber)
        {
            VehicleNumber = vehicleNumber;
        }

        public string GetVehicleType()
        {
            return Type;
        }

        public void SetVehicleType(string type)
        {
            Type = type;
        }

        public double GetRentalRate()
        {
            return RentalRate;
        }

        public void SetRentalRate(double rentalRate)
        {
            RentalRate = rentalRate;
        }

        public abstract double CalculateRentalCost(int days);
    }
}
