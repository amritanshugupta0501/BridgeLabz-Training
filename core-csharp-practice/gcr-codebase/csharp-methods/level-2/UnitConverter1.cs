using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class UnitConverter1
    {
        public static double ConvertKmToMiles(double km)
        {
            return km * 0.621371;
        }

        public static double ConvertMilesToKm(double miles)
        {
            return miles * 1.60934;
        }

        public static double ConvertMetersToFeet(double meters)
        {
            return meters * 3.28084;
        }

        public static double ConvertFeetToMeters(double feet)
        {
            return feet * 0.3048;
        }
        static void Main(string[] args)
        {

            Console.Write("Enter Kilometers: ");
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} km = {1:F4} miles", km, UnitConverter1.ConvertKmToMiles(km));

            Console.Write("\nEnter Miles: ");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} miles = {1:F4} km", miles, UnitConverter1.ConvertMilesToKm(miles));

            Console.Write("\nEnter Meters: ");
            double meters = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} m = {1:F4} ft", meters, UnitConverter1.ConvertMetersToFeet(meters));

            Console.Write("\nEnter Feet: ");
            double feet = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} ft = {1:F4} m", feet, UnitConverter1.ConvertFeetToMeters(feet));

        }
    }
}
