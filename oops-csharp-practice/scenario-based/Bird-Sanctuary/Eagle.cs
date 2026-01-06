using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.bird_sanctuary
{
    internal class Eagle : Bird, IFlyable
    {
        public Eagle(string name, int age) : base(name, age) { }

        public void Fly()
        {
            Console.WriteLine($"   -> {Name} the Eagle is soaring high in the clouds.");
        }

    }
}
