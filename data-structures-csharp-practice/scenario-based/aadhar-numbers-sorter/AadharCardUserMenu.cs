using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.AadharNumbersSorter
{
    internal class AadharCardUserMenu
    {
        IAadharSortUtility AadharCard;
        public void HomeMenu()
        {
            AadharCard = new AadharSortUtilityImpl();
            Console.WriteLine("Welcome to Aadhar Card Management System!");
            while (true)
            {
                Console.WriteLine("0. Exit the system");
                Console.WriteLine("1. Add a user to the system");
                Console.WriteLine("2. Display all users");
                Console.WriteLine("3. Sort the users in an ordered manner");
                Console.WriteLine("4. Search for a user's details");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Hope you have a good day!");
                        return;
                    case "1":
                        AadharCard.AddPersonInSystem();
                        break;
                    case "2":
                        AadharCard.DisplayAadharInformation(); 
                        break;
                    case "3":
                        AadharCard.AadharInformationSorting();
                        break;
                    case "4":
                        AadharCard.SearchUser();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice inputted");
                        break;
                }
            }
        }
    }
}
