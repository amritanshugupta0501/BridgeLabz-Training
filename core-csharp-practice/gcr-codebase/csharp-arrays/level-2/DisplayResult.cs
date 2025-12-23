using System;
// Display the result of a student based on marks of physics, chemistry and mathematics
class DisplayResult
{
	static void Main()
	{
		Console.WriteLine("Give the number of Students : ");					// Input number of students from the user
		int students = int.Parse(Console.ReadLine());
		for(int student = 1 ; student <= students ; student++)
		{
			Console.WriteLine("Give the details of the student "+student+" : ");
			double[] marksStudent = new double[3];
			for(int loop = 0; loop < 3; loop++)						// Initiate a loop to get marks of three subjects 
			{
				Console.WriteLine("Give the marks of subject "+(loop+1)+" : ");		// Input of marks from the user
				marksStudent[loop] = double.Parse(Console.ReadLine());
			}
			double average = (marksStudent[0]+marksStudent[1]+marksStudent[2])/3;		// Calculate average marks of the student	
			Console.WriteLine("Result Percentage of student "+student+": "+average);
			if(average >= 80)								// Determinig the grade of the student
			{
				Console.WriteLine("Result : Level 4, above agency normalized standards.");
			}
			else if(average >= 70 || average <= 79)
			{
				Console.WriteLine("Result : Level 3, at agency normalized standards.");
			}
			else if(average >= 60 || average <= 69)
			{
				Console.WriteLine("Result : Level 2, below, but approaching agency normalized standards.");
			}
			else if(average >= 50 || average <= 59)
			{
				Console.WriteLine("Result : Level 1, well below agency normalized standards.");
			}
			else if(average >= 40 || average <= 49)
			{
				Console.WriteLine("Result : Level -1, too below agency normalized standards.");
			}
			else if(average <= 39)
			{
				Console.WriteLine("Remedial standards");
			}
		}
	}
}