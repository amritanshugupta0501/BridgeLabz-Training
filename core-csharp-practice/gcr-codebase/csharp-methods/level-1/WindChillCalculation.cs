using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class WindChillCalculation
    {
        double CalculateWindChill(double temperature, double speed)
        {
            double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * speed*0.16;
            return windChill;
        }
        static void Main()
        {
            Console.WriteLine("Give the temperature and speed of the wind : ");
            double windTemperature = double.Parse(Console.ReadLine());
            double windSpeed = double.Parse(Console.ReadLine());
            WindChillCalculation windCalculation = new WindChillCalculation();
            double result = windCalculation.CalculateWindChill(windTemperature, windSpeed);
            Console.WriteLine("Wind Chill for the wind with speed "+windSpeed+" and temperature "+windTemperature+" is "+result);
        }
    }
}
