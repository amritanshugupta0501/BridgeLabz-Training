using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.extraproblems
{
    internal class PalindromeString
    {
        static void Main()
        {
            Console.WriteLine("Give a text : ");                            // Input text from the user
            string text = Console.ReadLine();
            int start = 0;
            int end = text.Length;
            bool result = true;
            while (start < end)                                              // Initiate a loop to traverse until both the pointers cross each other
            {
                if (text[start] != text[end])                                // Check if the characters are equal or not
                {
                    result = false;
                    break;
                }
                start++;
                end--;
            }
            Console.WriteLine("Is the text palindrome ? "+result);
        }
    }
}
