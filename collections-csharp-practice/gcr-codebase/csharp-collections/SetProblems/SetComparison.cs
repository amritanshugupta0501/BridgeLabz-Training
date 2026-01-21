using System;
using System.Collections.Generic;
public class SetComparison
{
    public static void Main(string[] args)
    {
        HashSet<int> setA = new HashSet<int> { 1, 2, 3 };
        HashSet<int> setB = new HashSet<int> { 3, 2, 1 };
        HashSet<int> setC = new HashSet<int> { 1, 2, 4 };
        Console.WriteLine($"Set A: [{string.Join(", ", setA)}]");
        Console.WriteLine($"Set B: [{string.Join(", ", setB)}]");
        Console.WriteLine($"Set C: [{string.Join(", ", setC)}]");
        bool isEqualAB = AreSetsEqual(setA, setB);
        Console.WriteLine($"Are Set A and Set B equal? {isEqualAB}"); 
        bool isEqualAC = AreSetsEqual(setA, setC);
        Console.WriteLine($"Are Set A and Set C equal? {isEqualAC}"); 
    }
    public static bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2)
    {
        return set1.SetEquals(set2);
    }
}