using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.BusRouteTracker
{
    internal class BusTracker
    {
        Bus[] buses = new Bus[50];							// Array to store number of busesw 
        static int busCount = 0;
        static void Main()								// Entry point of the application
        {
            BusTracker tracker = new BusTracker();
            tracker.SystemInitialize();
        }
        void SystemInitialize()								// Function to initialize the working of the system
        {
            Console.WriteLine("Welcome to the Bus Route Tracker System!");
            int choice = 0;
            while (choice != 6)								// Loop to traverse the menu of the application
            {

                Console.WriteLine("\tMenu");
                Console.WriteLine("1. Add a Bus");
                Console.WriteLine("2. View All the buses in the system");
                Console.WriteLine("3. View Bus Details");
                Console.WriteLine("4. Start a bus");
                Console.WriteLine("5. Track a bus");
                Console.WriteLine("6. Exit");
                Console.Write("Please select an option (1-6): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)								// Using switch case to determine what functionality to perform
                {
                    case 1:
                        AddBus();							// Function called to add a bus in the database
                        break;
                    case 2:
                        ViewAllTheBuses();						// Function called to view all the schedules buses
                        break;
                    case 3:
                        Console.Write("Select the bus number to view details : ");
                        ViewAllTheBuses();
                        int busNumber = int.Parse(Console.ReadLine());
                        DisplayBusDetails(busNumber);					// Function called to display details of all the buses
                        break;
                    case 4:
                        Console.Write("Select the bus number to start : ");
                        ViewAllTheBuses();
                        int busNumToStart = int.Parse(Console.ReadLine());
                        StartABus(busNumToStart);					// Function called to start a bus
                        break;
                    case 5:
                        Console.Write("Select the bus number you will like to track : ");
                        ViewAllTheBuses();
                        int busNum = int.Parse(Console.ReadLine());
                        TrackABus(busNum);						// Function called to track a bus
                        break;
                    case 6:
                        Console.WriteLine("Exiting the system. Thank you for your support!");
                        return;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
        void AddBus()									// Function to schedule a bus 
        {
            Console.WriteLine("Give details of the bus : ");
            Console.Write("Give the Conductor ID: ");
            int conductorID = int.Parse(Console.ReadLine());
            Console.Write("Give the Driver ID: ");
            int driverID = int.Parse(Console.ReadLine());
            Console.Write("Give the Bus Number: ");
            string busNumber = Console.ReadLine();
            Console.Write("Give the Number of stops bus has to go through: ");
            int numberOfStops = int.Parse(Console.ReadLine());
            Console.Write("Give the Capacity of passengers in the bus: ");
            int capacity = int.Parse(Console.ReadLine());
            buses[busCount] = new Bus(conductorID, driverID, busNumber, numberOfStops, capacity);
            busCount++;
        }
        void ViewAllTheBuses()								// Function to view all the buses in the database
        {
            for(int i=0;i<busCount;i++)
            {
                Console.WriteLine("Bus "+(i+1)+": "+buses[i].busNumber);
            }
        }
        void DisplayBusDetails(int busNumber)						// Function to view the details of a bus
        {
            for (int loop = 0; loop < busCount; loop++)
            {
                if(loop == (busNumber-1))
                {
                    buses[loop].DisplayBusDetails();
                    return;
                }
            }
        }
        void TrackABus(int busNum)
        {
            for(int loop =0;loop<busCount;loop++)
            {
                if(loop == (busNum - 1))
                {
                    Console.WriteLine("Tracking Bus: "+busNum);
                    Console.WriteLine("Current stop of the bus: "+buses[loop].currentStop);
                    return;
                }
            }
        }
        void StartABus(int busNumToStart)
        {
            for(int loop =0;loop<busCount;loop++)
            {
                if(loop == (busNumToStart-1))
                {
                    Console.WriteLine("Starting Bus: "+busNumToStart);
                    buses[loop].StartTheBus();
                    return;
                }
            }
        }
    }
}
