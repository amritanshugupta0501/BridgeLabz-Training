using System;
// Conversion of distance from kilometres to miles
class DistanceConversionToMiles
{
	static void Main()
	{
		Console.WriteLine("Give the distance (kilometres) : ");			// Input distance in kilometres from the user
		double distance = double.Parse(Console.ReadLine());
		double distance_In_Miles = distance * 1.6;				// 1 mil = 1.6 kms
		Console.WriteLine("The total miles is "+distance_In_Miles+" miles for the given "+distance+" km");
	}
}
