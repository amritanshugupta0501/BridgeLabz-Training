using System;
// Check for a natural number and print sum of natural numbers
class NaturalNumbers
{
	static void Main()
	{
		Console.WriteLine("Give any number : ");				// Input a number from the user
		int num = int.Parse(Console.ReadLine());
		if(num > 0)								// Check if a number is positive or not
		{
			int sum = (num * (num + 1))/2;					// Compute the sum of numbers for positive integer
			Console.WriteLine("The sum of "+num+" natural numbers is "+sum);
		}
		else
		{
			Console.WriteLine("The number "+num+" is not a natural number");
		}
	}
}