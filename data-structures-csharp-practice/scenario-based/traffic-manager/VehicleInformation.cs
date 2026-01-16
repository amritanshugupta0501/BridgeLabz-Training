using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.TrafficManager
{
    internal class VehicleInformation
    {
        public string VehicleNumber;
        string VehicleType;
        public VehicleInformation(string VehicleNumber, string VehicleType)
        {
            this.VehicleNumber = VehicleNumber;
            this.VehicleType = VehicleType;
        }

        public override string? ToString()
        {
            return $"Vehicle Number : {VehicleNumber}\nVehicle Type : {VehicleType}";
        }
    }
}
