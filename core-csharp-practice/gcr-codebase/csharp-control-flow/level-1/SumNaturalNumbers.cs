using System;

class SumNaturalNumbers
{
	static void Main()
	{
		Console.WriteLine("Give any number to find sum of numbers : ");				// Input a number from the user
		int num = int.Parse(Console.ReadLine());
		int sumFormula = (num*(num+1))/2;							// Sum of natural numbers using formula n*(n+1)/2
		int sumLoop = 0;
		if(num > 0)										// Check if the number is natural number or not
		{
			for(int loop = 1; loop<=num ; loop++)						// Using for loop to compute sum of natural numbers
			{
				sumLoop += loop;
			}
			if(sumLoop == sumFormula)
			{
				Console.WriteLine("Result is same from the loop and the formula.");
				Console.WriteLine("The result of sum of numbers : "+sumLoop);
			}
			else
			{
				Console.WriteLine("Result is not same from the loop and the formula.");
			}
		}
		else
		{
			Console.WriteLine("The number "+num+" is not a natural number.");
		}
	}
}