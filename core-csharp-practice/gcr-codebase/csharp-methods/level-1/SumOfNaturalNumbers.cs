using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class SumOfNaturalNumbers
    {
        int NaturalNumberSum(int number)
        {
            if(number == 0)
            {
                return 0; 
            }
            return (NaturalNumberSum(number - 1)) + number;
        }
        static void Main()
        {
            Console.WriteLine("Give any number for the range : ");
            int number = int.Parse(Console.ReadLine());
            SumOfNaturalNumbers obj = new SumOfNaturalNumbers();
            int sumOfNumbers = obj.NaturalNumberSum(number);
            Console.WriteLine("Sum of " + number + " natural numbers : " + sumOfNumbers);
        }
    }
}
