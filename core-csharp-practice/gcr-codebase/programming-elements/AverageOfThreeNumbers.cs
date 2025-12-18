using System;

class AverageOfThreeNumbers
{
	static void Main()
	{
		int num1,num2,num3;
		Console.WriteLine("Give Three numbers : ");
		num1=int.Parse(Console.ReadLine());
		num2=int.Parse(Console.ReadLine());
		num3=int.Parse(Console.ReadLine());
		double avg=(num1+num2+num3)/3;
		Console.WriteLine("Average of the three inputted numbers :  "+avg);
	}
}