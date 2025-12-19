using System;
// Calculate the volume of earth in miles and kilometres
class VolumeOfEarth
{
	static void Main()
	{
		int earth_Radius = 6378;
		double earth_Volume_In_Kilometres = (Math.PI*4*earth_Radius*earth_Radius*earth_Radius)/3;	// Volume of sphere= (4/3) * pi * r^3 
		double earth_Radius_In_Miles = earth_Radius / 1.6;						// 1 km = 1.6 mil
		double earth_Volume_In_Miles = (Math.PI*4*earth_Radius_In_Miles*earth_Radius_In_Miles*earth_Radius_In_Miles)/3;
		Console.WriteLine("The Volume of earth in cubic-kilometres is "+earth_Volume_In_Kilometres+" and cubic miles is "+earth_Volume_In_Miles);
	}
}