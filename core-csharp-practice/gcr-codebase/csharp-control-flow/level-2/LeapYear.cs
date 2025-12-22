using System;
// Check if the year is leap year or not
class LeapYear
{
	static void Main()
	{
		Console.WriteLine("Give a year : ");							// Input a year from the user
		int year = int.Parse(Console.ReadLine());
		if(year >= 1582 && ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))))	// Condition to check if a year is a leap year or not
		{
			Console.WriteLine(year+" year is a Leap year.");
		}
		else
		{
			Console.WriteLine(year+" year is not a Leap year.");
		}
	}
}