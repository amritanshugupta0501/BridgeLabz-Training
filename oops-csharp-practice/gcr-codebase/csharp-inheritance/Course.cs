using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{
    // Base class
    internal class StudyModule
    {
        public string ModuleTitle;
        public int TotalHours;

        public StudyModule(string title, int hrs)
        {
            ModuleTitle = title;
            TotalHours = hrs;
        }

        public virtual void ShowData()
        {
            Console.WriteLine($"Topic    : {ModuleTitle}");
            Console.WriteLine($"Duration : {TotalHours} hours");
        }
    }

    // Intermediate subclass
    class VirtualClass : StudyModule
    {
        public string HostedOn;
        public bool IsSaved;

        public VirtualClass(string title, int hrs, string host, bool saved)
            : base(title, hrs)
        {
            HostedOn = host;
            IsSaved = saved;
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Site     : {HostedOn}");
            Console.WriteLine($"Recorded : {IsSaved}");
        }
    }

    // Final subclass
    class PremiumCourse : VirtualClass
    {
        public double Price;
        public double Offer;

        public PremiumCourse(
            string title,
            int hrs,
            string host,
            bool saved,
            double price,
            double offer)
            : base(title, hrs, host, saved)
        {
            Price = price;
            Offer = offer;
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Cost     : ₹{Price}");
            Console.WriteLine($"Discount : {Offer}%");
        }
    }

    class Program
    {
        static void Main()
        {
            StudyModule sm =
                new PremiumCourse("C# Full Stack", 120, "Udemy", true, 9999, 20);

            sm.ShowData();
        }
    }
}