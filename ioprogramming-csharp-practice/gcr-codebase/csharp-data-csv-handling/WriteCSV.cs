using System;
using System.IO;
using System.Collections.Generic;
class WriteCSV 
{
    static void Main(string[] args) 
    {
        string filePath = "employees.csv";
        string[] records = {
            "ID,Name,Department,Salary",
            "101,John Doe,IT,75000",
            "102,Jane Smith,HR,62000",
            "103,Sam Wilson,IT,80000",
            "104,Emily Davis,Finance,95000",
            "105,Michael Brown,Marketing,54000"
        };
        try 
	{
            File.WriteAllLines(filePath, records);
            Console.WriteLine("Successfully wrote 5 records to employees.csv");
        } 
	catch(Exception ex) 
	{
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
