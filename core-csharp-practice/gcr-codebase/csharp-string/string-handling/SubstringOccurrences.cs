using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.extraproblems
{
    internal class SubstringOccurrences
    {
        static void Main()
        {
            Console.WriteLine("Give a text : ");                                                                // Input a text from the user
            string text = Console.ReadLine();
            Console.WriteLine("Give the substring u want to count : ");
            string subString = Console.ReadLine();
            int count = 0;
            int index = 0;
            while((index = text.IndexOf(subString,index))!=-1)                                                  // Traverse using loop through the text to count occurrences of the substring
            {
                count++;
                index += subString.Length;
            }
            Console.WriteLine("Occurrences of the substring "+subString+" in the text "+text+" : "+count);
        }
    }
}
