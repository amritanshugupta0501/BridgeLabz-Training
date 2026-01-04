using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructor
{
    internal class UniversityManagement
    {
        public int rollNumber;
        protected string name;
        private double cgpa;
        public UniversityManagement(int rollNumber, string name)
        {
            this.rollNumber = rollNumber;
            this.name = name;
        }
        public void SetCGPA(double cgpa)
        {
            this.cgpa = cgpa;
        }
        public double GetCGPA()
        {
            return this.cgpa;
        }

    }
    class PostGraduateStudent : UniversityManagement
    {
        public PostGraduateStudent(int rollNumber, string name) : base(rollNumber, name) { }
        public void DisplayDetails()
        {
            Console.WriteLine("Student name : " + name);
            Console.WriteLine("Student Roll number : " + rollNumber);
            Console.WriteLine("Student CGPA : " + GetCGPA());
        }

    }
    class Program
    {
        static void Main()
        {
            Console.Write("Give student roll number : ");
            int rollNumber = int.Parse(Console.ReadLine());
            Console.Write("Give student name : ");
            string name = Console.ReadLine();
            PostGraduateStudent student = new PostGraduateStudent(rollNumber, name);
            Console.WriteLine("Give CGPA of student : ");
            double cgpa = double.Parse(Console.ReadLine());
            student.SetCGPA(cgpa);
            student.DisplayDetails();
        }
    }
}
