using System;
using System.IO;
class SearchCSV 
{
    static void Main(string[] args) 
    {
        Console.Write("Enter Employee Name to Search: ");
        string searchName = Console.ReadLine();
        bool found = false;
        using (StreamReader sr = new StreamReader("employees.csv")) 
	{
            sr.ReadLine();
            while (!sr.EndOfStream) 
	    {
                string[] emp = sr.ReadLine().Split(',');
                if (emp[1].Equals(searchName, StringComparison.OrdinalIgnoreCase)) 
		{
                    Console.WriteLine($"Match Found! Dept: {emp[2]}, Salary: {emp[3]}");
                    found = true;
                    break;
                }
            }
        }
        if (!found) 
	{
	    Console.WriteLine("Employee not found.");
	}
    }
}