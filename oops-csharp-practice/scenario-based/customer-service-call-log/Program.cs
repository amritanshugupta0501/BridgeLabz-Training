using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.customer_service_call_log
{
    internal class Program
    {
        static void Main()
        {
            CallLogManager manager = new CallLogManager(2);                         // Initialize manager 
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("   CALL CENTER LOG MANAGER");
                Console.WriteLine("1. Add New Call Log");
                Console.WriteLine("2. Search Logs by Keyword");
                Console.WriteLine("3. Filter Logs by Time");
                Console.WriteLine("4. Display All Logs (Optional debug)");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("\nEnter Customer Phone Number: ");
                        string phone = Console.ReadLine();

                        Console.Write("Enter Issue Description: ");
                        string issue = Console.ReadLine();

                        manager.AddCallLog(phone, issue);
                        Console.WriteLine("Success: Call log added.");
                        break;

                    case "2":
                        Console.Write("\nEnter keyword to search (e.g., 'Internet'): ");
                        string keyword = Console.ReadLine();

                        Console.WriteLine($"\n--- Results for '{keyword}' ---");
                        CallLogs[] searchResults = manager.SearchByKeyword(keyword);
                        manager.DisplayLogs(searchResults);
                        break;

                    case "3":
                        Console.WriteLine("\nFilter logs from the last X minutes.");
                        Console.Write("Enter minutes (e.g., 60 for last hour): ");
                        if (int.TryParse(Console.ReadLine(), out int minutes))                                                          // Parse the input string to an integer
                        {
                            DateTime endTime = DateTime.Now;
                            DateTime startTime = endTime.AddMinutes(-minutes);

                            Console.WriteLine($"\n--- Logs from {startTime.ToShortTimeString()} to {endTime.ToShortTimeString()} ---");
                            CallLogs[] timeResults = manager.FilterByTime(startTime, endTime);
                            manager.DisplayLogs(timeResults);
                        }
                        else
                        {
                            Console.WriteLine("Invalid number entered.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("\n--- Displaying Recent Activity ---");
                        CallLogs[] allLogs = manager.SearchByKeyword("");
                        manager.DisplayLogs(allLogs);
                        break;

                    case "5":
                        isRunning = false;
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }

        }
    }
}
