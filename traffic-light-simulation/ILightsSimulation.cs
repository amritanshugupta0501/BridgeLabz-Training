using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.Review.trafficlightsimulation
{
    internal interface ILightsSimulation
    {
        string StateOfTheVehicle(VehicleInformation newVehicle);
    }
}
