using System;
// Conversion of weight in pounds to kilograms
class WeightConversion
{
	static void Main()
	{
		Console.WriteLine("Give weight in pounds : ");		// Input weight in pounds from user
		double weight_In_Pounds = double.Parse(Console.ReadLine());
		double weight_In_Kilograms = weight_In_Pounds/2.2;	// 1 pound = 2.2 kilograms
		Console.WriteLine("The weight of the person in pounds is "+weight_In_Pounds+" and in kg is "+weight_In_Kilograms);
	}
}