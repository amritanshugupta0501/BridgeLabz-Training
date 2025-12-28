using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.extraproblems
{
    internal class LongestWord
    {
        static void Main()
        {
            Console.WriteLine("Give a text : ");                                    // Input a text from the user
            string text = Console.ReadLine();
            string[] words = text.Split(' ');                                       // Split the text in words array
            string longestWord = words[0];
            for (int loop = 0; loop < words.Length; loop++)                         // Traverse through the array to check the longest word    
            {
                if (longestWord.Length < words[loop].Length)
                {
                    longestWord = words[loop];
                }
            }
            Console.WriteLine("The longest word in the text : "+longestWord);
        }
    }
}
