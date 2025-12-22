using System;
// Check elegibility employees for bonus in a company
class EmployeeBonus
{
	static void Main()
	{
		Console.WriteLine("Give the salary of the employee : ");				// Input salary of employee from the user
		int salary = int.Parse(Console.ReadLine());
		Console.WriteLine("Give the years of service of the employee : ");			// Input years of service of the employee from user
		double yearsOfService = double.Parse(Console.ReadLine());
		if(yearsOfService > 5)									// Check the number of years of service
		{
			double bonusAmount = (5 * salary)/100;						// Calculate the bonus amount with bonus% = 5%
			Console.WriteLine("Bonus amount for the employee : "+bonusAmount);
		}
		else
		{
			Console.WriteLine("No Bonus for the employee.");
		}
	}
}