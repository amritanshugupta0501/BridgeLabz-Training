using System;
using System.IO;
using System.Collections.Generic;
class Employee 
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    public override string ToString() 
    {
        return $"{ID,-5} | {Name,-12} | {Department,-10} | ${Salary:N2}";
    }
}
class SortCSV
{
    static void Main(string[] args) 
    {
        string path = "employees.csv";
        List<Employee> employeeList = new List<Employee>();
        if (!File.Exists(path)) 
	{
	    return;
	}
        using (StreamReader sr = new StreamReader(path)) 
	{
            sr.ReadLine();
            while (!sr.EndOfStream) 
	    {
                string[] cols = sr.ReadLine().Split(',');
                employeeList.Add(new Employee {
                    ID = cols[0],
                    Name = cols[1],
                    Department = cols[2],
                    Salary = double.Parse(cols[3])
                });
            }
        }
        employeeList.Sort((emp1, emp2) => emp2.Salary.CompareTo(emp1.Salary));
        Console.WriteLine("Top 5 Highest Paid Employees (Sorted Manually):");
        int count = Math.Min(5, employeeList.Count);
        for (int i = 0; i < count; i++) 
	{
            Console.WriteLine(employeeList[i]);
        }
    }
}