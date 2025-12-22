using System;
// Check if the number is a Abundant Number or not
// Abundant number : an integer in which the sum of all the divisors of the number is greater than the number itself
class AbundantNumber
{
	static void Main()
	{
		Console.WriteLine("Give a number : ");					// Input a number from the user
		int num = int.Parse(Console.ReadLine());
		int sum = 0;
		for(int loop = 1 ; loop <= num/2 ; loop++)				// Initialize a loop to find factors of the number
		{
			if(num % loop == 0)						// Check if a number is divisor of the number
			{
				sum += loop;
			}
		}
		if(sum > num)								// Check whether the sum is greater than the number
		{
			Console.WriteLine("The number "+num+" is an Abundant Number.");
		}
		else
		{
			Console.WriteLine("The number "+num+" is not an Abundant Number.");
		}
	}
}