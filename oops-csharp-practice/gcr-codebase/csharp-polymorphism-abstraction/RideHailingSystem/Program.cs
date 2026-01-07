using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.RideHailingSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vehicle[] nearbyVehicles = new Vehicle[]
            {
            new Car("C-100", "Alice", 15.0),
            new Bike("B-200", "Bob", 8.0),
            new Auto("A-300", "Charlie", 10.0)
            };
            double rideDistance = 5.5;
            ProcessRideRequests(nearbyVehicles, rideDistance);
        }
        public static void ProcessRideRequests(Vehicle[] vehicles, double distance)
        {
            Console.WriteLine("Finding rides for distance: " + distance + " km...\n");
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle is IGPS)
                {
                    // Simulating GPS update
                    ((IGPS)vehicle).UpdateLocation(12.9716, 77.5946);
                }
                double fare = vehicle.CalculateFare(distance);
                Console.WriteLine(vehicle.GetVehicleDetails());
                if (vehicle is IGPS)
                {
                    Console.WriteLine("Location: " + ((IGPS)vehicle).GetCurrentLocation());
                }
                Console.WriteLine("Estimated Fare: $" + fare);
            }
        }
    }
}
