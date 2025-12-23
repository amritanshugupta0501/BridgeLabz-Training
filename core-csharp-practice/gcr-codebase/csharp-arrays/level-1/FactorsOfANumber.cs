using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Display the factors of a given number
    internal class FactorsOfANumber
    {
        static void Main()
        {
            Console.WriteLine("Give a number : ");					// Input a number from the user
            int number = int.Parse(Console.ReadLine());
            int[] numberFactors = new int[number / 2];
            int position = 0;
            for (int loop = 1; loop < number / 2; loop++)				// Initialize a loop to store factors of the number
            {
                if (number % loop == 0)							// Check if the number is divisible or not
                {
                    numberFactors[position] = loop;
                    position++;
                }
            }
            Console.WriteLine("Factors of the  number " + number + " : ");		
            for (int loop = 0; loop < position; loop++)					// Initialize a loop to display the factors array
            {
                Console.WriteLine(numberFactors[loop]);
            }
            Console.WriteLine(number);
        }
    }

