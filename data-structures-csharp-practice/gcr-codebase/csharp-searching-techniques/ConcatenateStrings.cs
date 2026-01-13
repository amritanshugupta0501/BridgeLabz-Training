using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.SearchingTechniques
{
    // Add two strings together efficiently
    internal class ConcatenateStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give two texts : ");
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();
            StringBuilder concatenatedText = new StringBuilder(text1);
            for (int loop = 0; loop < text2.Length; loop++)
            {
                concatenatedText.Append(text2[loop]);
            }
            Console.WriteLine(concatenatedText.ToString());
        }
    }
}
