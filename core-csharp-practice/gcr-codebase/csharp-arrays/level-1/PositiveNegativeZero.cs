using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Determine whether the elements of an array are positive , negative or zero.
    internal class PositiveNegativeZero
    {
        static void Main()
        {
            int[] numbers = new int[5];
            for (int loop = 0; loop < numbers.Length; loop++)					// Initiate a loop to enter elements in an array
            {
                Console.WriteLine("Give any number : ");
                numbers[loop] = int.Parse(Console.ReadLine());
            }
            for (int loop = 0; loop < numbers.Length; loop++)					// Initiate a loop to check if the number is :
            {
                if (numbers[loop] == 0)								// Check if the element is Zero
                {
                    Console.WriteLine("The number " + numbers[loop] + " is Zero.");		
                }
                else if (numbers[loop] >= 1)							// Check if the element is Positive Integer
                {
                    Console.WriteLine("The number " + numbers[loop] + " is a positive integer");
                }
                else										// Check if the element is Negative Integer 
                {
                    Console.WriteLine("The number " + numbers[loop] + " is a negative integer");
                }
            }
        }
    }

