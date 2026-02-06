using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.Review.trafficlightsimulation
{
    internal class GreenTrafficLightImpl : ILightsSimulation
    {
        public string StateOfTheVehicle(VehicleInformation newVehicle)
        {
            if (newVehicle.VehicleState1 == "Yellow Light")
            {
                Console.WriteLine("You are good to go " + newVehicle.VehicleNumber1);
                return "Green Light";
            }
            else
                return newVehicle.VehicleState1;
        }
    }
}
