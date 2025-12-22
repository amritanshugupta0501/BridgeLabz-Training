using System;
// Check whether a number is positive, negative or zero
class PositiveNegative
{
	static void Main()
	{
		Console.WriteLine("Give any number : ");				// Input a number from the user
		int num = int.Parse(Console.ReadLine());
		if(num > 0)								// Check if number is greater than zero
		{
			Console.WriteLine("The number "+num+" is positive.");
		}
		else if(num == 0)							// Check if number is equal to zero
		{
			Console.WriteLine("The number "+num+" is zero.");
		}
		else									// Check if number is less than zero
		{
			Console.WriteLine("The number "+num+" is negative.");
		}
	}
}