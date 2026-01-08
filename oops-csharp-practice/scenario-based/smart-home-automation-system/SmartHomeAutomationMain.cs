using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.smarthomeautomationsystem
{
    // Entry point of the application
    internal class SmartHomeAutomationMain
    {
        static void Main(string[] args)
        {
            SmartHomeApplicationMenu smartHomeAppliances = new SmartHomeApplicationMenu();
            smartHomeAppliances.HomeMenu();
        }
    }
}
