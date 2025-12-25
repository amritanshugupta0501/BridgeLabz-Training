using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level3
{
    internal class NumberChecker5
    {
        public static int[] GetFactors(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            int[] factors = new int[count];
            int index = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index] = i;
                    index++;
                }
            }
            return factors;
        }

        public static int GetGreatestFactor(int[] factors)
        {
            int max = Int32.MinValue;
            foreach (int factor in factors)
            {
                if (factor > max)
                {
                    max = factor;
                }
            }
            return max;
        }

        public static int GetSumOfFactors(int[] factors)
        {
            int sum = 0;
            foreach (int factor in factors)
            {
                sum += factor;
            }
            return sum;
        }

        public static long GetProductOfFactors(int[] factors)
        {
            long product = 1;
            foreach (int factor in factors)
            {
                product *= factor;
            }
            return product;
        }

        public static double GetProductOfCubeOfFactors(int[] factors)
        {
            double product = 1;
            foreach (int factor in factors)
            {
                product *= Math.Pow(factor, 3);
            }
            return product;
        }

        public static bool IsPerfectNumber(int number, int[] factors)
        {
            int sum = GetSumOfFactors(factors);
            int sumProperDivisors = sum - number;
            return sumProperDivisors == number;
        }

        public static bool IsAbundantNumber(int number, int[] factors)
        {
            int sum = GetSumOfFactors(factors);
            int sumProperDivisors = sum - number;
            return sumProperDivisors > number;
        }

        public static bool IsDeficientNumber(int number, int[] factors)
        {
            int sum = GetSumOfFactors(factors);
            int sumProperDivisors = sum - number;
            return sumProperDivisors < number;
        }

        public static bool IsStrongNumber(int number)
        {
            int sum = 0;
            int temp = number;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += GetFactorial(digit);
                temp /= 10;
            }
            return sum == number;
        }

        private static int GetFactorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int[] factors = NumberChecker5.GetFactors(number);
            Console.WriteLine("Factors: " + string.Join(", ", factors));

            int greatest = NumberChecker5.GetGreatestFactor(factors);
            Console.WriteLine("Greatest Factor: "+greatest);

            int sum = NumberChecker5.GetSumOfFactors(factors);
            Console.WriteLine("Sum of Factors: "+sum);

            long product = NumberChecker5.GetProductOfFactors(factors);
            Console.WriteLine("Product of Factors: "+product);

            double cubeProduct = NumberChecker5.GetProductOfCubeOfFactors(factors);
            Console.WriteLine("Product of Cube of Factors: "+cubeProduct);

            bool isPerfect = NumberChecker5.IsPerfectNumber(number, factors);
            Console.WriteLine("Is Perfect Number: "+isPerfect);

            bool isAbundant = NumberChecker5.IsAbundantNumber(number, factors);
            Console.WriteLine("Is Abundant Number: "+isAbundant);

            bool isDeficient = NumberChecker5.IsDeficientNumber(number, factors);
            Console.WriteLine("Is Deficient Number: "+isDeficient);

            bool isStrong = NumberChecker5.IsStrongNumber(number);
            Console.WriteLine("Is Strong Number: "+isStrong);
        }
    }
}
