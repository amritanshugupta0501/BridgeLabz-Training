using System;

class CelciusToFahrenheit
{
	static void Main()
	{
		Console.WriteLine("Give the Temperature in Celsius : ");
		double celsius=double.Parse(Console.ReadLine());
		double fahrenheit=(celcius * 9/5)+32;
		Console.WriteLine("Temperature in Fahrenheit is : "+fahrenheit);
	}
}