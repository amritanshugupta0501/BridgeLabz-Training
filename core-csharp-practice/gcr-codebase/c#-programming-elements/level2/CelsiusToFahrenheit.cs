using System;
// Conversion of temperature from Celsius to Fahrenheit
class CelsiusToFahrenheit
{
	static void Main()
	{
		Console.WriteLine("Give the temperature in Celsius : ");		// Input temperature in Celsius from user
		double temp_In_Celsius = double.Parse(Console.ReadLine());
		double temp_In_Fahrenheit = ((temp_In_Celsius*9)/5)+32;			// (C × 9/5) + 32 = F
		Console.WriteLine("The "+temp_In_Celsius+" Celsius is "+temp_In_Fahrenheit+" Fahrenheit");
	}
}