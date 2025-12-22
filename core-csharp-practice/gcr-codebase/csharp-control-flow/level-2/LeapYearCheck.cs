using System;
// Check whether a year is leap year or not
class LeapYearCheck
{
	static void Main()
	{
		Console.WriteLine("Give a year : ");						// Input a year from the user
		int year = int.Parse(Console.ReadLine());
		if(year >= 1582)								// Check the conditions required for a leap year
		{
			if(year % 400 == 0)
			{
				Console.WriteLine(year+" year is a leap year");
			}
			else if(year % 4 == 0)
			{
				if(year % 100 != 0)
				{
					Console.WriteLine(year+" year is a leap year");
				}
				else
				{
					Console.WriteLine(year+" year is not a leap year");
				}
			}
			else
			{
				Console.WriteLine(year+" year is not a leap year");
			}
		}
		else
		{
			Console.WriteLine(year+" year is not a leap year");
		}
	}
}