using System;
// Conversion of pre-defined kilometres to miles
class KilometresToMiles
{
	static void Main()
	{
		double distance_In_Kilometres = 10.8;			
		double distance_In_Miles = 10.8 / 1.6;				// 1 kilometer = 1.6 miles
		Console.WriteLine("The distance "+distance_In_Kilometres+" km in miles is "+distance_In_Miles);
	}
}