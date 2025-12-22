using System;
// Check a number's divisibility by 5
class DivisibilityBy5
{
	static void Main()
	{
		Console.WriteLine("Give any number to check divisibility : ");			// Input a number from the user
		int num = int.Parse(Console.ReadLine());
		bool result = (num%5==0)?true:false;						// Checking if the number is divisible by 5
		Console.WriteLine("Is the number "+num+" divisible by 5 ? "+result);
	}
}