using System;
// Compute the number of rounds an athlete completes
class RoundsCompleted
{
	static void Main()
	{
		Console.WriteLine("Give the three sides of the triangular field : "); 			// Input three sides of triangle from the user
		double side1 = double.Parse(Console.ReadLine());
		double side2 = double.Parse(Console.ReadLine());
		double side3 = double.Parse(Console.ReadLine());
		double perimeter_Of_Field = side1 + side2 + side3;					// Perimeter is sum of all the sides of the shape
		double number_Of_Rounds = 5 / perimeter_Of_Field;						// Rounds = distance / perimeter
		Console.WriteLine("The total number of rounds the athlete will run is "+number_Of_Rounds+" to complete 5 kilometers");
	}
}