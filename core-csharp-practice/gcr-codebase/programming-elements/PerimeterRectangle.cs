using System;

class PerimeterRectangle
{
	static void Main()
	{
		int length , breadth;
		Console.WriteLine("Give Two sides of the rectangle : ");
		length=int.Parse(Console.ReadLine());
		breadth=int.Parse(Console.ReadLine());
		int perimeter = 2*(length+breadth);
		Console.WriteLine(perimeter);
	}
}