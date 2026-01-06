using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.bird_sanctuary
{
    internal class Seagull : Bird, IFlyable, ISwimmable
    {
        public Seagull(string name, int age) : base(name, age) { }

        public void Fly()
        {
            Console.WriteLine($"   -> {Name} the Seagull is gliding over the ocean.");
        }

        public void Swim()
        {
            Console.WriteLine($"   -> {Name} the Seagull is floating on the waves.");
        }
    }
}
