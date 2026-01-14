using System;
using System.Diagnostics;
// Comaprison between Fibonacci using recursion and Fibonacci using iteration of loops
class FibonacciComparison
{
    static void Main()
    {
        FibonacciComparison program = new FibonacciComparison();
        program.Run();
    }
    void Run()
    {
        int n = 35;
        Stopwatch sw = Stopwatch.StartNew();
        FibonacciRecursive(n);
        sw.Stop();
        Console.WriteLine("Recursive Fibonacci Time: " + sw.Elapsed.TotalMilliseconds + " ms");
        sw.Restart();
        FibonacciIterative(n);
        sw.Stop();
        Console.WriteLine("Iterative Fibonacci Time: " + sw.Elapsed.TotalMilliseconds + " ms");
    }
    int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }
    int FibonacciIterative(int n)
    {
        int a = 0, b = 1, sum;
        if (n == 0) return a;
        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}