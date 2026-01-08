using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.smarthomeautomationsystem
{
    internal class ElectricalAppliance
    {
        private static ElectricalAppliance[] ElectricAppliances = new ElectricalAppliance[100];
        private string ApplianceName;
        private string ApplianceState;
        private static int AppliancesCount;
        public string ApplianceName1 { get => ApplianceName; set => ApplianceName = value; }
        public string ApplianceState1 { get => ApplianceState; set => ApplianceState = value; }
        public int AppliancesCount1 { get => AppliancesCount; set => AppliancesCount = value; }
        internal static ElectricalAppliance[] ElectricAppliances1 { get => ElectricAppliances; set => ElectricAppliances = value; }
        public override string? ToString()
        {
            return $"{ApplianceName1} is switched {ApplianceState1}";
        }
    }
}