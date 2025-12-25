using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class QuadraticEquations
    {
        double[] FindRoots(int a, int b, int c)
        {
            double[] result = new double[2];
            double delta = Math.Pow(b, 2) + (4 * a * c);
            if(delta > 0)
            {
                result[0] = (-b + delta) / (2 * a);
                result[1] = (-b - delta) / (2 * a);
            }
            else if(delta == 0)
            {
                result[0] = (-b) / (2 * a);
                result[1] = (-b) / (2 * a);
            }
                return result;
        }
        static void Main()
        {
            Console.WriteLine("Give the value of a, b, c in the quadratic equation (ax^2 + bx + c) : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            QuadraticEquations equations = new QuadraticEquations();
            double[] result = equations.FindRoots(a, b, c);
            if (result[0] != result[1])
            {
                Console.WriteLine("Quadratic Roots of the equation (" + a + "x^2 + " + b + "x + " + c + ") : " + result[0] + " & " + result[1]);
            }
            else if (result[0] == result[1])
            {
                Console.WriteLine("Quadratic Roots of the equation (" + a + "x^2 + " + b + "x + " + c + ") : " + result[0]);
            }
            else
            {
                Console.WriteLine("The Roots are unreal.");
            }
        }
    }
}
