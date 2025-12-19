using System;
// Conversion of distance from feet to yards and miles
class DistanceInYardsMiles
{
	static void Main()
	{
		Console.WriteLine("Give the distance in feet : ");			// Distance in feet from user
		double distance_In_Feet = double.Parse(Console.ReadLine());
		double distance_In_Yards = distance_In_Feet / 3;			// 1 yard = 3 feet
		double distance_In_Miles = distance_In_Yards / 1760;			// 1 mile = 1760 yards
		Console.WriteLine("Distance in yards : "+distance_In_Yards+" and Distance in miles : "+distance_In_Miles);
	}
}