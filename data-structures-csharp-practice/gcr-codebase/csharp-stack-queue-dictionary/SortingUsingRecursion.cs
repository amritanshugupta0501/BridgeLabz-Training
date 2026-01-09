using System;
using System.Collections.Generic;

namespace StackQueueCS
{
    public static class SortStack
    {
        public static void Sort(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int top = stack.Pop();
                Sort(stack);
                Insert(stack, top);
            }
        }

        public static void Insert(Stack<int> stack, int element)
        {
            if (stack.Count == 0 || element >= stack.Peek())
            {
                stack.Push(element);
            }
            else
            {
                int temp = stack.Pop();
                Insert(stack, element);
                stack.Push(temp);
            }
        }

        public static void PrintStack(Stack<int> stack)
        {
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                // Stack<T> doesn't support indexed access, so copy to array
            }
            var arr = stack.ToArray();
            for (int i = arr.Length - 1; i >= 0; i--) Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public static void Run()
        {
            var stack = new Stack<int>();
            stack.Push(3);
            stack.Push(1);
            stack.Push(5);
            stack.Push(2);
            stack.Push(4);

            Console.WriteLine("Original Stack:");
            PrintStack(stack);

            Sort(stack);

            Console.WriteLine("Sorted Stack:");
            PrintStack(stack);
        }
    }
}
