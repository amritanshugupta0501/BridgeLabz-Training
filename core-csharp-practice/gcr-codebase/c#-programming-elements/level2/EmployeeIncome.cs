using System;
// Compute Total income of an employee
class EmployeeIncome
{
	static void Main()
	{
		Console.WriteLine("Give salary and bonus of the employee : ");		// Input salary and bonus of an employee
		double employee_Salary = double.Parse(Console.ReadLine());
		double employee_Bonus = double.Parse(Console.ReadLine());
		double total_Income = employee_Salary + employee_Bonus;			// Total income = salary + bonus of the employee
		Console.WriteLine("The salary is INR "+employee_Salary+" and bonus is INR "+employee_Bonus+". Hence total income is INR "+total_Income);
	}
}