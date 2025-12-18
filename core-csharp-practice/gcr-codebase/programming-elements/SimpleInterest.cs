using System;

class SimpleInterest
{
	static void Main()
	{
		Console.WriteLine("Give Rate, Time and Principle amount : ");
		double rate = double.Parse(Console.ReadLine());
		double time = double.Parse(Console.ReadLine());
		double principle = int.Parse(Console.ReadLine());
		double simpleinterest = (principle * rate * time)/100;
		Console.WriteLine("Simple Interest on the amount : "+simpleinterest);
	}
}