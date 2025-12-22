using System;
// Calculate the factorial of a given number
class FactorialOfANumber
{
	static void Main()
	{
		Console.WriteLine("Give any number : ");					// Input a number from the user
		int num = int.Parse(Console.ReadLine());
		int factorial = 1;
		if(num > 0)									// Check if the number is positive or not
		{
			for(int loop = 1 ; loop <= num ; loop++)				// Initiate a loop to calculate the factorial of the number 
			{
				factorial *= loop;
			}
			Console.WriteLine("Factorial of the number "+num+" is "+factorial);
		}
		else
		{
			Console.WriteLine("The number "+num+" is not a positive number");
		}
	}
}