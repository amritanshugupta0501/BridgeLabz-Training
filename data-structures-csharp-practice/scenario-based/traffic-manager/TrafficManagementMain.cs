using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.TrafficManager
{
    // Entry point of the application system
    internal class TrafficManagementMain
    {
        static void Main(string[] args)
        {
            TrafficManagementMenu trafficManagementMenu = new TrafficManagementMenu();
            trafficManagementMenu.HomeMenu();
        }
    }
}
