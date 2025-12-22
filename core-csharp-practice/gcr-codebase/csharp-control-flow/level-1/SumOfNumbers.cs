using System;
// Compute sum of numbers until zero is entered by the user
class SumOfNumbers
{
	static void Main()
	{
		int sum=0;
		while(true)									// Initiate the loop to enter numbers and compute the sum
		{
			Console.WriteLine("Give any number : ");				// Input a number from the user
			int number = int.Parse(Console.ReadLine());
			if(number == 0)								// Check if the number is zero				
			{
				break;
			}
			else
			{
				sum += number;
			}
		}
		Console.WriteLine("Sum of the numbers : "+sum);
	}
}