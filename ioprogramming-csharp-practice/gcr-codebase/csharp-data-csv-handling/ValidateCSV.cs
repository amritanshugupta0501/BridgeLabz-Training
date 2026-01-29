using System;
using System.IO;
using System.Text.RegularExpressions;
class ValidateCSV 
{
    static void Main(string[] args) 
    {
        ValidateCSV program = new ValidateCSV();
        program.Run();
    }
    void Run() 
    {
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        using (StreamReader sr = new StreamReader("contacts.csv")) 
        {
            sr.ReadLine(); 
            while (!sr.EndOfStream) 
            {
                string line = sr.ReadLine();
                string[] cols = line.Split(',');    
                bool isEmailValid = Regex.IsMatch(cols[2], emailPattern);
                bool isPhoneValid = cols[3].Length == 10 && long.TryParse(cols[3], out _);
                if (!isEmailValid || !isPhoneValid) 
                {
                    Console.WriteLine(line);
                    if (!isEmailValid) Console.WriteLine("Invalid Email");
                    if (!isPhoneValid) Console.WriteLine("Invalid Phone");
                }
            }
        }
    }
}