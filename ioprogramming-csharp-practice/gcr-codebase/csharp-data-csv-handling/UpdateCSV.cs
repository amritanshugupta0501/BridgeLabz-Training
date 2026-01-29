using System;
using System.IO;
using System.Collections.Generic;
class UpdateCSV 
{
    static void Main(string[] args) 
    {
        string inputPath = "employees.csv";
        string outputPath = "employees_updated.csv";
        List<string> updatedLines = new List<string>();
        string[] lines = File.ReadAllLines(inputPath);
        updatedLines.Add(lines[0]);
        for (int i = 1; i < lines.Length; i++) 
	{
            string[] cols = lines[i].Split(',');
            if (cols[2] == "IT")
 	    {
                double salary = double.Parse(cols[3]);
                cols[3] = (salary * 1.10).ToString("F2");
            }
            updatedLines.Add(string.Join(",", cols));
        }
        File.WriteAllLines(outputPath, updatedLines);
        Console.WriteLine("IT salaries updated and saved to employees_updated.csv");
    }
}