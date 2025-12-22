using System;
// Compute a program to find sum of 'n' natural numbers
class SumOfNaturalNumbers
{
	static void Main()
	{
		Console.WriteLine("Give any number : ");					// Input a number from the user
		int num = int.Parse(Console.ReadLine());
		int sumFormula = (num*(num+1))/2;						// Sum of natural number using formula n*(n+1)/2
		int sumLoop = 0;
		if(num > 0)									// Check if the number is natural or not
		{
			while(num > 0)								// Loop to calculate sum of n natural numbers
			{
				sumLoop += num;
				num--;
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