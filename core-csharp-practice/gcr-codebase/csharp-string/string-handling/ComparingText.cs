using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.extraproblems
{
    internal class ComparingText
    {
        static void Main()
        {
            Console.WriteLine("Give any two texts : ");                                         // Input two texts from the user
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();
            int minimum = (text1.Length < text2.Length) ? text1.Length : text2.Length;          // Check the minimum of the two lengths
            int result = 0;
            for (int loop = 0; loop < minimum; loop++)
            {
                if (text1[loop] != text2[loop])                                                 // Compute the text based on ASCII values of characters
                {
                    result = text1[loop] - text2[loop];
                    break;
                }
                result = text1.Length - text2.Length;                                           // Compute difference in lengths of the texts
            }
            if (result < 0)
            {
                Console.WriteLine("\"" + text1 + "\" comes before \"" + text2 + "\" in lexicographical order.");
            }
            else if (result > 0)
            {
                Console.WriteLine("\"" + text2 + "\" comes before \"" + text1 + "\" in lexicographical order.");
            }
            else
            {
                Console.WriteLine("\"" + text1 + "\" and \"" + text2 + "\" are equal in lexicographical order.");
            }
        }
    }
}
