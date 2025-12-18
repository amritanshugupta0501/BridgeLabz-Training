using System;

class KilometresToMiles
{
	static void Main()
	{
		Console.WriteLine("Give the distance in kilometres : ");
		double kilometre=double.Parse(Console.ReadLine());
		double miles=kilometre*0.621371;
		Console.WriteLine("Distance in miles :  "+miles);
	}
}