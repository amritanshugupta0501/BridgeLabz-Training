using System;
// Check all the multiples of a number under 100
class MultiplesOfNumber
{
	static void Main()
	{
		Console.WriteLine("Give any number : ");					// Input a number from the user
		int num = int.Parse(Console.ReadLine());
		Console.WriteLine("All the multiples of the number "+num+" under 100 : ");	
		for(int loop = 100 ; loop >= 1 ; loop--)					// Initiate a backward loop from 100 to 1 
		{
			if(loop % num == 0)							// Condition to find multiples of the number
			{
				Console.WriteLine(loop);
			}
			if(loop <= (num * 2))							// Condition to break the loop
			{
				break;
			}
		}
	}
}