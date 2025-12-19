using System;
// Compute Harry's age with respect to current year
class HarryAge
{
	static void Main()
	{
		int current_Year = 2024;
		int birth_Year = 2000;
		int age_Of_Harry = current_Year-birth_Year;			// Age = Current Year - Birth Year
		Console.WriteLine("Harry's age in 2024 is "+age_Of_Harry);
	}
}