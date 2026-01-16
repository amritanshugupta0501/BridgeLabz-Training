using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Scenario_Based.TrafficManager.TrafficManageList;

namespace Scenario_Based.TrafficManager
{
    internal class TrafficManagementSystemImpl : ITrafficManagementSystem
    {
        private TrafficQueue waitingQueue;
        private TrafficManageList roundabout;
        private TrafficStack exitHistory;
        public TrafficManagementSystemImpl(int capacity)
        {
            waitingQueue = new TrafficQueue(capacity);
            roundabout = new TrafficManageList();
            exitHistory = new TrafficStack();
        }

        public void Arrive(string vehicleNumber, string vehicleType)
        {
            VehicleInformation vehicle = new VehicleInformation(vehicleNumber, vehicleType);
            waitingQueue.Enqueue(vehicle);
        }

        public void EnterRoundabout()
        {
            VehicleInformation vehicle = waitingQueue.Dequeue();
            if (vehicle != null)
            {
                roundabout.Add(vehicle);
            }
        }

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
