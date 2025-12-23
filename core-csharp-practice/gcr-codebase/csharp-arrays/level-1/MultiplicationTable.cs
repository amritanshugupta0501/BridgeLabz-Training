using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Display multiplication table of a number
    internal class MultiplicationTable
    {
        static void Main()
        {
            Console.WriteLine("Give a number : ");							// Input a number from the user
            int number = int.Parse(Console.ReadLine());
            int[] multiplicationTable = new int[10];
            for (int loop = 1; loop <= multiplicationTable.Length; loop++)				// Initiate a loop to calculate product of the number
            {
                multiplicationTable[loop - 1] = number * loop;
            }
            for (int loop = 1; loop <= multiplicationTable.Length; loop++)				// Initiate a loop to display multiplication table
            {
                Console.WriteLine(number + " * " + loop + " = " + multiplicationTable[loop - 1]);
            }
        }
    }

