using System;
// Perform some Double Operations on three operands
class DoubleOperations
{
	static void Main()
	{
		Console.WriteLine("Give any three numbers : ");			// Input three numbers from the user
		double num1 = double.Parse(Console.ReadLine());
		double num2 = double.Parse(Console.ReadLine());
		double num3 = double.Parse(Console.ReadLine());
		double result_Of_Operation1 = num1 + num2 * num3;			// Operation 1 : a+b*c
		double result_Of_Operation2 = num1 * num2 + num3;			// Operation 2 : a*b+c
		double result_Of_Operation3 = num3 + num1 / num2;			// Operation 3 : c+a/b
		double result_Of_Operation4 = num1 % num2 + num3;			// Operation 4 : a%b+c
		Console.WriteLine("The results of Int Operations are "+result_Of_Operation1+", "+result_Of_Operation2+", "+result_Of_Operation3+", "+result_Of_Operation4);
	}
}
