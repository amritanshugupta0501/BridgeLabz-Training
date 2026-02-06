using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.Review.trafficlightsimulation
{
    internal class TrafficLightUtility : ITrafficLightUtility
    {
        ILightsSimulation TrafficLight;
        VehicleInformation Head;
        static int TrafficCounter;
        public void DisplayTrafficQueue()
        {
            if (Head != null)
            {
                int index;
                Console.WriteLine("Traffic Queue");
                VehicleInformation current = Head;
                index = 0;
                while (current != null)
                {
                    Console.WriteLine(current.ToString());
                    Console.WriteLine();
                    current = current.Next;
                }
            }
        }
        public void AddVehicleToTheTrafficQueue(string vehicleState)
        {
            VehicleInformation newVehicle = new VehicleInformation();
            Console.WriteLine("Give details of the vehicle : ");
            Console.Write("Vehcile Number : ");
            newVehicle.VehicleNumber1 = Console.ReadLine();
            Console.Write("Vehcile Type : ");
            newVehicle.VehicleType1 = Console.ReadLine();
            newVehicle.VehicleState1 = vehicleState;
            if (newVehicle.VehicleState1.Equals("Red Light") || newVehicle.VehicleState1.Equals("Yellow Light"))
            {
                if (Head == null)
                {
                    Head = newVehicle;
                    return;
                }
                VehicleInformation currentVehicle = Head;
                while (currentVehicle.Next != null)
                {
                    currentVehicle = currentVehicle.Next;
                }
                currentVehicle.Next = newVehicle;
            }
            else
            {
                Console.WriteLine(newVehicle.ToString());
            }
        }
        public void InitalizeTrafficLights()
        {
            TrafficCounter = 0;
            string trafficLightState;
            while (true)
            {
                TrafficCounter %= 5;
                if (TrafficCounter == 0 || TrafficCounter == 4)
                {
                    trafficLightState = "Red Light";
                    bool checker = true;
                    while (checker)
                    {
                        Console.WriteLine("Are there vehicles to add to the traffic queue ?\n1. Yes\n2. No");
                        var choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                AddVehicleToTheTrafficQueue(trafficLightState);
                                break;
                            default:
                                checker = false;
                                break;
                        }
                        Console.Clear();
                    }
                    Console.WriteLine("Traffic Lights are Red.");
                    DisplayTrafficQueue();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (TrafficCounter == 1 || TrafficCounter == 3)
                {
                    trafficLightState = "Yellow Light";
                    bool checker = true;
                    while (checker)
                    {
                        Console.WriteLine("Are there vehicles to add to the traffic queue ?\n1. Yes\n2. No");
                        var choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                AddVehicleToTheTrafficQueue(trafficLightState);
                                break;
                            default:
                                checker = false;
                                break;
                        }
                        Console.Clear();
                    }
                    Console.WriteLine("Traffic Lights are Yellow.");
                    VehicleInformation currentVehicle = Head;
                    while (currentVehicle != null)
                    {
                        TrafficLight = new YellowTrafficLightImpl();
                        currentVehicle.VehicleState1 = TrafficLight.StateOfTheVehicle(currentVehicle);
                        currentVehicle = currentVehicle.Next;
                    }
                    DisplayTrafficQueue();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (TrafficCounter == 2)
                {
                    trafficLightState = "Green Light";
                    bool checker = true;
                    while (checker)
                    {
                        Console.WriteLine("Are there vehicles to add to the traffic queue ?\n1. Yes\n2. No");
                        var choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                AddVehicleToTheTrafficQueue(trafficLightState);
                                break;
                            default:
                                checker = false;
                                break;
                        }
                        Console.Clear();
                    }
                    Console.WriteLine("Traffic Lights are Green.");
                    VehicleInformation currentVehicle = Head;
                    while (currentVehicle != null)
                    {
                        TrafficLight = new GreenTrafficLightImpl();
                        currentVehicle.VehicleState1 = TrafficLight.StateOfTheVehicle(currentVehicle);
                        currentVehicle = currentVehicle.Next;
                    }
                    DisplayTrafficQueue();
                    RemoveVehiclesFromTrafficQueue();
                    Console.ReadLine();
                    Console.Clear();
                }
                if (TrafficCounter == 4 && CheckTrafficQueueEmpty())
                {
                    return;
                }
                TrafficCounter++;
            }
        }
        public void RemoveVehiclesFromTrafficQueue()
        {
            VehicleInformation currentVehicle = Head;
            while (currentVehicle != null)
            {
                if (currentVehicle.VehicleState1.Equals("Green Light"))
                {
                    Head = currentVehicle.Next;
                }
                currentVehicle = currentVehicle.Next;
            }
        }
        public bool CheckTrafficQueueEmpty()
        {
            if (Head == null)
            {
                Console.WriteLine("Traffic Queue is empty.");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
