using System;
using System.Collections.Generic;
using System.Linq;
public class SetSorter
{
    public static List<int> SortSet(HashSet<int> inputSet)
    {
        List<int> sortedList = inputSet.ToList();
        sortedList.Sort();
        return sortedList;
    }
    public static void Main(string[] args)
    {
        HashSet<int> mySet = new HashSet<int> { 45, 10, 5, 99, 23 };
        Console.WriteLine("Original Set items (order is not guaranteed):");
        foreach (int item in mySet)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n");
        List<int> result = SortSet(mySet);
        Console.WriteLine("Sorted List items:");
        foreach (int item in result)
        {
            Console.Write(item + " ");
        } 
    }
}