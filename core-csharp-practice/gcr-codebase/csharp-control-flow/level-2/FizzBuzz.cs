using System;
// Displaying FizzBuzz Concept
class FizzBuzz
{
	static void Main()
	{
		Console.WriteLine("Give a number :");					// Input a number from the user
		int num = int.Parse(Console.ReadLine());
		if(num > 0)								// Check if the number is positive number or not
		{
			for(int loop = 0 ; loop <= num ; loop++)			// Initiate a loop to run the FizzBuzz Concept
			{
				if(loop % 3 == 0 && loop % 5 == 0)			// Multiples of 3 and 5, print "FizzBuzz"
				{
					Console.WriteLine("FizzBuzz");
				}
				else if(loop % 3 == 0)					// Multiples of 3, print "Fizz"
				{
					Console.WriteLine("Fizz");
				}
				else if(loop % 5 == 0)					// Multiples of 5, print "Buzz"
				{
					Console.WriteLine("Buzz");
				}
				else
				{
					Console.WriteLine(loop);
				}
			}
		}
		else
		{
			Console.WriteLine("The number "+num+" is a not a positive number.");
		}
	}
}