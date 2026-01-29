using System;
using System.IO;
class LargeCSVReader 
{
    static void Main(string[] args) 
    {
        LargeCSVReader program = new LargeCSVReader();
        program.ProcessLargeFile();
    }
    void ProcessLargeFile() 
    {
        int count = 0;
        using (StreamReader sr = new StreamReader("large_data.csv")) 
        {
            sr.ReadLine();
            while (!sr.EndOfStream) 
            {
                sr.ReadLine(); 
                count++;
                if (count % 100 == 0) 
                {
                    Console.WriteLine(count);
                }
            }
        }
    }
}