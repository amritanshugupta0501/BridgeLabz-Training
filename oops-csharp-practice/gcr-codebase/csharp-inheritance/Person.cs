using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{
    // Base Entity
    internal class SchoolIndividual
    {
        public string PersonName;
        public int PersonAge;

        public SchoolIndividual(string name, int age)
        {
            PersonName = name;
            PersonAge = age;
        }

        public virtual void RevealIdentity()
        {
            Console.WriteLine("Member of the institution");
        }
    }

    // Derived Teacher
    class FacultyMember : SchoolIndividual
    {
        public string Specialization;

        public FacultyMember(string name, int age, string spec)
            : base(name, age)
        {
            Specialization = spec;
        }

        public override void RevealIdentity()
        {
            Console.WriteLine("Role    : Faculty");
            Console.WriteLine($"Name    : {PersonName}");
            Console.WriteLine($"Age     : {PersonAge}");
            Console.WriteLine($"Subject : {Specialization}");
        }
    }

    // Derived Student
    class Scholar : SchoolIndividual
    {
        public string ClassSection;

        public Scholar(string name, int age, string section)
            : base(name, age)
        {
            ClassSection = section;
        }

        public override void RevealIdentity()
        {
            Console.WriteLine("Role    : Scholar");
            Console.WriteLine($"Name    : {PersonName}");
            Console.WriteLine($"Age     : {PersonAge}");
            Console.WriteLine($"Grade   : {ClassSection}");
        }
    }

    // Derived Staff
    class AdminWorker : SchoolIndividual
    {
        public string OfficeDept;

        public AdminWorker(string name, int age, string dept)
            : base(name, age)
        {
            OfficeDept = dept;
        }

        public override void RevealIdentity()
        {
            Console.WriteLine("Role    : Admin Staff");
            Console.WriteLine($"Name    : {PersonName}");
            Console.WriteLine($"Age     : {PersonAge}");
            Console.WriteLine($"Dept    : {OfficeDept}");
        }
    }

    class Program
    {
        static void Main()
        {
            SchoolIndividual p1 = new FacultyMember("Mr. Sharma", 40, "Mathematics");
            SchoolIndividual p2 = new Scholar("Atishay Garg", 21, "A");
            SchoolIndividual p3 = new AdminWorker("Ramesh", 45, "Administration");

            p1.RevealIdentity();
            Console.WriteLine();

            p2.RevealIdentity();
            Console.WriteLine();

            p3.RevealIdentity();
        }
    }
}