using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpkeywords
{
    internal class VehicleRegistrationSystem
    {
        public static double registrationFee = 1000;
        public readonly string registrationNumber;
        public string ownerName;
        public string vehicleType;
        public VehicleRegistrationSystem(string ownerName, string vehicleType, string registrationNumber)       // Constructor to define vehicle characteristics
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
            this.registrationNumber = registrationNumber;
        }
        public static void UpdateRegistrationFee(double newFee)                                                 // Method to update registration fees
        {
            registrationFee = newFee;
            Console.WriteLine("Updated Registration Fee : "+registrationFee);
        }
        public void DisplayVehicleDetails()                                                                     // Method to display vehicle details
        {
            Console.WriteLine("Vehicle Details : ");
            Console.WriteLine("Owner Name : "+ownerName);
            Console.WriteLine("Vehicle Type : "+vehicleType);
            Console.WriteLine("Registration No. : "+registrationNumber );
            Console.WriteLine("Registration Fee : "+registrationFee);
        }
    }
    class Program
    {
        static void Main()                                                                                      // Entry point of the application
        {
            Console.WriteLine("Give Vehicle Details : ");
            Console.Write("Give Owner Name : ");
            string name = Console.ReadLine();
            Console.Write("Give Vehicle's Type : ");
            string type = Console.ReadLine();
            Console.Write("Give Vehicle's Registration Number : ");
            string regNumber = Console.ReadLine();
            VehicleRegistrationSystem vehicle = new VehicleRegistrationSystem(name, type, regNumber);           // Constructor called
            if(vehicle is VehicleRegistrationSystem)                                                            // Checking the type of object using 'is' operator
            {
                vehicle.DisplayVehicleDetails();
                Console.Write("Give Vehicle's Registration Fee : ");
                double regFee = double.Parse(Console.ReadLine());
                VehicleRegistrationSystem.UpdateRegistrationFee(regFee);
            }
            else
            {
                Console.WriteLine("Invalid Object.");
            }
        }
    }
}
