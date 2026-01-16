using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Scenario_Based.TrafficManager.TrafficManageList;

namespace Scenario_Based.TrafficManager
{
    // Utility class of the traffic management system to define various functionalities
    internal class TrafficManagementSystemImpl : ITrafficManagementSystem
    {
        private TrafficQueue waitingQueue;
        private TrafficManageList roundabout;
        private TrafficStack exitHistory;
        // Constructor to initialize objects of the Stack, Queue and Circular linked list classes
        public TrafficManagementSystemImpl(int capacity)
        {
            waitingQueue = new TrafficQueue(capacity);
            roundabout = new TrafficManageList();
            exitHistory = new TrafficStack();
        }
        // Function to get a vehicle entry into the traffic queue
        public void Arrive(string vehicleNumber, string vehicleType)
        {
            VehicleInformation vehicle = new VehicleInformation(vehicleNumber, vehicleType);
            waitingQueue.Enqueue(vehicle);
        }
        // Function to get a vehicle entry into the Round About intersection using circular linked list
        public void EnterRoundabout()
        {
            VehicleInformation vehicle = waitingQueue.Dequeue();
            if (vehicle != null)
            {
                roundabout.Add(vehicle);
            }
        }
        // Function to get a vehicle to exit the Round About intersection 
        public void ExitRoundabout()
        {
            Console.Write("Enter ID to Exit: ");
            string vehicleNumber = Console.ReadLine();
            VehicleInformation vehicle = roundabout.RemoveVehicle(vehicleNumber);
            if (vehicle != null)
            {
                Console.WriteLine($"EXITED: {vehicle} left the roundabout.");
                exitHistory.Push(vehicle); // Add to History Stack
            }
            else
            {
                Console.WriteLine("ERROR: Vehicle not found.");
            }
        }
        // Function to display the vehicle waiting in the queue , to view the vehicles in the roundabout intersection
        // and to display the vehicle which recently exited the intersection
        public void ShowStatus()
        {
            Console.WriteLine("\nSystem State");
            Console.WriteLine("Waiting Queue:");
            waitingQueue.Display();

            Console.WriteLine("Roundabout :");
            roundabout.Display();

            Console.WriteLine("History Display :");
            exitHistory.DisplayHistory();
        }

    }
}
