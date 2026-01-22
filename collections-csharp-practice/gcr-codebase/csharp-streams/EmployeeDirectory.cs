using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}

class EmployeeDirectory
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "IT", Salary = 60000 },
            new Employee { Id = 2, Name = "Bob", Department = "HR", Salary = 55000 }
        };

        string filePath = "employees.json";

        try
        {
            string jsonString = JsonSerializer.Serialize(employees);
            File.WriteAllText(filePath, jsonString);

            string readJson = File.ReadAllText(filePath);
            List<Employee> loadedEmployees = JsonSerializer.Deserialize<List<Employee>>(readJson);

            foreach (var emp in loadedEmployees)
            {
                Console.WriteLine($"{emp.Id}: {emp.Name} - {emp.Department}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}