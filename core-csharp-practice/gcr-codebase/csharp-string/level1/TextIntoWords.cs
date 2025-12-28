using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level1
{
    internal class TextIntoWords
    {
        int GetTextLength(string text)
        {
            int counter = 0;
            
            for (int loop = 0; loop < text.Length; loop++)
            {
                if (text[loop]==' ')
                {
                    counter++;
                }
            }
            return counter;
        }
        string[] GetWordsArray(string text, int length)
        {
            string[] words = new string[length];
            int index = 0;
            int prev = 0;
            for(int loop = 0; loop < text.Length;loop++)
            {
                if (text[loop]==' ')
                {
                    words[index] = text.Substring(prev,loop-prev);
                    prev = loop+1;
                    index += 1;
                }
            }
            return words;
        }
        string GetWordLength(string text) 
        {
            int length = 0;
            foreach(char ch in text)
            {
                length++;
            }
            return length.ToString();
        }
        static void Main() 
        {
            Console.WriteLine("Give a text : ");
            string text = Console.ReadLine();
            text.Trim();
            text = text + " ";
            TextIntoWords textWords = new TextIntoWords();
            int length = textWords.GetTextLength(text);
            string[] words = textWords.GetWordsArray(text,length);
            string[,] result = new string[length,2];
            for(int loop = 0;loop < words.Length;loop++)
            {
                result[loop,0] = words[loop];
                result[loop, 1] = textWords.GetWordLength(words[loop]);
                Console.WriteLine(result[loop, 0] + "\t" + result[loop,1] );
            }
        }
    }
}
