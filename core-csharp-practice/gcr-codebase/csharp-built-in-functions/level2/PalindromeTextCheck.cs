using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinfunction.level2
{
    internal class PalindromeTextCheck
    {
        static void Main()
        {
            Console.WriteLine("Give a text : ");
            string text = Console.ReadLine();
            if (CheckPalindrome(text))
            {
                Console.WriteLine("The text is Palindrome Text");
            }
            else
            {
                Console.WriteLine("The text is not Palindrome Text");
            }
        }
        static bool CheckPalindrome(string text)
        {
            int start = 0, end = text.Length-1;
            text = text.ToLower();
            while (start < end)
            {
                if (text[start] != text[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}
