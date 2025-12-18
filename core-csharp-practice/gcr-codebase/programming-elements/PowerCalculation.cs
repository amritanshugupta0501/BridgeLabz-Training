using System;

class PowerCalculation
{
	static void Main()
	{
		int base , exponent;
		Console.WriteLine("Give the base and exponent : ");
		base=int.Parse(Console.ReadLine());
		exponent=int.Parse(Console.ReadLine());
		double result = Math.Pow(base,exponent);
		Console.WriteLine("The Result is : "+result);
	}
}