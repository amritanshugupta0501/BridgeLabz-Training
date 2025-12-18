using System;

class VolumeOfCylinder
{
	static void Main()
	{
		Console.WriteLine("Give Radius and Height of the Cylinder : ");
		double radius=double.parse(Console.ReadLine());
		double height=double.parse(Console.WriteLine());
		double Volume=Math.PI*radius*radius*height;
		Console.WriteLine("Volume of the Cylinder : "+Volume);
	}
}