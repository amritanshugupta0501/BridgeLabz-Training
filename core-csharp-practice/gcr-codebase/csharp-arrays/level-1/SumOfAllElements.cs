using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Calculate sum of all the elements of an array
    internal class SumOfAllElements
    {
        static void Main() 
        {
            int[] numbers = new int[10];
            int position = 0;
            int sum = 0;
            while (true)									// Initiate a loop to enter elements in an array
            {
                Console.WriteLine("Give a number : ");
                numbers[position] = int.Parse(Console.ReadLine());
                sum += numbers[position];
                if (numbers[position] <= 0)							// Check if the entered element is 0 or not
                {
                    break;
                }
                position++;
                if (position == numbers.Length)							// Check if the array has maximum elements or not
                {
                    break;
                }  
            }
            Console.WriteLine("Numbers in the  list : ");
            for (int loop = 0; loop < position; loop++)						// Initiate a loop to display elements and sum of elements
            {
                Console.WriteLine(numbers[loop]);
            }
            Console.WriteLine("Total Sum of the numbers : "+sum);
        }
    }

