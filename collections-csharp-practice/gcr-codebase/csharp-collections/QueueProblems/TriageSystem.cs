using System;
using System.Collections.Generic;
public class TriageSystem
{
    public struct Patient
    {
        public string Name;
        public int Severity;
    }
    public static List<string> ProcessPatients(List<Patient> patients)
    {
        PriorityQueue<string, int> pq = new PriorityQueue<string, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        foreach (var p in patients)
        {
            pq.Enqueue(p.Name, p.Severity);
        }
        List<string> treatedOrder = new List<string>();
        while (pq.Count > 0)
        {
            treatedOrder.Add(pq.Dequeue());
        }
        return treatedOrder;
    }
    public static void Main(string[] args)
    {
        List<Patient> patients = new List<Patient>
        {
            new Patient { Name = "John", Severity = 3 },
            new Patient { Name = "Alice", Severity = 5 },
            new Patient { Name = "Bob", Severity = 2 },
            new Patient { Name = "Charlie", Severity = 4 }
        };
        Console.WriteLine("Incoming Patients:");
        foreach (var p in patients)
        {
            Console.WriteLine($"Name: {p.Name}, Severity: {p.Severity}");
        }
        List<string> treatedOrder = ProcessPatients(patients);
        Console.WriteLine("\nTreatment Order (Higher Severity First):");
        foreach (var name in treatedOrder)
        {
            Console.WriteLine(name);
        }
    }
}