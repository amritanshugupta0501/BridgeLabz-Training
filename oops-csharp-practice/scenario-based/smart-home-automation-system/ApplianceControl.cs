using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.smarthomeautomationsystem
{
    internal class ApplianceControl
    {
        ElectricalAppliance Appliance;
        // Funtion to display all the appliances in your home
        public void DisplayAllAppliances()
        {
            Appliance = new ElectricalAppliance();
            Console.WriteLine("All Appliances in your home : ");
            for (int loop = 0; loop < Appliance.AppliancesCount1; loop++)
            {
                Console.WriteLine((loop+1)+". "+ElectricalAppliance.ElectricAppliances1[loop].ToString());
            }
        }
        // Function to Toggle the switch of an appliance
        public ElectricalAppliance ToggleAppliances(int index)
        {
            ElectricalAppliance.ElectricAppliances1[index].ApplianceState1 = ElectricalAppliance.ElectricAppliances1[index].ApplianceState1.Equals("Off") ? "On" : "Off";
            return Appliance;
        }
    }
}
