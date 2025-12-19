using System;
// Convert height from centrimetres to feet and inches
class HeightToFeetAndInches
{
	static void Main()
	{
		Console.WriteLine("Give the height in Centimetres : ");			// Input height from user in centimetres
		double height = double.Parse(Console.ReadLine());
		double height_In_Inches = height*2.54;					// 1 inch = 2.54 centimetres
		double height_In_Foot = height_In_Inches*12;				// 1 foot = 12 inches
		Console.WriteLine("Your height in cm is "+height+" while in feet is "+height_In_Foot+" and inches is "+height_In_Inches);
	}
}