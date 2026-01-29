using System;
using System.IO;
using System.Collections.Generic;
class Student 
{
    public string ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Marks { get; set; }
}
class CSVToObjects 
{
    static void Main(string[] args) 
    {
        CSVToObjects program = new CSVToObjects();
        program.Execute();
    }
    void Execute() 
    {
        List<Student> students = new List<Student>();
        using (StreamReader sr = new StreamReader("students.csv")) 
        {
            sr.ReadLine();
            while (!sr.EndOfStream) 
            {
                string[] cols = sr.ReadLine().Split(',');
                students.Add(new Student {
                    ID = cols[0],
                    Name = cols[1],
                    Age = int.Parse(cols[2]),
                    Marks = double.Parse(cols[3])
                });
            }
        }
        foreach (var s in students) 
        {
            Console.WriteLine(s.ID + " " + s.Name);
        }
    }
}