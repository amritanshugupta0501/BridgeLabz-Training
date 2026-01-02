using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.classandobject
{
    internal class CircleArea
    {
        double radius;
        double areaOfCircle;
        double perimeterOfCircle;
        public CircleArea(double radius)                        // Constructor to define characteristics of a circle
        {
            this.radius = radius;
        }
        public void CalculatePerimeter()                        // Method to calculate perimeter of a function using radius
        {
            perimeterOfCircle = 2 * Math.PI * radius;           // Circumference of a circle = 2 * 3.14 * radius
        }
        public void CalculateArea()
        {
            areaOfCircle = Math.PI * radius * radius;           // Area of a circle = 3.14 * radius * radius
        }
        public void DisplayAreaAndCircumference()               // Method to display the area and circumference of a circle
        {
            Console.WriteLine("Perimeter of the circle : " + perimeterOfCircle);
            Console.WriteLine("Area of the circle : " + areaOfCircle);
        }
    }
    internal class Program                                      // Program to initialize the application
    {
        static void Main()                                      // Main method to define the entry point of the application
        {
            Console.Write("Give the Radius of the circle : ");
            double radius = double.Parse(Console.ReadLine());
            CircleArea circle = new CircleArea(radius);         // Constructor called
            circle.CalculatePerimeter();
            circle.CalculateArea();
            circle.DisplayAreaAndCircumference();
        }
    }
}
