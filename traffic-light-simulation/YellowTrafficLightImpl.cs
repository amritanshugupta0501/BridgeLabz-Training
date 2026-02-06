using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.Review.trafficlightsimulation
{
    internal class YellowTrafficLightImpl : ILightsSimulation
    {
        public string StateOfTheVehicle(VehicleInformation newVehicle)
        {
            if (newVehicle.VehicleState1 == "Red Light")
            {
                Console.WriteLine("Start your engine "+newVehicle.VehicleNumber1);
                return "Yellow Light";
            }
            else if (newVehicle.VehicleState1 == "Green Light")
            {
                Console.WriteLine("Halt your vehicle.");
                return "Yellow Light";
            }
            else
                return newVehicle.VehicleState1;
        }
    }
}
