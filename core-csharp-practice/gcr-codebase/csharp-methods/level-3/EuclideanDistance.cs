using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level3
{
    internal class EuclideanDistance
    {
        static void Main()
        {
            
            Console.Write("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());

            double distance = GetEuclideanDistance(x1, y1, x2, y2);
            Console.WriteLine("\nEuclidean Distance: "+distance);

            if (x1 == x2)
            {
                Console.WriteLine("Line Equation: x = " + x1);
            }
            else
            {
                double[] lineParams = GetLineEquation(x1, y1, x2, y2);
                double m = lineParams[0];
                double b = lineParams[1];

                char sign = (b >= 0) ? '+' : '-';
                Console.WriteLine("Line Equation: y = "+m+"x "+sign+" "+Math.Abs(b));
            }
        }

        static double GetEuclideanDistance(double x1, double y1, double x2, double y2)
        {
            double xDiffSq = Math.Pow(x2 - x1, 2);
            double yDiffSq = Math.Pow(y2 - y1, 2);
            return Math.Sqrt(xDiffSq + yDiffSq);
        }

        static double[] GetLineEquation(double x1, double y1, double x2, double y2)
        {
            double m = (y2 - y1) / (x2 - x1);
            double b = y1 - (m * x1);

            return new double[] { m, b };
        }
    }
}
