using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructor
{
    internal class VehicleRegistration
    {
        string ownerName;
        string vehicleType;
        static double registrationFee = 1000;
        public VehicleRegistration(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }
        public void DisplayVehicleDetails()
        {
            Console.WriteLine("Owner Name : " + ownerName);
            Console.WriteLine("Vehicle Type : " + vehicleType);
            Console.WriteLine("Registration Fee : " + registrationFee);
        }
        public void UpdateRegistrationFee(double registrationFee)
        {
            VehicleRegistration.registrationFee = registrationFee;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.Write("Give owner name : ");
            string name = Console.ReadLine();
            Console.Write("Give vehicle type : ");
            string type = Console.ReadLine();
            VehicleRegistration vehicle = new VehicleRegistration(name, type);
            vehicle.DisplayVehicleDetails();
            Console.Write("Give update registration fee : ");
            double registrationFee = double.Parse(Console.ReadLine());
            vehicle.UpdateRegistrationFee(registrationFee);
            vehicle.DisplayVehicleDetails();
        }
    }
}
