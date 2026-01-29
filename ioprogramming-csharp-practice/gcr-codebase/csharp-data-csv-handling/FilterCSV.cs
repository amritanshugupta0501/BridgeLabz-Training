using System;
using System.IO;
class FilterCSV 
{
    static void Main(string[] args) 
    {
        string path = "students.csv";
        if (!File.Exists(path)) 
	{
	    return;
	}
        using (StreamReader sr = new StreamReader(path)) 
	{
            string header = sr.ReadLine();
            Console.WriteLine($"Qualifying Students (>80 Marks):\n{header}");
            while (!sr.EndOfStream) 
	    {
                string line = sr.ReadLine();
                string[] data = line.Split(',');
                if (double.TryParse(data[3], out double marks) && marks > 80) 
		{
                    Console.WriteLine(line);
                }
            }
        }
    }
}