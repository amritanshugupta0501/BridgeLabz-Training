using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinfunction.level2
{
    internal class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Give a number : ");
            int number = int.Parse(Console.ReadLine());
            bool result = CheckPrimeNumber(number);
            if(result)
            {
                Console.WriteLine(number+" is a Prime Number");
            }
            else
            {
                Console.WriteLine(number + " is not a Prime Number");
            }
        }
        static bool CheckPrimeNumber(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for(int loop = 2; loop <= number/2; loop++ )
            {
                if(number % loop == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
