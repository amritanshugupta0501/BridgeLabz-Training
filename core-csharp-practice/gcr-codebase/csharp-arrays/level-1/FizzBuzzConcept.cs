using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Display the Concept of FizzBuzz within a given range
 internal class FizzBuzzConcept
    {
        static void Main()
        {
            Console.WriteLine("Give a number for the range : ");			// Input a range from the user
            int range = int.Parse(Console.ReadLine());
            string[] arr = new string[range];
            for (int loop = 1; loop <= range; loop++)					// Initialize a loop to visualize the concept within a range
            {
                if (loop % 3 == 0 && loop % 5 == 0)					// Multiples of 3 and 5, print "FizzBuzz"
                {
                    arr[loop - 1] = "FizzBuzz";
                }
                else if (loop % 3 == 0)							// Multiples of 3, print "Fizz"
                {
                    arr[loop - 1] = "Fizz";
                }
                else if (loop % 5 == 0)							// Multiples of 5, print "Buzz"
                {
                    arr[loop - 1] = "Buzz";
                }
                else
                {
                    arr[loop - 1] = loop.ToString();
                }
            }
            Console.WriteLine("Final Result : ");
            for (int loop = 0; loop < range; loop++)					// Initialize a loop to display the result array
            {
                Console.WriteLine(arr[loop]);
            }
        }
    }

