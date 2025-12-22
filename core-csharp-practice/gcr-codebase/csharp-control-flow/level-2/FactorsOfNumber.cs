using System;
// Compute factors of a given number
class FactorsOfNumber
{
	static void Main()
	{
		Console.WriteLine("Give any number : ");					// Input a number from the user
		int num = int.Parse(Console.ReadLine());
		Console.WriteLine("All the factors of number "+num+" : ");			
		for(int loop = 1 ; loop <= num/2 ; loop++)					// Initiate a loop to check the factors of the number
		{
			if(num % loop == 0)							// Condition to check if the number is divisible or not
			{
				Console.WriteLine(loop);
			}
		}
	}
}