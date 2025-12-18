using System;

class AreaOfCircle
{
	static void Main()
	{
		Console.WriteLine("Give the radius of the circle : ");
		double radius=double.Parse(Console.ReadLine());
		double area = Math.PI * radius * radius;
		Console.WriteLine("Area Of Circle: " + area);
	}
}