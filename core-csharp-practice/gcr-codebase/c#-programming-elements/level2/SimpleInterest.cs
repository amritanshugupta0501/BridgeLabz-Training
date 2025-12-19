using System;
// Compute simple interest using principal amount, rate and time period
class SimpleInterest
{
	static void Main()
	{
		Console.WriteLine("Give principal amount, rate of interest and time period : ");	// Input Principal Amount, rate and time period
		double principal_Amount = double.Parse(Console.ReadLine());
		double rate_Of_Interest = double.Parse(Console.ReadLine());
		double time_Period = double.Parse(Console.ReadLine());
		double simple_Interest = (principal_Amount * rate_Of_Interest * time_Period)/100;	// S.I. = (P*R*T)/100
		Console.WriteLine("The Simple Interest is "+simple_Interest+" for Principal "+principal_Amount+", Rate of Interest "+rate_Of_Interest+"and Time Period "+time_Period);
	}
}