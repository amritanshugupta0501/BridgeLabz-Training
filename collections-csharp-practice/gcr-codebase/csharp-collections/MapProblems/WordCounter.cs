using System;
using System.Collections.Generic;
using System.Linq;
public class WordCounter
{
    public static Dictionary<string, int> CountWords(string text)
    {
        var counts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        string[] words = text.Split(new[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in words)
        {
            string key = word.ToLower();
            
            if (counts.ContainsKey(key))
                counts[key]++;
            else
                counts[key] = 1;
        }
        return counts;
    }
    public static void Main(string[] args)
    {
        string text = "Hello world, hello Java! Hello C# world.";
        Console.WriteLine($"Input Text: \"{text}\"\n");
        Dictionary<string, int> wordFrequencies = CountWords(text);
        Console.WriteLine("Word Frequencies:");
        foreach (var entry in wordFrequencies)
        {
            Console.WriteLine($"Word: \"{entry.Key}\" - Count: {entry.Value}");
        }
    }
}