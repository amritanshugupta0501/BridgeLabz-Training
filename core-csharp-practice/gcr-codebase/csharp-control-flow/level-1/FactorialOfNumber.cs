using System;
// Compute Factorial of given number
class FactorialOfNumber
{
	static void Main()
	{
		Console.WriteLine("Give any number : ");							// Input a number from the user
		int num = int.Parse(Console.ReadLine());
		int factorial = 1;
		if(num > 0)											// Check if the number is positive or not
		{
			Console.Write("Factorial of the number "+num);
			while(num > 1)										// Initiate a loop to find factorial of number
			{
				factorial *= num;
				num--;
			}
			Console.WriteLine(" is "+factorial);
		}
		else
		{
			Console.WriteLine("The number "+num+" is not a positive number.");
		}
	}
}