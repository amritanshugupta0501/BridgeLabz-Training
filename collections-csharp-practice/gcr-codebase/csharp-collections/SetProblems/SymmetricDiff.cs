using System;
using System.Collections.Generic;
public class SymmetricDiff
{
    public static void Main(string[] args)
    {
        // 1. Initialize two HashSets with some overlapping data
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int> { 4, 5, 6, 7, 8 };
        // 2. Display initial sets
        Console.WriteLine($"Set 1: [{string.Join(", ", set1)}]");
        Console.WriteLine($"Set 2: [{string.Join(", ", set2)}]");
        // 3. Calculate Symmetric Difference
        HashSet<int> result = GetSymmetricDifference(set1, set2);
        // 4. Display Result
        Console.WriteLine($"Symmetric Difference: [{string.Join(", ", result)}]");
    }
    public static HashSet<int> GetSymmetricDifference(HashSet<int> set1, HashSet<int> set2)
    {
        // Create a copy of set1 so we don't modify the original collection
        HashSet<int> result = new HashSet<int>(set1); 
        // Modifies 'result' to contain only elements that are present 
        // in either 'result' or 'set2', but not both.
        result.SymmetricExceptWith(set2);     
        return result;
    }
}