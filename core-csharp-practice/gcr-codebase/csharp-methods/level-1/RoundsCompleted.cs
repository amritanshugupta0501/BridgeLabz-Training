using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class RoundsCompleted
    {
        double NumberOfRounds(double side1, double side2, double side3)
        {
            double perimeter = side1 + side2 + side3;
            double numberOfRounds = 5 / perimeter;
            return numberOfRounds;
        }
        static void Main()
        {
            Console.WriteLine("Give the perimeters of a triangular park side : ");
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double side3 = double.Parse(Console.ReadLine());
            RoundsCompleted obj = new RoundsCompleted();
            Console.WriteLine("Number of rounds to be completed by the athlete : " + obj.NumberOfRounds(side1,side2,side3));

        }
    }
}
