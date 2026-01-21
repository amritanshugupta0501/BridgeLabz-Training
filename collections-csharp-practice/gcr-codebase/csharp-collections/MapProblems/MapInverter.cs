using System;
using System.Collections.Generic;
public class MapInverter
{
    public static Dictionary<int, List<string>> InvertMap(Dictionary<string, int> input)
    {
        var result = new Dictionary<int, List<string>>();

        foreach (var kvp in input)
        {
            if (!result.ContainsKey(kvp.Value))
            {
                result[kvp.Value] = new List<string>();
            }
            result[kvp.Value].Add(kvp.Key);
        }
        return result;
    }
    public static void Main(string[] args)
    {
        Dictionary<string, int> inputMap = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 },
            { "D", 3 },
            { "E", 2 }
        };
        Console.WriteLine("Original Map:");
        foreach (var kvp in inputMap)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
        Dictionary<int, List<string>> invertedMap = InvertMap(inputMap);
        Console.WriteLine("\nInverted Map:");
        foreach (var kvp in invertedMap)
        {
            Console.WriteLine($"Value: {kvp.Key}, Keys: [{string.Join(", ", kvp.Value)}]");
        }
    }
}