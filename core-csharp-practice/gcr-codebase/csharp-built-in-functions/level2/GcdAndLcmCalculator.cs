using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinfunction.level2
{
    internal class GcdAndLcmCalculator
    {
        static void Main()
        {
            Console.WriteLine("Give two numbers : ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int gcd = CalculateGCD(number1, number2);
            int lcm = CalculateLCM(number1, number2);
            Console.WriteLine("GCD of " + number1 + " and " + number2 + " is " + gcd);
            Console.WriteLine("LCM of " + number1 + " and " + number2 + " is " + lcm);
        }
        static int CalculateGCD(int number1, int number2)
        { 
            while(number2 != 0)
            {
                int temp = number2;
                number2 = number1 % number2 ;
                number1 = temp;
            }
            return number1;
        }
        static int CalculateLCM(int number1, int number2)
        {
            int product = number1 * number2;
            int gcd = CalculateGCD(number1, number2);
            return product / gcd;
        }
    }
}
