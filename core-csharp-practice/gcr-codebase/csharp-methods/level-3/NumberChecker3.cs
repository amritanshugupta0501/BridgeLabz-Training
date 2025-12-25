using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level3
{
    internal class NumberChecker3
    {
        public static int GetDigitCount(int number)
        {
            return number.ToString().Length;
        }

        public static int[] GetDigitsArray(int number)
        {
            string numStr = number.ToString();
            int[] digits = new int[numStr.Length];

            for (int i = 0; i < numStr.Length; i++)
            {
                digits[i] = (int)Char.GetNumericValue(numStr[i]);
            }
            return digits;
        }

        public static int[] ReverseArray(int[] digits)
        {
            int[] reversed = new int[digits.Length];
            int j = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                reversed[j] = digits[i];
                j++;
            }
            return reversed;
        }

        public static bool CompareArrays(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPalindrome(int[] digits)
        {
            int[] reversedDigits = ReverseArray(digits);
            return CompareArrays(digits, reversedDigits);
        }

        public static bool IsDuckNumber(int[] digits)
        {
            foreach (int digit in digits)
            {
                if (digit == 0)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int count = GetDigitCount(number);
            int[] digits = GetDigitsArray(number);

            Console.WriteLine($"Count of digits: {count}");
            Console.WriteLine("Original Digits: " + string.Join(", ", digits));

            int[] reversedDigits = ReverseArray(digits);
            Console.WriteLine("Reversed Digits: " + string.Join(", ", reversedDigits));

            bool isPalindrome = IsPalindrome(digits);
            if (isPalindrome)
                Console.WriteLine("Is Palindrome: True");
            else
                Console.WriteLine("Is Palindrome: False");

            bool isDuck = IsDuckNumber(digits);
            if (isDuck)
                Console.WriteLine("Is Duck Number: True");
            else
                Console.WriteLine("Is Duck Number: False");

            Console.ReadLine();
        }
    }
}
