using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.extraproblems
{
    internal class CaseChangingOfCharacters
    {
        static void Main()
        {
            Console.WriteLine("Give a text : ");                            // Input text from the user
            string text = Console.ReadLine();
            StringBuilder newText = new StringBuilder(text);
            for (int loop = 0; loop < newText.Length; loop++)               // Traverse through each character
            {
                if (newText[loop] >= 'a' && newText[loop] <= 'z')           // Check if the character is Lowercase or Uppercase
                {
                    char ch = newText[loop];                                // Toggle the case of the characters based on their ASCII Values
                    int num = ch;
                    num -= 32;
                    ch = (char)num;
                    newText[loop] = ch;
                }
                else if (newText[loop] >= 'A' && newText[loop] <= 'Z')
                {
                    char ch = newText[loop];
                    int num = ch;
                    num += 32;
                    ch = (char)num;
                    newText[loop] = ch;
                }
            }
            Console.WriteLine("Original Text : "+text);
            Console.WriteLine("Toggled Text : " + newText);
        }
    }
}
