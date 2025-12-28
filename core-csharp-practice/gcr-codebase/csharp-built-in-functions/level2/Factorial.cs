using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinfunction.level2
{
    internal class Factorial
    {
        static void Main()
        {
            Console.WriteLine("Get a number : ");
            int number = int.Parse(Console.ReadLine());
            int result = CalculateFactorial(number);
            Console.WriteLine("Factorial of the number " + number + " : " + result);
        }
        static int CalculateFactorial(int number)
        {
            if(number==1)
            {
                return 1;
            }
            return number * CalculateFactorial(number-1);
        }
    }
}
