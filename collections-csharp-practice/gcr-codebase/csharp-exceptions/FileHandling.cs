using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.exceptions
{
    // Class defined to handle exception "FileNotFoundException"
    internal class FileHandling
    {
        static void Main(string[] args)
        {
            string filePath = "information.txt";
            try
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("File contents : \n"+filePath);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File Not Found");
            }
        }
    }
}
