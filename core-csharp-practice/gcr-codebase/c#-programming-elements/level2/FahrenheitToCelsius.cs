using System;
// Temperature Conversion from Fahrenheit to Celsius
class FahrenheitToCelsius
{
	static void Main()
	{
		Console.WriteLine("Give the temperature in Fahrenheit : ");		// Input temperature in Fahrenheit from user
		double temp_In_Fahrenheit = double.Parse(Console.ReadLine());
		double temp_In_Celsius = ((temp_In_Fahrenheit-32)*5)/9;			// (F − 32) x 5/9 = C
		Console.WriteLine("The "+temp_In_Fahrenheit+" Fahrenheit is "+temp_In_Celsius+" Celsius");
	}
}