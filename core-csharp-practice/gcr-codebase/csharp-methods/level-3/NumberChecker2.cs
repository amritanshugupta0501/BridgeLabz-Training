using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level3
{
    internal class NumberChecker2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int count = GetDigitCount(number);
            int[] digits = GetDigitsArray(number);
            Console.WriteLine("Count of digits: "+count);
            Console.WriteLine("Digits: " + string.Join(", ", digits));

            int sum = GetSumOfDigits(digits);
            Console.WriteLine("Sum of digits: "+sum);

            double sumSquares = GetSumOfSquares(digits);
            Console.WriteLine("Sum of squares: "+sumSquares);

            bool isHarshad = IsHarshadNumber(number, digits);
            if (isHarshad)
                Console.WriteLine("Is Harshad Number: True ("+number+" is divisible by "+sum+")");
            else
                Console.WriteLine("Is Harshad Number: False ("+number+" is not divisible by "+sum+")");

            Console.WriteLine("\nDigit Frequency:");
            Console.WriteLine("Digit\tFrequency");

            int[,] frequencies = GetFrequency(digits);

            for (int i = 0; i < 10; i++)
            {
                if (frequencies[i, 1] > 0)
                {
                    Console.WriteLine(frequencies[i, 0]+"\t"+frequencies[i, 1]);
                }
            }
        }

        static int GetDigitCount(int number)
        {
            return number.ToString().Length;
        }

        static int[] GetDigitsArray(int number)
        {
            string numStr = number.ToString();
            int[] digits = new int[numStr.Length];

            for (int i = 0; i < numStr.Length; i++)
            {
                digits[i] = (int)Char.GetNumericValue(numStr[i]);
            }
            return digits;
        }

        static int GetSumOfDigits(int[] digits)
        {
            int sum = 0;
            foreach (int digit in digits)
            {
                sum += digit;
            }
            return sum;
        }

        static double GetSumOfSquares(int[] digits)
        {
            double sum = 0;
            foreach (int digit in digits)
            {
                sum += Math.Pow(digit, 2);
            }
            return sum;
        }

        static bool IsHarshadNumber(int originalNumber, int[] digits)
        {
            int sum = GetSumOfDigits(digits);
            return (originalNumber % sum == 0);
        }

        static int[,] GetFrequency(int[] digits)
        {
            int[,] frequencyMatrix = new int[10, 2];

            for (int i = 0; i < 10; i++)
            {
                frequencyMatrix[i, 0] = i;
                frequencyMatrix[i, 1] = 0;
            }

            foreach (int digit in digits)
            {
                frequencyMatrix[digit, 1]++;
            }

            return frequencyMatrix;
        }
    }
}
