using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class QuotientRemainder
    {
        int[] DividendDivisor(int dividend, int divisor)
        {
            int[] result = new int[2];
            result[0] = dividend / divisor;
            result[1] = dividend % divisor;
            return result;
        }
        static void Main()
        {
            Console.WriteLine("Give any two numbers : ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            QuotientRemainder quotientRemainder = new QuotientRemainder();
            int[] result = quotientRemainder.DividendDivisor(number1, number2);
            Console.WriteLine("Quotient of the two numbers "+number1+" and "+number2+" : " + result[0]);
            Console.WriteLine("Remainder of the two numbers " + number1 + " and " + number2 + " : " + result[1]);
        }
    }
}
