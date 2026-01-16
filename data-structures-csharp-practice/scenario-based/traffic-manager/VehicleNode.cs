using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.TrafficManager
{
    internal class VehicleNode
    {
        public VehicleInformation Data;
        public VehicleNode Next;
        public VehicleNode(VehicleInformation data)
        {
            Data = data;
        }

    }
}
