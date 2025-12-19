using System;
// Compute quotient and remainder of two numbers
class QuotientRemainder
{
	static void Main()
	{
		Console.WriteLine("Give any two numbers : ");				// Input any two numbers from the user
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		int quotient = num2 / num1;						// Quotient = number2 / number1
		int remainder = num2 % num1;						// Remainder = number2 % number1
		Console.WriteLine("The Quotient is "+quotient+" and Remainder is "+remainder+" of the two numbers "+num1+" and "+num2);
	}
}