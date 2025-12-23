using System;
// Displaying the result of students using a Matrix
class ResultMatrix
{
	static void Main()
	{
		Console.WriteLine("Give the number of students : ");						// Input number of students from the user
		int students = int.Parse(Console.ReadLine());
		double[,] marksOfStudents = new double[students,4];
		for(int loop = 0; loop < students ; loop++)							// Initiate a loop to input marks in 3 subject
		{
			Console.WriteLine("Give the marks in 3 subjects of the student "+loop+" : ");
			marksOfStudents[loop,0] = double.Parse(Console.ReadLine());
			marksOfStudents[loop,1] = double.Parse(Console.ReadLine());
			marksOfStudents[loop,2] = double.Parse(Console.ReadLine());
			marksOfStudents[loop,3] = (marksOfStudents[loop,0]+marksOfStudents[loop,1]+marksOfStudents[loop,2])/3;	//Calculate average of student
		}
		for(int loop = 0; loop < students ; loop++)							// Initiate a loop to display result and grade
		{
			Console.WriteLine("Result Percentage of student "+loop+": "+marksOfStudents[loop,3]);
			if(marksOfStudents[loop,3] >= 80)								        // Determinig the grade of the student
			{
				Console.WriteLine("Result : Level 4, above agency normalized standards.");
			}
			else if(marksOfStudents[loop,3] >= 70 || marksOfStudents[loop,3] <= 79)
			{
				Console.WriteLine("Result : Level 3, at agency normalized standards.");
			}
			else if(marksOfStudents[loop,3] >= 60 || marksOfStudents[loop,3] <= 69)
			{
				Console.WriteLine("Result : Level 2, below, but approaching agency normalized standards.");
			}
			else if(marksOfStudents[loop,3] >= 50 || marksOfStudents[loop,3] <= 59)
			{
				Console.WriteLine("Result : Level 1, well below agency normalized standards.");
			}
			else if(marksOfStudents[loop,3] >= 40 || marksOfStudents[loop,3] <= 49)
			{
				Console.WriteLine("Result : Level -1, too below agency normalized standards.");
			}
			else if(marksOfStudents[loop,3] <= 39)
			{
				Console.WriteLine("Remedial standards");
			}
		}
	}
}