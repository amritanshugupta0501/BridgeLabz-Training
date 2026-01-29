using System;
using System.IO;
using System.Collections.Generic;
class DetectDuplicates 
{
    static void Main(string[] args) 
    {
        DetectDuplicates program = new DetectDuplicates();
        program.FindDuplicates();
    }
    void FindDuplicates() 
    {
        HashSet<string> seenIds = new HashSet<string>();
        using (StreamReader sr = new StreamReader("students.csv")) 
        {
            sr.ReadLine();
            while (!sr.EndOfStream) 
            {
                string line = sr.ReadLine();
                string id = line.Split(',')[0];
                if (!seenIds.Add(id)) 
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}