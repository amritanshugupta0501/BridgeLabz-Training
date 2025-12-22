using System;
// Compute the sum of integers given by the user
class SumOfIntegers
{
	static void Main()
	{
		int num = 1, sum = 0;
		while(num!=0)										// Run a loop to check if the number is zero or not
		{
			Console.WriteLine("Give a number to compute the sum : ");			// Input any number from the user
			num = int.Parse(Console.ReadLine());
			sum += num;									// Compute the sum of integers 
		}
		Console.WriteLine("Sum of integers : "+sum);
	}
}