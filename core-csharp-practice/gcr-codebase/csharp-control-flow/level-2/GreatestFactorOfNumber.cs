using System;
// Find the greatest factor of a number
class GreatestFactorOfNumber
{
	static void Main()
	{
		Console.WriteLine("Give any number : ");						// Input a number from the user
		int num = int.Parse(Console.ReadLine());
		for(int loop = num-1 ; loop > 0 ; loop--)						// Initiate a backward loop 
		{
			if(num % loop == 0)								// Condition to find the greatest factor
			{
				Console.WriteLine("The greatest factor of the number "+num+" : "+loop);
				break;
			}
		}
	}
}