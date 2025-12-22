using System;
// Checking the smallest number among 3 numbers
class SmallestNumber
{
	static void Main()
	{
		Console.WriteLine("Give any 3 numbers : ");				// Input any 3 numbers from the user
		int number1 = int.Parse(Console.ReadLine());
		int number2 = int.Parse(Console.ReadLine());
		int number3 = int.Parse(Console.ReadLine());
		bool result = false;
		if(number1 < number2)							// Checking if number 1 is the smallest or not
		{
			if(number1 < number3)
			{
				result = true;
			}
		}
		Console.WriteLine("Is the first number "+number1+" smallest or not ? "+result);
	}
}