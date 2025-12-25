using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class IntegerType
    {
        bool isPositive(int number)
        {
            return number > 0;
        }
        bool isNegative(int number)
        {
            return number < 0;
        }
        bool isZero(int number)
        {
            return number == 0;
        }
        bool isEven(int number)
        {
            return number % 2 == 0;
        }
        bool isOdd(int number)
        {
            return number % 2 == 1;
        }
        void compareNumbers(int number1, int number2)
        {
            if (number1 < number2)
            {
                Console.WriteLine("First element is less than Last element");
            }
            else if(number1 > number2) 
            {
                Console.WriteLine("First element is greater than Last element");
            }
            else
            {
                Console.WriteLine("First element is equal to Last element");
            }
        }
        static void Main()
        {
            IntegerType integerType = new IntegerType();
            int[] numbers = new int[5];
            for (int loop = 0; loop < numbers.Length; loop++)
            {
                Console.WriteLine("Give a number : ");
                numbers[loop] = int.Parse(Console.ReadLine());
                if(integerType.isPositive(numbers[loop]))
                {
                    if(integerType.isEven(numbers[loop]))
                    {
                        Console.WriteLine(numbers[loop]+" is a Positive Even number.");
                    }
                    else if(integerType.isOdd(numbers[loop]))
                    {
                        Console.WriteLine(numbers[loop] + " is a Positive Odd number.");
                    }
                }
                else if(integerType.isNegative(numbers[loop]))
                {
                    Console.WriteLine(numbers[loop] + " is a Negative number.");
                }
                else if(integerType.isZero(numbers[loop]))
                {
                    Console.WriteLine(numbers[loop] + " is a Zero.");
                }
            }
            integerType.compareNumbers(numbers[0], numbers[4]);
        }
    }
}
