using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.RideHailingSystem
{
    internal class Auto : Vehicle,IGPS
    {
        private string CurrentLocation;

        public Auto(string vehicleId, string driverName, double ratePerKm)
            : base(vehicleId, driverName, ratePerKm)
        {
            CurrentLocation = "0.0, 0.0";
        }

        public override double CalculateFare(double distance)
        {
            double minimumFare = 30.0;
            double calculatedFare = GetRatePerKm() * distance;

            if (calculatedFare < minimumFare)
            {
                return minimumFare;
            }
            return calculatedFare;
        }

        public string GetCurrentLocation()
        {
            return CurrentLocation;
        }

        public void UpdateLocation(double latitude, double longitude)
        {
            CurrentLocation = latitude + ", " + longitude;
        }
    }
}
