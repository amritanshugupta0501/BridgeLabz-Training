using System;
using System.Collections.Generic;

namespace StackQueueCS
{
    public static class StockSpan
    {
        public static int[] CalculateSpan(int[] prices)
        {
            int n = prices.Length;
            int[] span = new int[n];
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && prices[stack.Peek()] <= prices[i]) stack.Pop();
                span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());
                stack.Push(i);
            }

            return span;
        }

        public static void Run()
        {
            int[] prices = { 100, 90, 65, 70, 60, 85, 25 };
            int[] span = CalculateSpan(prices);

            Console.WriteLine("Stock Prices:");
            foreach (var price in prices) Console.Write(price + " ");
            Console.WriteLine();
            Console.WriteLine("Span Values:");
            foreach (var s in span) Console.Write(s + " ");
            Console.WriteLine();
        }
    }
}
