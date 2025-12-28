using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.extraproblems
{
    internal class AnagramStrings
    {
        static void Main()
        {
            Console.WriteLine("Give two texts : ");                                     // Input two texts from the user
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();
            text1 = text1.Trim();
            text2 = text2.Trim();
            bool result = false;
            if(text1.Length == text2.Length)                                            // Check whether the lengths of the texts are equal or not
            {
                text1 = text1.ToLower();
                text2 = text2.ToLower();
                int[] countFrequency = new int[256];
                for(int loop=0; loop<text1.Length;loop++)                               // Count the frequency of characters in the texts
                {
                    countFrequency[text1[loop]]++;
                    countFrequency[text2[loop]]--;
                }
                for (int loop = 0; loop < countFrequency.Length; loop++)                // Check the frequency of characters in the texts if they cancel each other or not
                {
                    if(countFrequency[loop] != 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            if(result)                                                                  // Check if the texts are anagrams or not
            {
                Console.WriteLine("\"" + text1 + "\" and \"" + text2 + "\" are anagrams of each other.");
            }
            else
            {
                Console.WriteLine("\"" + text1 + "\" and \"" + text2 + "\" are not anagrams of each other.");
            }
        }
    }
}
