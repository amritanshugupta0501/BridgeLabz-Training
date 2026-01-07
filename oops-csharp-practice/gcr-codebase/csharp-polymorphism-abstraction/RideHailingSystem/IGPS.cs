using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.RideHailingSystem
{
    internal interface IGPS
    {
        string GetCurrentLocation();
        void UpdateLocation(double latitude, double longitude);
    }
}
