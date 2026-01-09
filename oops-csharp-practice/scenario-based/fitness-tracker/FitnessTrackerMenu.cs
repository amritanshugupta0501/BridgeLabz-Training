using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.fitnesstracker
{
    // Sealed class to prevent inheritance of the menu class
    sealed class FitnessTrackerMenu
    {
        // Object of WorkOutUtilityImpl class(child class) called using reference of FitnessTrack(parent interface)
        ITrackable FitnessTrack;
        // Function to define home menu of the application
        public void FitnessTrackerHomeMenu()
        {
            FitnessTrack = new WorkOutUtilityImpl();
            Console.WriteLine("Welcome to Fit Track Application ! ");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Register a new user");
                Console.WriteLine("2. View all the users using the application");
                Console.WriteLine("3. Display a user's details");
                Console.WriteLine("4. Commence workout");
                Console.WriteLine("5. Exit the session");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        FitnessTrack.AddUserProfile();
                        break;
                    case 2:
                        FitnessTrack.ViewUsersList();
                        break;
                    case 3:
                        FitnessTrack.DisplayUserDetails();
                        break;
                    case 4:
                        FitnessTrack.InitializeTheSession();
                        break;
                    case 5:
                        Console.WriteLine("Thank you for your efforts!!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice input.");
                        break;
                }
            }
        }
    }
}
