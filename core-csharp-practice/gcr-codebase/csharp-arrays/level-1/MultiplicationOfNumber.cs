using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

// Display multiplication table of a number from 6 to 9
    internal class MultiplicationOfNumber
    {
        static void Main()
        {
            Console.WriteLine("Give a number : ");						// Input a number from the user
            int number = int.Parse(Console.ReadLine());
            int[] multiplication = new int[4];
            int position = 0;
            for (int loop = 6; loop < 10; loop++)						// Initiate a loop to compute the product of the number
            {
                multiplication[position] = number * loop;
                position++;
            }
            position = 0;
            for (int loop = 6; loop < 10; loop++)						// Initialize a loop to display the result of multiplication 
            {
                Console.WriteLine(number + " * " + loop + " = " + multiplication[position]);
                position++;
            }
        }
    }

