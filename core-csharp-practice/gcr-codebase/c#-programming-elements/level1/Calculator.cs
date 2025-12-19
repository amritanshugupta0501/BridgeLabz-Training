using System;
// Perform basic arithematic operations on two numbers
class Calculator
{
	static void Main()
	{
		Console.WriteLine("Give any two numbers : ");			// Input two nubmers from the user
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		int addition = num1+num2;					// Addition : num1+num2
		int subtraction = num1-num2;					// Subtraction : num1-num2
		int multiplication = num1*num2;					// Multiplication : num1*num2
		double division = (double)num1/num2;				// Division : num1/num2
		Console.WriteLine("The addition, subtraction, multiplication & division value of 2 numbers "+num1+" and "+num2+" is "+addition+","+subtraction+","+multiplication+" and "+division);
	}
}