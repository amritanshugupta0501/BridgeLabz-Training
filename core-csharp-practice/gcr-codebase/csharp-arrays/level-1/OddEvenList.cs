using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Display the even and odd elements in an array within a range
 internal class OddEvenList
    {
        static void Main()
        {
            Console.WriteLine("Give a number for the range : ");
            int number = int.Parse(Console.ReadLine());						// Input number for the range from the user
            int[] evenNumbers = new int[number / 2];
            int positionEven = 0;
            int[] oddNumbers = new int[number - (number / 2)];
            int positionOdd = 0;
            for (int loop = 1; loop <= number; loop++)						// Initate a loop for a range
            {
                if (loop % 2 == 0)								// Check if the number is even or not
                {
                    evenNumbers[positionEven] = loop;
                    positionEven++;
                }
                else										// Check if the number is odd or not
                {
                    oddNumbers[positionOdd] = loop;
                    positionOdd++;
                }
            }
            Console.WriteLine("List of even numbers from 1 to " + number + " : ");
            for (int loop = 0; loop < evenNumbers.Length; loop++)
            {
                Console.WriteLine(evenNumbers[loop]);
            }
            Console.WriteLine("List of odd numbers from 1 to " + number + " : ");
            for (int loop = 0; loop < oddNumbers.Length; loop++)
            {
                Console.WriteLine(oddNumbers[loop]);
            }
        }
    }

