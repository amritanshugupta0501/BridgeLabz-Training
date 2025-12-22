using System;
// Check which day of the week falls on a given date
class DayOfTheWeek
{
	static void Main()
	{
		Console.WriteLine("Give the month, day and year of the day : ");		// Input month, day and year from the user
		int month = int.Parse(Console.ReadLine());
		int day = int.Parse(Console.ReadLine());
		int year = int.Parse(Console.ReadLine());
		int year0 = year - (14 - month) / 12;						// Formulas to find day of the week
		int x = year0 + (year0/4) - (year0/100) + (year0/400);				// From Gregorian Calendar
		int month0 = month + 12 * ((14 - month)/12) - 2;
		int day0 = (day + x + 31 * (month0 / 12)) % 7;
		switch(day0)									// Display the week of the day with numbers
		{
			case 0:
				Console.WriteLine("Day of the Week : Sunday");
				break;
			case 1:
				Console.WriteLine("Day of the Week : Monday");
				break;
			case 2:
				Console.WriteLine("Day of the Week : Tuesday");
				break;
			case 3:
				Console.WriteLine("Day of the Week : Wednesday");
				break;
			case 4:
				Console.WriteLine("Day of the Week : Thursday");
				break;
			case 5:
				Console.WriteLine("Day of the Week : Friday");
				break;
			case 6:
				Console.WriteLine("Day of the Week : Saturday");
				break;
		}
	}
}