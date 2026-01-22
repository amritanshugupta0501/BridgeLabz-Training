using System;
using System.IO;

class StudentRecordSystem
{
    static void Main()
    {
        string file = "student.bin";

        using (BinaryWriter writer = new BinaryWriter(File.Open(file, FileMode.Create)))
        {
            writer.Write(101);
            writer.Write("John Doe");
            writer.Write(3.85);
        }

        using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open)))
        {
            int rollNo = reader.ReadInt32();
            string name = reader.ReadString();
            double gpa = reader.ReadDouble();

            Console.WriteLine($"Roll: {rollNo}, Name: {name}, GPA: {gpa}");
        }
    }
}