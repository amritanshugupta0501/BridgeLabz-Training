using System;
// Checking the largest number among three numbers
class LargestNumbers
{
	static void Main()
	{
		Console.WriteLine("Give any three numbers to check the largest number : ");			// Input 3 numbers from the user
		int number1 = int.Parse(Console.ReadLine());
		int number2 = int.Parse(Console.ReadLine());
		int number3 = int.Parse(Console.ReadLine());
		bool resultNumber1 = false;
		bool resultNumber2 = false;
		bool resultNumber3 = false;
		if(number1 > number2)										// Check the largest number using if-else
		{
			if(number1 > number3)
			{
				resultNumber1 = true;
			}
			else 
			{
				resultNumber3 = true;
			}
		}
		else if(number2 > number3)
		{
			resultNumber2 = true;
		}
		else
		{
			resultNumber3 = true;
		}
		Console.WriteLine("Is the first number the largest? "+resultNumber1+"\nIs the second number the largest? "+resultNumber2+"\nIs the third number the largest? "+resultNumber3);
	}
}