using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class UnitConverter2
    {
        public static double ConvertYardsToFeet(double yards)
        {
            return yards * 3;
        }

        public static double ConvertFeetToYards(double feet)
        {
            return feet * 0.333333;
        }

        public static double ConvertMetersToInches(double meters)
        {
            return meters * 39.3701;
        }

        public static double ConvertInchesToMeters(double inches)
        {
            return inches * 0.0254;
        }

        public static double ConvertInchesToCentimeters(double inches)
        {
            return inches * 2.54;
        }
        static void Main()
        {
            Console.Write("Enter Yards: ");
            double yards = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} yards = {1:F4} feet", yards, UnitConverter2.ConvertYardsToFeet(yards));

            Console.Write("\nEnter Feet: ");
            double feet = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} feet = {1:F4} yards", feet, UnitConverter2.ConvertFeetToYards(feet));

            Console.Write("\nEnter Meters: ");
            double meters = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} meters = {1:F4} inches", meters, UnitConverter2.ConvertMetersToInches(meters));

            Console.Write("\nEnter Inches: ");
            double inches = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} inches = {1:F4} meters", inches, UnitConverter2.ConvertInchesToMeters(inches));
            Console.WriteLine("{0} inches = {1:F4} cm", inches, UnitConverter2.ConvertInchesToCentimeters(inches));

        }
    }
}
