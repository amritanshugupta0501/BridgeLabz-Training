using System;
using System.Collections.Generic;
public class SubsetChecker
{
    public static bool IsSubset(HashSet<int> sub, HashSet<int> super)
    {
        return sub.IsSubsetOf(super);
    }
    public static void Main(string[] args)
    {
        HashSet<int> mainSet = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> subSet = new HashSet<int> { 2, 4 };
        bool result1 = IsSubset(subSet, mainSet); 
        Console.WriteLine("Test 1 (Expected: True): " + result1);
        HashSet<int> otherSet = new HashSet<int> { 1, 6 }; // '6' is not in the mainSet
        bool result2 = IsSubset(otherSet, mainSet);
        Console.WriteLine("Test 2 (Expected: False): " + result2);
        // Keep console open if running in debug mode
        Console.ReadKey();
    }
}