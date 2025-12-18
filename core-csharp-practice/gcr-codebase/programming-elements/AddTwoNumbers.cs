using System;

class AddTwoNumbers
{
	static void Main()
	{
		int num1 , num2;
		Console.WriteLine("Give Two numbers : ");
		num1=int.Parse(Console.ReadLine());
		num2=int.Parse(Console.ReadLine());
		int sum = num1 + num2;
		Console.WriteLine("Sum of the two numbers = " + sum);
	}
}
