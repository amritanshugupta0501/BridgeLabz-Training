using System;
using System.Collections.Generic;
using System.Linq;
public class SetOperations
{
    public static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int> { 4, 5, 6, 7, 8 };
        Console.WriteLine($"Set A: [{string.Join(", ", set1)}]");
        Console.WriteLine($"Set B: [{string.Join(", ", set2)}]");
        HashSet<int> unionResult = GetUnion(set1, set2);
        Console.WriteLine($"Union (A ∪ B):        [{string.Join(", ", unionResult)}]");
        HashSet<int> intersectResult = GetIntersection(set1, set2);
        Console.WriteLine($"Intersection (A ∩ B): [{string.Join(", ", intersectResult)}]");
    }
    public static HashSet<int> GetUnion(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> union = new HashSet<int>(set1);
        union.UnionWith(set2); 
        return union;
    }
    public static HashSet<int> GetIntersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> intersection = new HashSet<int>(set1);
        intersection.IntersectWith(set2);
        return intersection;
    }
}