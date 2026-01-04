using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{
    // Base class for automation systems
    internal class HomeAutomation
    {
        public int SysId;
        public string CurrentMode;

        public HomeAutomation(int id, string mode)
        {
            SysId = id;
            CurrentMode = mode;
        }

        public virtual void ShowState()
        {
            Console.WriteLine($"System ID : {SysId}");
            Console.WriteLine($"Mode      : {CurrentMode}");
        }
    }

    // Derived class for temperature control
    class TempController : HomeAutomation
    {
        public int TargetTemp;

        public TempController(int id, string mode, int temp) : base(id, mode)
        {
            TargetTemp = temp;
        }

        public override void ShowState()
        {
            base.ShowState();
            Console.WriteLine($"Setting   : {TargetTemp}°C");
        }
    }

    class Program
    {
        static void Main()
        {
            TempController tc = new TempController(1, "Active", 24);
            tc.ShowState();
        }
    }
}