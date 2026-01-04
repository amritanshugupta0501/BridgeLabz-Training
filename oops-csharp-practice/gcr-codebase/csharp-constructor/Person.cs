using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructor
{
    internal class Person
    {
        string name;
        int age;
        double height;
        double weight;
        public Person()
        {
            name = "John";
            age = 25;
            height = 175.5;
            weight = 60;
        }
        public Person(Person person)
        {
            this.name = person.name;
            this.age = person.age;
            this.height = person.height;
            this.weight = person.weight;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Person's Name : " + name);
            Console.WriteLine("Person's Age : " + age);
            Console.WriteLine("Person's Height : " + height);
            Console.WriteLine("Person's Weight : " + weight);
        }
    }
    class Program
    {
        static void Main()
        {
            Person person = new Person();
            person.DisplayDetails();
            Console.WriteLine();
            Console.WriteLine("Copy constructor values :");
            Person person2 = new Person(person);
            person2.DisplayDetails();

        }
    }
}
