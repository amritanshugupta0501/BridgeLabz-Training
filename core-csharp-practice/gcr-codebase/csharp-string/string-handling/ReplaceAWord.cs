using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.extraproblems
{
    internal class ReplaceAWord
    {
        static void Main()
        {
            Console.WriteLine("Give a text : ");                            // Input a text from the user
            string text = Console.ReadLine();
            Console.WriteLine("Give a word to replace : ");
            string wordReplace = Console.ReadLine();                        // Input the word to be replaced
            Console.WriteLine("Give a word to replace with : ");
            string wordReplaceTo = Console.ReadLine();                      // Input the word to replace with
            string[] words = text.Split(' ');                               // Split the text into words
            for(int loop=0; loop<words.Length; loop++)                      // Traverse through the array and replace the words
            {
                if(words[loop].Equals(wordReplace))
                {
                    words[loop] = wordReplaceTo;
                }
            }
            Console.WriteLine("Original Text : " + text);
            text = string.Join(" ", words);
            Console.WriteLine("Updated Text : " + text);
        }
    }
}
