using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.Review.trafficlightsimulation
{
    internal class TrafficLightMenu
    {
        ITrafficLightUtility TrafficLight;
        public void HomeMenu()
        {
            TrafficLight = new TrafficLightUtility();
            Console.WriteLine("Welcome to traffic light simulation system!");
            while (true)
            {
                Console.WriteLine("1. Start the Traffic Light Simulation.");
                Console.WriteLine("2. Exit the simulation.");
                var choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        TrafficLight.InitalizeTrafficLights();
                        break;
                    default:
                        Console.WriteLine("Hope you have a good day!");
                        return;
                }
            }
        }
    }
}
