using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinfunction.level2
{
    internal class TemperatureConverter
    {
        static void Main()
        {
            Console.WriteLine("Choose temperature conversion : \n1. Celsius to Fahrenheit \n2. Fahrenheit to Celsius");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter the temperature in Celsius : ");
                    double tempCelsius = double.Parse(Console.ReadLine());
                    Console.WriteLine(tempCelsius + " celsius = " + CelsiusToFahrenheit(tempCelsius) + " fahrenheit");
                    break;
                case 2:
                    Console.WriteLine("Enter the temperature in Faherenheit : ");
                    double tempFahrenheit = double.Parse(Console.ReadLine());
                    Console.WriteLine(tempFahrenheit + " celsius = " + FahrenheitToCelsius(tempFahrenheit) + " fahrenheit");
                    break;
                default:
                    Console.WriteLine("Invalid Choice Entered.");
                    break;
            }
        }
        static double CelsiusToFahrenheit(double tempCelsius)
        {
            return (tempCelsius * 9 / 5) + 32;
        }
        static double FahrenheitToCelsius(double tempFahrenheit)
        {
            return (tempFahrenheit - 32) * 5 / 9; 
        }
    }
}
