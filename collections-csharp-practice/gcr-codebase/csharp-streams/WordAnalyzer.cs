using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordAnalyzer
{
    static void Main()
    {
        string path = "text.txt";
        File.WriteAllText(path, "apple banana apple orange banana apple grape kiwi orange kiwi");

        Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        using (StreamReader sr = new StreamReader(path))
        {
            string content = sr.ReadToEnd();
            string[] words = content.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word))
                    wordCounts[word]++;
                else
                    wordCounts[word] = 1;
            }
        }

        var topWords = wordCounts.OrderByDescending(x => x.Value).Take(5);

        foreach (var pair in topWords)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}