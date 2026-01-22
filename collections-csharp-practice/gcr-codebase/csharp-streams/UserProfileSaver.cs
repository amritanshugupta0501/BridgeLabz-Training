using System;
using System.IO;

class UserProfileSaver
{
    static void Main()
    {
        try
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            string age = Console.ReadLine();

            Console.Write("Enter Favorite Language: ");
            string language = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter("userdata.txt"))
            {
                writer.WriteLine($"Name: {name}");
                writer.WriteLine($"Age: {age}");
                writer.WriteLine($"Language: {language}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}