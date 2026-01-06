using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.bird_sanctuary
{
    internal class Sparrow : Bird, IFlyable
    {
        public Sparrow(string name, int age) : base(name, age) { }

        public void Fly()
        {
            Console.WriteLine($"   -> {Name} the Sparrow is fluttering quickly.");
        }
    }
}
