using System;
using System.Collections.Generic;
public class BinaryGenerator
{
    public static List<string> GenerateBinary(int n)
    {
        List<string> result = new List<string>();
        Queue<string> queue = new Queue<string>();
        // Start with the first binary number
        queue.Enqueue("1");
        for (int i = 0; i < n; i++)
        {
            // Remove the current front of the queue
            string current = queue.Dequeue();
            result.Add(current);
            // Generate the next two numbers by appending 0 and 1
            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }
        return result;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        // Define how many binary numbers to generate
        int n = 10;
        Console.WriteLine($"Generating the first {n} binary numbers:");
        List<string> binaryNumbers = BinaryGenerator.GenerateBinary(n);
        // Print the result to the console
        foreach (string binary in binaryNumbers)
        {
            Console.WriteLine(binary);
        }
        // Keep console open (optional, depending on your IDE)
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}