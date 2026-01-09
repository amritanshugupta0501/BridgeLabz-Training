using System;
using System.Collections.Generic;

namespace StackQueueCS
{
    public static class SlidingWindowMaximum
    {
        public static List<int> MaxSlidingWindow(int[] nums, int k)
        {
            var result = new List<int>();
            var deque = new LinkedList<int>(); // stores indices

            for (int i = 0; i < nums.Length; i++)
            {
                while (deque.Count > 0 && deque.First.Value <= i - k) deque.RemoveFirst();

                while (deque.Count > 0 && nums[deque.Last.Value] < nums[i]) deque.RemoveLast();

                deque.AddLast(i);

                if (i >= k - 1) result.Add(nums[deque.First.Value]);
            }

            return result;
        }

        public static void Run()
        {
            int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;
            var result = MaxSlidingWindow(arr, k);
            Console.WriteLine("Sliding Window Maximums:");
            foreach (var val in result) Console.Write(val + " ");
            Console.WriteLine();
        }
    }
}
