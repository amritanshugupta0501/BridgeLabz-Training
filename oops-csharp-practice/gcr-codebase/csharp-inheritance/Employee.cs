using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{   
    // Base class for staff members
    internal class CorporateStaff
    {
        public string FullName;
        public int EmpCode;
        public double MonthlyWage;

        public CorporateStaff(string name, int code, double wage)
        {
            FullName = name;
            EmpCode = code;
            MonthlyWage = wage;
        }

        // Virtual method for displaying info
        public virtual void PrintProfile()
        {
            Console.WriteLine($"Employee : {FullName}");
            Console.WriteLine($"Code     : {EmpCode}");
            Console.WriteLine($"Pay      : {MonthlyWage}");
        }
    }

    // Derived class for Managers
    class Supervisor : CorporateStaff
    {
        public int GroupSize;

        public Supervisor(string name, int code, double wage, int size)
            : base(name, code, wage)
        {
            GroupSize = size;
        }

        public override void PrintProfile()
        {
            base.PrintProfile();
            Console.WriteLine($"Managing : {GroupSize} people");
        }
    }

    // Derived class for Developers
    class Coder : CorporateStaff
    {
        public string TechStack;

        public Coder(string name, int code, double wage, string tech)
            : base(name, code, wage)
        {
            TechStack = tech;
        }

        public override void PrintProfile()
        {
            base.PrintProfile();
            Console.WriteLine($"Skill    : {TechStack}");
        }
    }

    // Derived class for Interns
    class Apprentice : CorporateStaff
    {
        public string Tenure;

        public Apprentice(string name, int code, double wage, string time)
            : base(name, code, wage)
        {
            Tenure = time;
        }

        public override void PrintProfile()
        {
            base.PrintProfile();
            Console.WriteLine($"Period   : {Tenure}");
        }
    }

    class Program
    {
        static void Main()
        {
            CorporateStaff cs1 = new Supervisor("Atishay", 101, 80000, 5);
            CorporateStaff cs2 = new Coder("Rohit", 102, 70000, "C#");
            CorporateStaff cs3 = new Apprentice("Amit", 103, 15000, "6 Months");

            cs1.PrintProfile();
            Console.WriteLine();

            cs2.PrintProfile();
            Console.WriteLine();

            cs3.PrintProfile();
        }
    }
}