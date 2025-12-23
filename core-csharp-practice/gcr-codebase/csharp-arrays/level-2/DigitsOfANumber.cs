using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Display the largest and second-largest digits of a number
    internal class DigitsOfANumber
    {
        static void Main()
        {
            Console.WriteLine("Give a number : ");					// Input a number from the user
            int number = int.Parse(Console.ReadLine());
            int[] digits = new int[10];
            int position = 0;
            int loop = number;								// Initiate a loop to extract digits in a 1-D array
            while(loop > 0)
            {
                digits[position] = loop % 10;
                position++;
                loop = loop / 10;
            }
            for(loop = 0; loop < position; loop++)					// Initiate a loop to sort the array
            {
                for(int secondLoop = 0; secondLoop < position; secondLoop++)
                {
                    if (digits[loop] > digits[secondLoop])
                    {
                        int duplicate = digits[loop];
                        digits[loop] = digits[secondLoop];
                        digits[secondLoop] = duplicate;
                    }
                }
            }
            Console.WriteLine("Largest digit in the number : " + digits[0]);		// Display the largest digit of the number
            for(loop = 1; loop < position; loop++)					// Initiate a loop to display the second-largest digit of the number
            {
                if(digits[loop] != digits[0])
                {
                    Console.WriteLine("Second-largest digit in the number : " + digits[loop]);
                    break;
                }
            }
        }
    }

