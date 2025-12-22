using System;
// Compute the power of a given number
class PowerOfTheNumber
{
	static void Main()
	{
		Console.WriteLine("Give any 2 numbers : ");					// Input any two numbers from the user : base and exponent
		int baseNumber = int.Parse(Console.ReadLine());
		int exponent = int.Parse(Console.ReadLine());
		int result = 1;
		for(int loop = 1 ; loop <= exponent ; loop++)					// Initialize a loop to count the times to multiply
		{
			result *= baseNumber;							// Computing the power of the base to the exponent
		}
		Console.WriteLine(baseNumber+" to the power of "+exponent+" : "+result);
	}
}