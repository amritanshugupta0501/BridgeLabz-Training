using System;
// Print odd and even numbers in a given range
class OddEvenNumbers
{
	static void Main()
	{
		Console.WriteLine("Give any number for the range : ");				// Input any number from the user
		int ending = int.Parse(Console.ReadLine());
		Console.WriteLine("List of even number from the range 1 to "+ending+" : ");
		for(int loop = 1 ; loop <= ending ; loop++)					// Initiate a loop to print the list of even numbers
		{
			if(loop % 2 == 0)							// Condition to check even numbers from the range
			{
				Console.WriteLine(loop);
			}
		}
		Console.WriteLine("List of odd number from the range 1 to "+ending+" : ");
		for(int loop = 1 ; loop <= ending ; loop++)					// Initiate a loop to print the list of odd numbers
		{
			if(loop % 2 == 1)							// Condition to check odd numbers from the range
			{
				Console.WriteLine(loop);
			}
		}
	}
}