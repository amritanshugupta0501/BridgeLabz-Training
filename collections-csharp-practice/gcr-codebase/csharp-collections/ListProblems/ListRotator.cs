using System.Collections.Generic;
public class ListRotator
{
    public static void RotateRight&lt;T&gt;(List&lt;T&gt; list, int k)
    {
        if (list == null || list.Count == 0) return;
        k = k % list.Count;
        if (k == 0) return;
        List&lt;T&gt; temp = new List&lt;T&gt;();
        int splitIndex = list.Count - k;
        for (int i = splitIndex; i &lt; list.Count; i++)
        {
            temp.Add(list[i]);
        }
        for (int i = 0; i &lt; splitIndex; i++)
        {
            temp.Add(list[i]);
        }
        for (int i = 0; i &lt; list.Count; i++)
        {
            list[i] = temp[i];
        }
    }
    public static void Main(string[] args)
    {
        List&lt;int&gt; list = new List&lt;int&gt; { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine("Original list:");
        foreach (var i in list) Console.Write(i + " ");
        Console.WriteLine();
        RotateRight(list, 2);
        Console.WriteLine("Rotated right by 2:");
        foreach (var i in list) Console.Write(i + " ");
        Console.WriteLine();
    }
}