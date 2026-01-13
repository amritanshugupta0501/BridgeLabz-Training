using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.SearchingTechniques
{
    // Search for a specific word in a sentence
    internal class WordSearchInSentence
    {
        static void Main()
        {
            Console.Write("Enter the number of sentences: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                string[] sentences = new string[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Enter sentence {i + 1}: ");
                    sentences[i] = Console.ReadLine();
                }
                Console.Write("Enter the word to search for: ");
                string searchWord = Console.ReadLine();
                bool found = false;
                for (int i = 0; i < n; i++)
                {
                    if (sentences[i].Contains(searchWord))
                    {
                        Console.WriteLine($"Found in sentence: {sentences[i]}");
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Word not found in any sentence.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
