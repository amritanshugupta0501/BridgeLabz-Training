using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level1
{
    internal class TextToUppercase
    {
        void ToUpperCaseText(string str)
        {
            StringBuilder newStr = new StringBuilder(str);
            for (int loop = 0; loop < str.Length; loop++) 
            {
                int ch = newStr[loop];
                if (ch >= 97 || ch <= 122)
                {
                    newStr[loop] = (char)(ch - 32);
                   
                }
                
            }
            Console.WriteLine("Updated text into Uppercase : "+newStr);
            if(newStr.ToString().Equals(str.ToUpper()))
            {
                Console.WriteLine("The result is same.");
            }
            else
            {
                Console.WriteLine("The result is not same.");
            }
        }
        static void Main()
        {
            Console.WriteLine("Give a text : ");
            string sentence = Console.ReadLine();
            TextToUppercase text = new TextToUppercase();
            text.ToUpperCaseText(sentence);
        }
    }
}
