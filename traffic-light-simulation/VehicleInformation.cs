using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.Review.trafficlightsimulation
{
    internal class VehicleInformation
    {
        string VehicleNumber;
        string VehicleType;
        string VehicleState;
        public VehicleInformation Next;

        public string VehicleNumber1 { get => VehicleNumber; set => VehicleNumber = value; }
        public string VehicleType1 { get => VehicleType; set => VehicleType = value; }
        public string VehicleState1 { get => VehicleState; set => VehicleState = value; }

        public override string? ToString()
        {
            return $"Vehicle Number : {VehicleNumber1}\nVehicle Type : {VehicleType1}\nTraffic Light Status : {VehicleState1}";
        }
    }
}
