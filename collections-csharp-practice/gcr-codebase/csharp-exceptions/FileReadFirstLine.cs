using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.exceptions
{
    // Class defined to depict the Handling of exceptions in file reading operations
    internal class FileReadFirstLine
    {
        static void Main(string[] args)
        {
            string filePath = "information.txt";
            try
            {
                using(StreamReader fileRead = new StreamReader(filePath))
                {
                    string firstLine = fileRead.ReadLine();
                    if(firstLine!=null)
                    {
                        Console.WriteLine("First line of the file : "+firstLine);
                    }
                    else
                    {
                        Console.WriteLine("The file is empty");
                    }
                }
            }
            catch(IOException)
            {
                Console.WriteLine("Cannot Read your given file.");
            }
        }
    }
}
