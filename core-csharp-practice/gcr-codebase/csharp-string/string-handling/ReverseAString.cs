using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.extraproblems
{
    internal class ReverseAString
    {
        static int LengthText(string str)
        {
            int length = 0 ;
            foreach(char ch in str)
            {
                length++;
            }
            return length;
        }
        static void Main()
        {
            Console.WriteLine("Give a text to reverse : ");
            string text = Console.ReadLine();
            int length = LengthText(text);
            for (int loop = length - 1; loop >= 0; loop--)
            {
                Console.Write(text[loop]);
            }
        }
    }
}
