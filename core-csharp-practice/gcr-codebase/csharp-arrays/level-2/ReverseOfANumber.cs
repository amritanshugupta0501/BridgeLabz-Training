using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Reverse a number given by the user
internal class ReverseOfANumber
    {
        static void Main()
        {
            Console.WriteLine("Give a number to reverse : ");						// Input a number from the user
            int number = int.Parse(Console.ReadLine());
            int[] digits = new int[20];
            int position = 0;
            int loop = number;										// Initiate a loop to extract digits
            while(loop > 0)
            {
                digits[position] = loop % 10;
                loop /= 10;
                position++;
            }
            Console.WriteLine("Original Number : "+number);
            Console.Write("Reversed Number : ");
            for(loop = 0; loop < position; loop++)							// Initiate a loop to display the digits in reverse order 
            {
                Console.Write(digits[loop]);
            }
      	}
    }

