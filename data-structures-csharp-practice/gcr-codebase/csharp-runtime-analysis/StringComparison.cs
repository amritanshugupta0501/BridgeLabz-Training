using System;
using System.Diagnostics;
using System.Text;
// Comparison between concatenation of two texts using string class and string builder class
class StringComparison
{
    static void Main()
    {
        StringComparison program = new StringComparison();
        program.Run();
    }
    void Run()
    {
        int iterations = 10000;
        Stopwatch sw = Stopwatch.StartNew();
        string s = "";
        for (int i = 0; i < iterations; i++)
        {
            s += "test";
        }
        sw.Stop();
        Console.WriteLine("String Concatenation Time: " + sw.Elapsed.TotalMilliseconds + " ms");
        sw.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append("test");
        }
        sw.Stop();
        Console.WriteLine("StringBuilder Time: " + sw.Elapsed.TotalMilliseconds + " ms");
    }
}