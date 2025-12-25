using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class TrignometricCalculations
    {
        double[] TrignometricValues(double angle)
        {
            double[] result = new double[3];
            result[0] = Math.Sin(angle);
            result[1] = Math.Cos(angle);
            result [2] = Math.Tan(angle);
            return result;
        }
        static void Main()
        {
            Console.WriteLine("Give an angle in degrees : ");
            double angle = double.Parse(Console.ReadLine());
            double angleRadians = (Math.PI * angle) / 180;
            TrignometricCalculations trignometricCalculations = new TrignometricCalculations();
            double[] result = trignometricCalculations.TrignometricValues(angleRadians);
            Console.WriteLine("Sine Function of the Angle " + angle + " : " + result[0]);
            Console.WriteLine("Cosine Function of the Angle " + angle + " : " + result[1]);
            Console.WriteLine("Tangent Function of the Angle " + angle + " : " + result[2]);
        }
    }
}
