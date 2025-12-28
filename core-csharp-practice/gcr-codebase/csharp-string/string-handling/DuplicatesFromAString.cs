using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.extraproblems
{
    internal class DuplicatesFromAString
    {
        static void Main()
        {
            Console.WriteLine("Give a text : ");                        // Input a text from the user
            string text = Console.ReadLine();
            string result = "";
            for (int loop = 0; loop < text.Length; loop++)              // Traverse through the text to sort the duplicate characters
            {
                if (result.IndexOf(text[loop]) == -1)
                {
                    result.Append(text[loop]);
                }
            }
            Console.WriteLine("Text withou duplicates : "+result);
        }
    }
}
