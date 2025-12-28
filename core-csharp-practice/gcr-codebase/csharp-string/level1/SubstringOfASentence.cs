using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level1
{
    internal class SubstringOfASentence
    {
        void GetSubString(string str, int start, int end)
        {
            string newStr = new string("") ;
            for (int loop = start; loop < end; loop++)
            {
                newStr.Append(str[loop]) ;
            }
            if(newStr.Equals(str.Substring(start,end)))
            {
                Console.WriteLine("The substring of the sentence : "+newStr);
            }
            else
            {
                Console.WriteLine("The substring does not match");
            }
        }
        static void Main()
        {
            Console.WriteLine("Give a sentence of your choice : ");
            string sentence = Console.ReadLine();
            Console.WriteLine("Give a start index and an end index for the substring : ");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            if(start < 0 || end > sentence.Length || start > end)
            {
                Console.WriteLine("The inputted length of the substring is invalid");
            }
            else
            {
                SubstringOfASentence substring = new SubstringOfASentence();
                substring.GetSubString(sentence,start,end);
            }
        }
    }
}
