using System;
using System.IO;
class CountCSV 
{
    static void Main(string[] args) 
    {
        string filePath = "employees.csv";
        int recordCount = 0;
        if (File.Exists(filePath)) 
	{
            using (StreamReader reader = new StreamReader(filePath)) 
	    {
                reader.ReadLine();
                while (reader.ReadLine() != null) 
		{
                    recordCount++;
                }
            }
            Console.WriteLine($"Total number of records (excluding header): {recordCount}");
        } 
	else 
	{
            Console.WriteLine("File does not exist.");
        }
    }
}