using System;
// Display result of a student based on marks of three subjects
class ResultOfStudent
{
	static void Main()
	{
		Console.WriteLine("Give the marks of three subjects of the student : ");	// Input marks of 3 subjects from the user
		double physics = double.Parse(Console.ReadLine());
		double mathematics = double.Parse(Console.ReadLine());
		double chemistry = double.Parse(Console.ReadLine());
		double percentageResult = (physics + chemistry + mathematics) / 3;
		Console.WriteLine("Result Percentage : "+percentageResult);
		if(percentageResult >= 80)
		{
			Console.WriteLine("Result : Level 4, above agency normalized standards.");
		}
		else if(percentageResult >= 70 || percentageResult <= 79)
		{
			Console.WriteLine("Result : Level 3, at agency normalized standards.");
		}
		else if(percentageResult >= 60 || percentageResult <= 69)
		{
			Console.WriteLine("Result : Level 2, below, but approaching agency normalized standards.");
		}
		else if(percentageResult >= 50 || percentageResult <= 59)
		{
			Console.WriteLine("Result : Level 1, well below agency normalized standards.");
		}
		else if(percentageResult >= 40 || percentageResult <= 49)
		{
			Console.WriteLine("Result : Level -1, too below agency normalized standards.");
		}
		else if(percentageResult <= 39)
		{
			Console.WriteLine("Remedial standards");
		}
	}
}