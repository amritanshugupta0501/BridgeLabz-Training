using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class UnitConverter3
    {
        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double ConvertPoundsToKilograms(double pounds)
        {
            return pounds * 0.453592;
        }

        public static double ConvertKilogramsToPounds(double kilograms)
        {
            return kilograms * 2.20462;
        }

        public static double ConvertGallonsToLiters(double gallons)
        {
            return gallons * 3.78541;
        }

        public static double ConvertLitersToGallons(double liters)
        {
            return liters * 0.264172;
        }
        static void Main()
        {

            Console.Write("Enter Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} °F = {1:F4} °C", fahrenheit, UnitConverter3.ConvertFahrenheitToCelsius(fahrenheit));

            Console.Write("\nEnter Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} °C = {1:F4} °F", celsius, UnitConverter3.ConvertCelsiusToFahrenheit(celsius));

            Console.Write("\nEnter Pounds: ");
            double pounds = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} lbs = {1:F4} kg", pounds, UnitConverter3.ConvertPoundsToKilograms(pounds));

            Console.Write("\nEnter Kilograms: ");
            double kilograms = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} kg = {1:F4} lbs", kilograms, UnitConverter3.ConvertKilogramsToPounds(kilograms));

            Console.Write("\nEnter Gallons: ");
            double gallons = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} gallons = {1:F4} liters", gallons, UnitConverter3.ConvertGallonsToLiters(gallons));

            Console.Write("\nEnter Liters: ");
            double liters = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} liters = {1:F4} gallons", liters, UnitConverter3.ConvertLitersToGallons(liters));

        }
    }
}
