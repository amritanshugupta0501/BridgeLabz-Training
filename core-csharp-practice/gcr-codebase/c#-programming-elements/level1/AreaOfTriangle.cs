using System;
// Compute area of triangle using its base and height
class AreaOfTriangle
{
	static void Main()
	{
		Console.WriteLine("Give the base and the height of a triangle : ");		// input height and base of a triangle from the user
		double base_Centimetres = double.Parse(Console.ReadLine());
		double height = double.Parse(Console.ReadLine());
		double area_Of_Triangle = (base_Centimetres*height)/2;				// area of triangle = (1/2)*base*height
		double area_Of_Triangle_In_Inches = area_Of_Triangle/(2.54*2.54);		// 1 inch = 2.54 centimetres
		Console.WriteLine("Area of triangle in centimetres is "+area_Of_Triangle+" and in inches is "+area_Of_Triangle_In_Inches);
	}
}
		