using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.VehicleRentalSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vehicle[] fleet = new Vehicle[]
            {
            new Car("CAR-123", "Sedan", 60.00, "POL-CAR-001"),
            new Bike("BIKE-456", "Sport", 20.00, "POL-BIKE-002"),
            new Truck("TRUCK-789", "Heavy", 150.00, "POL-TRUCK-003")
            };

            ProcessRentals(fleet, 5);
        }

        public static void ProcessRentals(Vehicle[] vehicles, int rentalDays)
        {
            Console.WriteLine($"Processing Rentals for {rentalDays} days...\n");

            foreach (Vehicle vehicle in vehicles)
            {
                double rentalCost = vehicle.CalculateRentalCost(rentalDays);
                double insuranceCost = 0;

                if (vehicle is IInsurable)
                {
                    insuranceCost = ((IInsurable)vehicle).CalculateInsurance();
                }

                double totalCost = rentalCost + insuranceCost;

                Console.WriteLine("Vehicle: " + vehicle.GetVehicleType() + " (" + vehicle.GetVehicleNumber() + ")");
                Console.WriteLine("Rental Cost: $" + rentalCost);

                if (vehicle is IInsurable)
                {
                    Console.WriteLine(((IInsurable)vehicle).GetInsuranceDetails() + ": +$" + insuranceCost);
                }

                Console.WriteLine("Total Cost: $" + totalCost);
            }
        }
    }
}
