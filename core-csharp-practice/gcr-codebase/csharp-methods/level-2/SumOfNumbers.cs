using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class SumOfNumbers
    {
        int NumbersSum(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            return (NumbersSum(number - 1)) + number;
        }
        int NumbersSumFormula(int number)
        {
            return (number * (number + 1))/2;
        }
        static void Main()
        {
            Console.WriteLine("Give a number to find sum : ");
            int number = int.Parse(Console.ReadLine());
            SumOfNumbers sumOfNumbers = new SumOfNumbers();
            if(number > 0)
            {
                int formula = sumOfNumbers.NumbersSumFormula(number);
                int recursion = sumOfNumbers.NumbersSum(number);
                if(formula == recursion)
                {
                    Console.WriteLine("Sum of "+number+" natural numbers : "+recursion);
                    Console.WriteLine("The results of recursion and formula are same.");
                }
                else
                {
                    Console.WriteLine("The results are not same.");
                }
                
            }
            else
            {
                Console.WriteLine("The number "+ number +" is not a natural number");
            }
        }
    }
}
