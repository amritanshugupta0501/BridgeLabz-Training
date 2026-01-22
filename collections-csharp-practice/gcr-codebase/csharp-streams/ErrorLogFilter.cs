using System;
using System.IO;

class ErrorLogFilter
{
    static void Main()
    {
        string path = "logs.txt";
        
        using (StreamWriter sw = File.CreateText(path))
        {
            sw.WriteLine("Info: Process started");
            sw.WriteLine("Error: Connection failed");
            sw.WriteLine("Info: Retry attempt 1");
            sw.WriteLine("Error: Timeout occurred");
        }

        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}