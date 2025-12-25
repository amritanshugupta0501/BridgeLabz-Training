using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class FactorsOfANumber
    {
        int[] FactorsDisplay(int number)
        {
            int[] factor = new int[(number / 2)+1];
            int position = 0;
            Console.WriteLine("Factors of the number "+ number +" : ");
            for(int loop = 1; loop <= number/2; loop++)
            {
                if (number % loop == 0)
                {
                    Console.WriteLine(loop);
                    factor[position] = loop;
                    position++;
                }
            }
            Console.WriteLine(number);
            factor[position] = number;
            return factor;
        }
        int SumOfFactors(int[] factors)
        {
            int sum = 0;
            for (int loop = 0; loop < factors.Length; loop++)
            {
                sum += factors[loop]; 
            }
            return sum;
        }
        int SquareSumOfFactors(int[] factors)
        {
            int sum = 0;
            for(int loop = 0; loop < factors.Length; loop++)
            {
                sum += (factors[loop] * factors[loop]); 
            }
            return sum;
        }
        int ProductOfFactors(int[] factors)
        {
            int product = 1;
            for (int loop = 0;loop < factors.Length; loop++)
            {
                product *= factors[loop];
            }
            return product;
        }
        static void Main()
        {
            Console.WriteLine("Give a number to find its factors : ");
            int number = int.Parse(Console.ReadLine());

            FactorsOfANumber factors = new FactorsOfANumber();
            int[] factorsOfTheNumber = factors.FactorsDisplay(number);
            
            int sumOfFactors = factors.SumOfFactors(factorsOfTheNumber);
            Console.WriteLine("Sum of all the factors of the number "+ number +" : "+sumOfFactors);
            
            int squareSumOfFactors = factors.SquareSumOfFactors(factorsOfTheNumber);
            Console.WriteLine("Sum of square of all the factors of the number " + number + " : " + squareSumOfFactors);
            
            int productOfFactors = factors.ProductOfFactors(factorsOfTheNumber);
            Console.WriteLine("Product of all the factors of the number "+ number +" : "+ productOfFactors);
        }
    }
}
