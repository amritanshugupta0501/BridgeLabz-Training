using System;
using System.IO;
class ReadCSV 
{
    static void Main(string[] args) 
    {
        string filePath = "students.csv";
        if (!File.Exists(filePath)) 
	{
            Console.WriteLine("File not found! Please run the Write program first.");
            return;
        }
        using (StreamReader reader = new StreamReader(filePath)) 
	{
            string header = reader.ReadLine();
            Console.WriteLine($"{"ID",-5} | {"Name",-15} | {"Age",-5} | {"Marks",-5}");
            Console.WriteLine(new string('-', 40));
            while (!reader.EndOfStream) 
	    {
                string line = reader.ReadLine();
                string[] values = line.Split(',');
                Console.WriteLine($"{values[0],-5} | {values[1],-15} | {values[2],-5} | {values[3],-5}");
            }
        }
    }
}

