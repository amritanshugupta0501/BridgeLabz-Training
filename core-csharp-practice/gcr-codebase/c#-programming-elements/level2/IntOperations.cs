using System;
// Perform some Int Operations on three operands
class IntOperations
{
	static void Main()
	{
		Console.WriteLine("Give any three numbers : ");			// Input three numbers from the user
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		int num3 = int.Parse(Console.ReadLine());
		int result_Of_Operation1 = num1 + num2 * num3;			// Operation 1 : a+b*c
		int result_Of_Operation2 = num1 * num2 + num3;			// Operation 2 : a*b+c
		int result_Of_Operation3 = num3 + num1 / num2;			// Operation 3 : c+a/b
		int result_Of_Operation4 = num1 % num2 + num3;			// Operation 4 : a%b+c
		Console.WriteLine("The results of Int Operations are "+result_Of_Operation1+", "+result_Of_Operation2+", "+result_Of_Operation3+", "+result_Of_Operation4);
	}
}