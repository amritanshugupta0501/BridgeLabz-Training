using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructor
{
    internal class Circle
    {
        double radius;
        public Circle()
        {
            radius = 4.5;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public void CalculateCircumferenceAndArea()
        {
            Console.WriteLine("Radius of the circle : " + radius);
            Console.WriteLine("CircumFerence of the circle : " + (2 * Math.PI * radius));
            Console.WriteLine("Area of the circle : " + (Math.PI * radius * radius));
        }
    }
    class Program
    {
        static void Main()
        {
            Circle circle = new Circle();
            circle.CalculateCircumferenceAndArea();
            Console.Write("Give the radius of the circle : ");
            double radius = double.Parse(Console.ReadLine());
            Circle circle1 = new Circle(radius);
            circle1.CalculateCircumferenceAndArea();
        }
    }
}
