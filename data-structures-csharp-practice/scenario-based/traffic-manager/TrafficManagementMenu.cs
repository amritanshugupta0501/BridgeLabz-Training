using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.TrafficManager
{
    // Sealed classs to preven inheritance of the menu class
    sealed class TrafficManagementMenu
    {
        ITrafficManagementSystem TrafficManager;
        // Function to design Home Menu of the application
        public void HomeMenu()
        {
            Console.WriteLine("Welcome to the Traffic Management System!");
            Console.Write("Enter Max Traffic Capacity to be handled : ");
            int cap = int.Parse(Console.ReadLine());
            TrafficManager = new TrafficManagementSystemImpl(cap);

            while (true)
            {
                Console.WriteLine("1. Add Car to Queue");
                Console.WriteLine("2. Move Car to Roundabout");
                Console.WriteLine("3. Exit Car from Roundabout");
                Console.WriteLine("4. View Status");
                Console.WriteLine("5. Exit App");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Vehicle Number: ");
                        string vehicleNumber = Console.ReadLine();
                        Console.Write("Type: ");
                        string type = Console.ReadLine();
                        TrafficManager.Arrive(vehicleNumber, type);
                        break;
                    case "2":
                        TrafficManager.EnterRoundabout();
                        break;
                    case "3":
                        TrafficManager.ExitRoundabout();
                        break;
                    case "4":
                        TrafficManager.ShowStatus();
                        break;
                    case "5":
                        Console.WriteLine("Thank you for your efforts!");
                        return;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
        }
    }
}
