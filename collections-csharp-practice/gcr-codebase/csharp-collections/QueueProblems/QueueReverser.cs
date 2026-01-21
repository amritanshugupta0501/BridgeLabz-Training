using System;
using System.Collections.Generic;
public class QueueReverser
{
    public static Queue<int> ReverseQueue(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>();
        while (queue.Count > 0)
        {
            stack.Push(queue.Dequeue());
        }
        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }
        return queue;
    }
    public static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        queue.Enqueue(50);
        Console.WriteLine("Original Queue:");
        foreach (int item in queue)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        ReverseQueue(queue);
        Console.WriteLine("Reversed Queue:");
        foreach (int item in queue)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}