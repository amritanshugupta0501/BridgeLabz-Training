using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.fitnesstracker
{
    // Menu class for the application : Sealed to prevent its inheritance
    sealed class FitnessTrackerMenu
    {
        private IFitnessTrackerDetails FitnessTracker;
        // Function to design home menu for the fitness tracker application
        public void HomeMenu()
        {
            Console.WriteLine("Welcome to Fitness Tracker Device!");
            FitnessTracker = new FitnessTrackerDetailsImpl();
            while (true)
            {
                Console.WriteLine("1. Add a Group Member");
                Console.WriteLine("2. Generate Rankings among the Group Members");
                Console.WriteLine("0. Exit the application");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Hope you have a Good Day!");
                        return;
                    case "1":
                        FitnessTracker.AddUserInAGroup();
                        break;
                    case "2":
                        FitnessTracker.GenerateHourlyRankingsAmongTheGroup();
                        break;
                    default:
                        Console.WriteLine("Invalid choice entered");
                        break;
                }
            }
        }
    }
}
