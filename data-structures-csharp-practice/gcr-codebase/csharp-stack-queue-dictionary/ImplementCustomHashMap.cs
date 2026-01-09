using System;
using System.Text;

namespace StackQueueCS
{
    public class CustomHashMap
    {
        private class Node
        {
            public int Key;
            public int Value;
            public Node Next;

            public Node(int key, int value)
            {
                Key = key;
                Value = value;
            }
        }

        private readonly int SIZE = 1000;
        private readonly Node[] buckets;

        public CustomHashMap()
        {
            buckets = new Node[SIZE];
        }

        private int GetBucketIndex(int key)
        {
            return (key.GetHashCode() & 0x7fffffff) % SIZE;
        }

        public void Put(int key, int value)
        {
            int index = GetBucketIndex(key);
            var head = buckets[index];

            for (var curr = head; curr != null; curr = curr.Next)
            {
                if (curr.Key == key)
                {
                    curr.Value = value;
                    return;
                }
            }

            var newNode = new Node(key, value) { Next = head };
            buckets[index] = newNode;
        }

        public int Get(int key)
        {
            int index = GetBucketIndex(key);
            var curr = buckets[index];

            while (curr != null)
            {
                if (curr.Key == key) return curr.Value;
                curr = curr.Next;
            }

            return -1;
        }

        public void Remove(int key)
        {
            int index = GetBucketIndex(key);
            var curr = buckets[index];
            Node prev = null;

            while (curr != null)
            {
                if (curr.Key == key)
                {
                    if (prev == null) buckets[index] = curr.Next;
                    else prev.Next = curr.Next;
                    return;
                }
                prev = curr;
                curr = curr.Next;
            }
        }

        public void PrintMap()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < SIZE; i++)
            {
                var curr = buckets[i];
                if (curr != null)
                {
                    sb.Append("Bucket ").Append(i).Append(": ");
                    while (curr != null)
                    {
                        sb.Append("[").Append(curr.Key).Append("->").Append(curr.Value).Append("] ");
                        curr = curr.Next;
                    }
                    sb.AppendLine();
                }
            }
            Console.Write(sb.ToString());
        }

        public static void Run()
        {
            var map = new CustomHashMap();
            map.Put(1, 10);
            map.Put(2, 20);
            map.Put(1001, 30);

            Console.WriteLine("Get 1: " + map.Get(1));
            Console.WriteLine("Get 2: " + map.Get(2));
            Console.WriteLine("Get 3: " + map.Get(3));

            map.Remove(2);
            Console.WriteLine("After removing 2, Get 2: " + map.Get(2));

            map.PrintMap();
        }
    }
}
