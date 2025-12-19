using System;
// Swapping two numbers without using third variable
class SwappingTwoNumbers
{
	static void Main()
	{
		Console.WriteLine("Give any two numbers : "); 				// Input any two numbers from the user
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		Console.WriteLine("Original Numbers : ");				// Printing the original numbers
		Console.WriteLine("Number 1 : "+num1+"\nNumber2 : "+num2);
		
		num1 += num2;								// Swapping numbers without third variable
		num2=num1 - num2;
		num1=num1 - num2;
		Console.WriteLine("Swapped Numbers : ");				// Printing the Swapped numbers
		Console.WriteLine("Number 1 : "+num1+"\nNumber2 : "+num2);
	}
}