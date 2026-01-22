using System;
using System.IO;

class TextCaseConverter
{
    static void Main()
    {
        string source = "upper.txt";
        string dest = "lower.txt";

        File.WriteAllText(source, "HELLO WORLD THIS IS C#");

        try
        {
            using (StreamReader reader = new StreamReader(source))
            using (StreamWriter writer = new StreamWriter(dest))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}