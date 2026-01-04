using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{
    // Parent Class
    internal class CreatureBase
    {
        public string PetName { get; set; }
        public int LifeYears { get; set; }

        public CreatureBase(string name, int age)
        {
            PetName = name;
            LifeYears = age;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Creature makes a noise");
        }
    }

    // Child Dog
    class Hound : CreatureBase
    {
        public Hound(string name, int age) : base(name, age) { }

        public override void Speak()
        {
            Console.WriteLine("Hound: Barking");
        }
    }

    // Child Cat
    class Feline : CreatureBase
    {
        public Feline(string name, int age) : base(name, age) { }

        public override void Speak()
        {
            Console.WriteLine("Feline: Meowing");
        }
    }

    // Child Bird
    class Avian : CreatureBase
    {
        public Avian(string name, int age) : base(name, age) { }

        public override void Speak()
        {
            Console.WriteLine("Avian: Chirping");
        }
    }

    class Program
    {
        static void Main()
        {
            CreatureBase a1 = new Hound("Buddy", 3);
            CreatureBase a2 = new Feline("Whiskers", 2);
            CreatureBase a3 = new Avian("Tweety", 1);

            a1.Speak();
            a2.Speak();
            a3.Speak();
        }
    }
}