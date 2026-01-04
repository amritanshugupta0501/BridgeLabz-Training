using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{
    // Base gadget class
    class Gadget
    {
        public int GadgetId;
        public string OperationalMode;

        public Gadget(int id, string mode)
        {
            GadgetId = id;
            OperationalMode = mode;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"ID     : {GadgetId}");
            Console.WriteLine($"Status : {OperationalMode}");
        }
    }

    // Derived class
    class HeatSensor : Gadget
    {
        public int TempValue;

        public HeatSensor(int id, string mode, int val)
            : base(id, mode)
        {
            TempValue = val;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Temp   : {TempValue}");
        }
    }

    class Program
    {
        static void Main()
        {
            HeatSensor hs = new HeatSensor(1, "ON", 24);
            hs.PrintInfo();
        }
    }
}