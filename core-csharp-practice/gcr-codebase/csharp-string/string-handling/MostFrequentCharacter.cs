using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.extraproblems
{
    internal class MostFrequentCharacter
    {
        static void Main()
        {
            Console.WriteLine("Give a text : ");                // Input a text from the user
            string text = Console.ReadLine();
            int[] frequency = new int[256];                     // Array to store frequency of each character
            for(int loop = 0; loop < text.Length; loop++)       // Count Occurrences of all the characters
            {
                frequency[text[loop]]++;
            }
            int maxCount = -1;        
            char maxCountCharacter = ' ';
            for(int loop = 0; loop < text.Length; loop++)       // Find the character with the highest character
            {
                if(frequency[text[loop]] > maxCount)
                {
                    maxCount = frequency[text[loop]];
                    maxCountCharacter = text[loop];
                }
            }
            Console.WriteLine("Character with the highest occurrences in the text \""+text+"\" : "+maxCountCharacter);
        }
    }
}
