using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level3
{
    internal class NumberChecker
    {
        static int GetDigitCount(int number)
        {
            return number.ToString().Length;
        }
        static int[] GetDigitsArray(int number)
        {
            int[] digits = new int[NumberChecker.GetDigitCount(number)];
            int index = 0;
            while (number > 0)
            {
                digits[index++] = number%10;
                number /= 10;
            }
            return digits;
        }
        static bool IsDuckNumber(int[] digits)
        {
            for (int loop = 0; loop < digits.Length; loop++)
            {
                if( digits[loop] == 0 )
                {
                    return true; 
                }
            }
            return false;
        }
        static bool IsArmstrongNumber(int[] digits, int original) 
        {
            int sum = 0;
            for (int loop = 0; loop < digits.Length; loop++) 
            {
                sum += (int)Math.Pow(digits[loop], digits.Length);
            }
            return sum == original;
        }
        static void LargestAndSecondLargest(int[] digits)
        {
            int largest = Int32.MinValue;
            int secondLargest = Int32.MinValue;
            for (int loop = 0; loop < digits.Length; loop++)
            {
                if (digits[loop] > largest)
                {
                    secondLargest = largest;
                    largest = digits[loop];
                }
                else if (digits[loop] > secondLargest && digits[loop] != secondLargest)
                {
                    secondLargest = digits[loop];
                }
            }
            Console.WriteLine("Largest digit : " + largest + "\nSecond Largest Digit : " + secondLargest);
        }
        static void LargestAndSecondSmallest(int[] digits)
        {
            int smallest = Int32.MaxValue;
            int secondSmallest = Int32.MaxValue;
            for (int loop = 0; loop < digits.Length; loop++)
            {
                if (digits[loop] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = digits[loop];
                }
                else if (digits[loop] > secondSmallest && digits[loop] != secondSmallest)
                {
                    secondSmallest = digits[loop];
                }
            }
            Console.WriteLine("Smallest digit : " + smallest + "\nSecond Smallest Digit : " + secondSmallest);
        }
        static void Main()
        {
            Console.WriteLine("Give a number : ");
            int number = int.Parse(Console.ReadLine());
            int count = NumberChecker.GetDigitCount(number);
            Console.WriteLine("Count of digits : "+count);
            int[] digits = NumberChecker.GetDigitsArray(number);
            if (NumberChecker.IsDuckNumber(digits))
            {
                Console.WriteLine("The number is a Duck Number");
            }
            else
            {
                Console.WriteLine("The number is not a Duck Number");
            }
            if(NumberChecker.IsArmstrongNumber(digits,number))
            {
                Console.WriteLine("The number is an Armstrong Number");
            }
            else
            {
                Console.WriteLine("The number is not an Armstrong Number");
            }
            NumberChecker.LargestAndSecondLargest(digits);
            NumberChecker.LargestAndSecondSmallest(digits);
        }
    }
}
