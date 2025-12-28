using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinfunction.level2
{
    internal class MaximumOfThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Give three numbers of your choice : ");
            int number1 = GetNumber();
            int number2 = GetNumber();
            int number3 = GetNumber();
            int maximum = FindMaximum(number1, number2, number3);
            Console.WriteLine("The maximum of the three numbers is "+maximum);
        }
        static int GetNumber()
        {
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int FindMaximum(int number1, int number2, int number3)
        {
            return Math.Max(number1, Math.Max(number2, number3));
        }
    }
}
