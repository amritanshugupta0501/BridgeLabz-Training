using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.Review.trafficlightsimulation
{
    internal class RedTrafficLightImpl : ILightsSimulation
    {
        VehicleInformation Head;
        public string StateOfTheVehicle(VehicleInformation newVehicle)
        {
            if (newVehicle.VehicleState1 == null)
                return "Red Light";
            else if (newVehicle.VehicleState1 == "Yellow Light")
            {
                Console.WriteLine("Stop your Vehicle engine  " + newVehicle.VehicleNumber1);
                return "Red Light";
            }
            return newVehicle.VehicleState1;
        }
    }
}
