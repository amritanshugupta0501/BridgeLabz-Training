using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.extraproblems
{
    internal class RemoveACharacter
    {
        static void Main()
        {
            Console.WriteLine("Give a text : ");
            string text = Console.ReadLine();                                   // Input a text from the user
            Console.WriteLine("Give a character you want to remove : ");
            char characterToRemove = Console.ReadLine()[0];                     // Input a character from the user
            StringBuilder newText = new StringBuilder();
            for (int loop = 0; loop < text.Length; loop++)                      // Check the character to remove and update the text
            {
                if(characterToRemove != text[loop])
                {
                    newText.Append(text[loop]);
                }
            }
            Console.WriteLine("Original Text : "+text);
            Console.WriteLine("Updated Text : " + newText);
        }
    }
}
