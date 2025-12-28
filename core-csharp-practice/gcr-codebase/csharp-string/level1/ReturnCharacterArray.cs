using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level1
{
    internal class ReturnCharacterArray
    {
        char[] ReturnCharacters(string str)
        {
            char[] result = new char[str.Length];
            for(int loop = 0; loop < str.Length;loop++)
            {
                result[loop] = str[loop];
            }
            return result;
        }
        static void Main()
        {
            Console.WriteLine("Give a sentence : ");
            string sentence = Console.ReadLine();
            ReturnCharacterArray array = new ReturnCharacterArray();
            char[] result = array.ReturnCharacters(sentence);
            Console.WriteLine("Character array : ");
            for(int loop = 0; loop < result.Length;loop++)
            {
                Console.WriteLine(result[loop]); 
            }
            if(result.Equals(sentence.ToCharArray()))
            {
                Console.WriteLine("The result is same.");
            }
            else
            {
                Console.WriteLine("The result is different.");
            }
        }
    }
}
