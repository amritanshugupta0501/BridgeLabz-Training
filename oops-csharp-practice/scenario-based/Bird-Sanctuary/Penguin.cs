using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.bird_sanctuary
{
    internal class Penguin : Bird, ISwimmable
    {
        public Penguin(string name, int age) : base(name, age) { }

        public void Swim()
        {
            Console.WriteLine($"   -> {Name} the Penguin is diving deep underwater.");
        }
    }
}
