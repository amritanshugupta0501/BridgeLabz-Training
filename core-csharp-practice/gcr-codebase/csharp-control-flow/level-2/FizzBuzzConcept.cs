using System;
// Implementing the FizzBuzz Concept
class FizzBuzzConcept
{
	static void Main()
	{
		Console.WriteLine("Give a number :");					// Input a number from the user
		int num = int.Parse(Console.ReadLine());
		if(num > 0)								// Check if the number is positive number or not
		{
			int loop = 0;							// Initialize a while loop to run the counter
			while(loop <= num)
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
				loop--;
			}
		}
		else
		{
			Console.WriteLine("The number "+num+" is a not a positive number.");
		}
	}
}