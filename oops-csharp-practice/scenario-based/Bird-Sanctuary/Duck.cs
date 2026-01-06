using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.bird_sanctuary
{
    internal class Duck : Bird, ISwimmable
    {
        public Duck(string name, int age) : base(name, age) { }

        public void Swim()
        {
            Console.WriteLine($"   -> {Name} the Duck is paddling on the water.");
        }
    }
}
