using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.SearchingTechniques
{
    // Reversing a string using string builder
    internal class ReverseAString
    {
        static void Main(string[] args)
        {
            Console.Write("Give a text : ");
            string text = Console.ReadLine();
            StringBuilder reverse = new StringBuilder(text);
            for (int loop = reverse.Length - 1; loop >= 0; loop--) 
            {
                Console.Write(reverse[loop].ToString());
            }
        }
    }
}
