using System;
using System.Collections.Generic;

namespace StackQueueCS
{
    public class ImplementingQueue
    {
        private Stack<int> stack = new Stack<int>();

        public void Enqueue(int num)
        {
            int count = stack.Count + 1;
            stack.Push(num);

            if (count > 1)
            {
                var arr = new int[count];
                int pos = 0;
                while (stack.Count > 0)
                {
                    arr[pos++] = stack.Pop();
                }

                for (int i = 1; i < arr.Length; i++)
                {
                    int number = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = number;
                }

                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    stack.Push(arr[i]);
                }
            }
        }

        public void DisplayElements()
        {
            var tempStack = new Stack<int>();
            var printStack = new Stack<int>();

            while (stack.Count > 0)
            {
                int element = stack.Pop();
                tempStack.Push(element);
            }

            while (tempStack.Count > 0)
            {
                int element = tempStack.Pop();
                stack.Push(element);
                printStack.Push(element);
            }

            while (printStack.Count > 0)
            {
                Console.WriteLine(printStack.Pop());
            }
        }

        public void Dequeue()
        {
            if (stack.Count > 0)
            {
                stack.Pop();
            }
            else
            {
                Console.WriteLine("Queue is empty.");
            }
        }

        public static void Run()
        {
            var implement = new ImplementingQueue();
            implement.Enqueue(2);
            implement.Enqueue(6);
            implement.Enqueue(5);
            implement.Enqueue(4);
            implement.Enqueue(3);
            implement.Enqueue(1);

            Console.WriteLine("Original Queue:");
            implement.DisplayElements();

            implement.Dequeue();
            implement.Dequeue();

            Console.WriteLine("Queue After Dequeue:");
            implement.DisplayElements();
        }
    }
}
