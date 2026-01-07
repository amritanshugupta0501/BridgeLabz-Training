using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.RideHailingSystem
{
    internal abstract class Vehicle
    {
        private string VehicleId;
        private string DriverName;
        private double RatePerKm;

        public Vehicle(string vehicleId, string driverName, double ratePerKm)
        {
            VehicleId = vehicleId;
            DriverName = driverName;
            RatePerKm = ratePerKm;
        }

        public string GetVehicleId()
        {
            return VehicleId;
        }

        public void SetVehicleId(string vehicleId)
        {
            VehicleId = vehicleId;
        }

        public string GetDriverName()
        {
            return DriverName;
        }

        public void SetDriverName(string driverName)
        {
            DriverName = driverName;
        }

        public double GetRatePerKm()
        {
            return RatePerKm;
        }

        public void SetRatePerKm(double ratePerKm)
        {
            RatePerKm = ratePerKm;
        }

        public string GetVehicleDetails()
        {
            return "Vehicle ID: " + VehicleId + " | Driver: " + DriverName;
        }

        public abstract double CalculateFare(double distance);
    }
}
