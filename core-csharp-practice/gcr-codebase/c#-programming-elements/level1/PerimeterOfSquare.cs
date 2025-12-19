using System;
// Compute sides of a square from its perimeter
class PerimeterOfSquare
{
	static void Main()
	{
		Console.WriteLine("Give the perimeter of the square : ");	// Input perimeter of the square from user
		double perimeter = double.Parse(Console.ReadLine());
		double side_Of_The_Square = perimeter / 4;			// Perimeter of square = 4 * its side
		Console.WriteLine("The length of the side is "+side_Of_The_Square+" whose perimeter is "+perimeter);
	}
}