using System;
// Check whether the given date comes within Spring season or not
class SpringSeason
{
	static void Main()
	{
		Console.WriteLine("Give the month : ");						// Input month from the user
		int month = int.Parse(Console.ReadLine());
		Console.WriteLine("Give the day : ");						// Input day from the user
		int day = int.Parse(Console.ReadLine());
		if(month == 3 && day >= 20)							// Check if the date lies within March 20 to June 20
		{
			Console.WriteLine("It is a Spring Season.");
		}
		else if(month == 4)
		{
			Console.WriteLine("It is a Spring Season.");
		}
		else if(month == 5)
		{
			Console.WriteLine("It is a Spring Season.");
		}
		else if(month ==6 && day <= 20)
		{
			Console.WriteLine("It is a Spring Season.");
		}
		else
		{
			Console.WriteLine("It is not a Spring Season.");
		}
	}
}