using System.Collections.Generic;
public class FrequencyCounter
{
    public static Dictionary&lt;string, int&gt; CountFrequency(List&lt;string&gt; items)
    {
        var frequencyMap = new Dictionary&lt;string, int&gt;();
        foreach (var item in items)
        {
            if (frequencyMap.ContainsKey(item))
            {
                frequencyMap[item]++;
            }
            else
            {
                frequencyMap[item] = 1;
            }
        }
        return frequencyMap;
    }
    public static void Main(string[] args)
    {
        List&lt;string&gt; items = new List&lt;string&gt; { "apple", "banana", "apple", "orange", "banana", "apple" };
        var frequencies = CountFrequency(items);
        Console.WriteLine("Frequency count:");
        foreach (var kvp in frequencies)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}