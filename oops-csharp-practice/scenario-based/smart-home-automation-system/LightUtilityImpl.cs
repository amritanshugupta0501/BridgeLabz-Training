using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.smarthomeautomationsystem
{
    internal class LightUtilityImpl : ElectricalAppliance, IControllable
    {
        // Constructor to define the properties of an appliance
        public LightUtilityImpl()
        {
            ApplianceName1 = "Light";
            ApplianceState1 = "Off";
            ElectricAppliances1[AppliancesCount1] = this;
            AppliancesCount1++;
        }
        // Implemented method to turn off an appliance
        public void TurnOff()
        {
            ApplianceState1 = "Off";
            Console.WriteLine(ToString());
        }
        // Implemented method to turn on an appliance
        public void TurnOn()
        {
            ApplianceState1 = "On";
            Console.WriteLine(ToString());
        }
    }
}
