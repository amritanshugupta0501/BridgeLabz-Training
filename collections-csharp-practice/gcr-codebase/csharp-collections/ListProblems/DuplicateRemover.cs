using System.Collections.Generic;
public class DuplicateRemover
{
    public static List&lt;int&gt; RemoveDuplicates(List&lt;int&gt; input)
    {
        HashSet&lt;int&gt; seen = new HashSet&lt;int&gt;();
        List&lt;int&gt; result = new List&lt;int&gt;();
        foreach (int num in input)
        {
            if (seen.Add(num))
            {
                result.Add(num);
            }
        }
        return result;
    }
    public static void Main(string[] args)
    {
        List&lt;int&gt; input = new List&lt;int&gt; { 1, 2, 2, 3, 4, 4, 5 };
        Console.WriteLine("Original list:");
        foreach (var i in input) Console.Write(i + " ");
        Console.WriteLine();
        var result = RemoveDuplicates(input);
        Console.WriteLine("After removing duplicates:");
        foreach (var i in result) Console.Write(i + " ");
        Console.WriteLine();
    }
}