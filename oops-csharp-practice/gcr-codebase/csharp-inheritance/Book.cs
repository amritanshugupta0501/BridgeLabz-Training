using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{
    // Parent class
    internal class Literature
    {
        public string NameOfBook;
        public int YearReleased;

        public Literature(string name, int yr)
        {
            NameOfBook = name;
            YearReleased = yr;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Book  : {NameOfBook}");
            Console.WriteLine($"Year  : {YearReleased}");
        }
    }

    // Child class with author info
    class WriterInfo : Literature
    {
        public string WriterName;
        public string WriterBio;

        public WriterInfo(string name, int yr, string writer, string bio)
            : base(name, yr)
        {
            WriterName = writer;
            WriterBio = bio;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Author: {WriterName}");
            Console.WriteLine($"About : {WriterBio}");
        }
    }

    class Program
    {
        static void Main()
        {
            WriterInfo w = new WriterInfo("Clean Code", 2008, "Robert Martin", "Software Engineer");
            w.ShowDetails();
        }
    }
}