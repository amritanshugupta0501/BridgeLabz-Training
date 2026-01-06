using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.bird_sanctuary
{
    class Bird
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Bird(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public override string ToString()
        {
            return $"Bird: {Name} ({this.GetType().Name}), Age: {Age}";
        }
    }
}
