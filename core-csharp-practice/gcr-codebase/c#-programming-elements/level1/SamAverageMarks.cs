using System;
// Compute average marks of Sam in physics, chemistry and mathematics
class SamAverageMarks
{
	static void Main()
	{
		int mathematics = 94;
		int physics = 95;
		int chemistry = 96;
		double average = (mathematics+physics+chemistry)/3;			// Average = Sum of elements/No. of elements
		Console.WriteLine("Average Marks of Same in three subjects PCM : "+average);
	}
}