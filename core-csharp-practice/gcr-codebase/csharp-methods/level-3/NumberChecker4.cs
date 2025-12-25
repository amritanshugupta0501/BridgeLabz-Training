using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level3
{
    internal class NumberChecker4
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static bool IsNeon(int number)
        {
            int square = number * number;
            int sum = 0;
            while (square > 0)
            {
                sum += square % 10;
                square /= 10;
            }
            return sum == number;
        }

        public static bool IsSpy(int number)
        {
            int sum = 0;
            int product = 1;
            int temp = number;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += digit;
                product *= digit;
                temp /= 10;
            }
            return sum == product;
        }

        public static bool IsAutomorphic(int number)
        {
            string numStr = number.ToString();
            string squareStr = (number * number).ToString();
            return squareStr.EndsWith(numStr);
        }

        public static bool IsBuzz(int number)
        {
            return (number % 7 == 0 || number % 10 == 7);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = NumberChecker4.IsPrime(number);
            Console.WriteLine($"Is Prime Number: {isPrime}");

            bool isNeon = NumberChecker4.IsNeon(number);
            Console.WriteLine($"Is Neon Number: {isNeon}");

            bool isSpy = NumberChecker4.IsSpy(number);
            Console.WriteLine($"Is Spy Number: {isSpy}");

            bool isAutomorphic = NumberChecker4.IsAutomorphic(number);
            Console.WriteLine($"Is Automorphic Number: {isAutomorphic}");

            bool isBuzz = NumberChecker4.IsBuzz(number);
            Console.WriteLine($"Is Buzz Number: {isBuzz}");

            Console.ReadLine();
        }
    }
}
