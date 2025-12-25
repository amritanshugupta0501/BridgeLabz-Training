using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level3
{
    internal class CollinearityPoints
    {
        static void Main()
        {
            Console.WriteLine("Enter coordinates for Point A (x1, y1):");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinates for Point B (x2, y2):");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinates for Point C (x3, y3):");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            bool slopeCollinear = CheckCollinearSlope(x1, y1, x2, y2, x3, y3);
            bool areaCollinear = CheckCollinearArea(x1, y1, x2, y2, x3, y3);

            Console.WriteLine("\nCollinear Check (Slope Method): "+slopeCollinear);
            Console.WriteLine("Collinear Check (Area Method): "+ areaCollinear);
        }

        static bool CheckCollinearSlope(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // Handle vertical lines to avoid division by zero
            if ((x2 - x1) == 0 || (x3 - x2) == 0 || (x3 - x1) == 0)
            {
                return x1 == x2 && x2 == x3;
            }

            double slopeAB = (y2 - y1) / (x2 - x1);
            double slopeBC = (y3 - y2) / (x3 - x2);
            double slopeAC = (y3 - y1) / (x3 - x1);

            return slopeAB == slopeBC && slopeBC == slopeAC;
        }

        static bool CheckCollinearArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
            return area == 0;
        }
    }
}
