using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructor
{
    internal class CarRentalSystem
    {
        string name;
        string carModel;
        int rentalDays;
        int costOneDay;
        public CarRentalSystem()
        {
            name = "Johm";
            carModel = "Maruti Suzuki";
            rentalDays = 4;
            costOneDay = 1000;
        }
        public CarRentalSystem(string name, string carModel, int rentalDays, int costOneDay)
        {
            this.name = name;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
            this.costOneDay = costOneDay;
        }
        public void CalculateTotalCost()
        {
            Console.WriteLine("Total bill for renting : " + (costOneDay * rentalDays));
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Customer Name : " + name);
            Console.WriteLine("Car Model rented : " + carModel);
            Console.WriteLine("Rental Days : " + rentalDays);
        }
    }
    class Program
    {
        static void Main()
        {
            CarRentalSystem car1 = new CarRentalSystem();
            car1.DisplayDetails();
            car1.CalculateTotalCost();
            Console.WriteLine();
            Console.Write("Give Customer Name : ");
            string name = Console.ReadLine();
            Console.Write("Give car model rented : ");
            string carModel = Console.ReadLine();
            Console.Write("Give rental days : ");
            int rentalDays = int.Parse(Console.ReadLine());
            Console.Write("Give the cost per day : ");
            int cost = int.Parse(Console.ReadLine());
            CarRentalSystem car2 = new CarRentalSystem(name, carModel, rentalDays, cost);
            car2.DisplayDetails();
            car2.CalculateTotalCost();
        }
    }
}
