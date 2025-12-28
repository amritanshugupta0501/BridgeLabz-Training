using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level1
{
    internal class ComparingTwoStrings
    {
        bool TwoSentencesCompare(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                for (int loop = 0; loop < str1.Length; loop++)
                {
                    int num1 = str1[loop];
                    int num2 = str2[loop];
                    if(num1 != num2)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            Console.WriteLine("Give any two strings : ");
            string sentence1 = Console.ReadLine();
            string sentence2 = Console.ReadLine();
            ComparingTwoStrings compare = new ComparingTwoStrings();
            bool resultMethod = compare.TwoSentencesCompare(sentence1, sentence2);
            if (resultMethod)
            {
                Console.WriteLine("The strings are equal.");
            }
            else
            {
                Console.WriteLine("The strings are not equal.");
            }

        }
    }
}
