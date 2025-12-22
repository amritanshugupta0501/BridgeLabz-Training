using System;
// Designing a calculator to perform basic arithematic operations
class Calculator
{
	static void Main()
	{
		Console.WriteLine("Give any two numbers : ");			// Input any two numbers from the user
		double first = double.Parse(Console.ReadLine());
		double second = double.Parse(Console.ReadLine());
		Console.WriteLine("Give the operation u want to perform : ");	// Input operator from the user
		String operation = Console.ReadLine();
		switch(operation)						// Using Switch case to perform arithematic operations
		{
			case "+":
				Console.WriteLine(first+" + "+second+" = "+(first+second));
				break;
			case "-":
				Console.WriteLine(first+" - "+second+" = "+(first-second));
				break;
			case "*":
				Console.WriteLine(first+" * "+second+" = "+(first*second));
				break;
			case "/":
				Console.WriteLine(first+" / "+second+" = "+(first/second));
				break;
			default:
				Console.WriteLine("Invalid Operator");
				break;
		}
	}
}