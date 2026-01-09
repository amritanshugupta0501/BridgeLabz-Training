using System;
using System.Collections.Generic;

namespace StackQueueCS
{
    public static class ZeroSumSubarrays
    {
        public static List<(int start, int end)> FindZeroSumSubarrays(int[] arr)
        {
            var sumIndexMap = new Dictionary<int, List<int>>();
            var result = new List<(int, int)>();
            int sum = 0;

            sumIndexMap[0] = new List<int> { -1 };

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (sumIndexMap.ContainsKey(sum))
                {
                    foreach (var startIndex in sumIndexMap[sum])
                    {
                        result.Add((startIndex + 1, i));
                    }
                }

                if (!sumIndexMap.ContainsKey(sum)) sumIndexMap[sum] = new List<int>();
                sumIndexMap[sum].Add(i);
            }

            return result;
        }

        public static void Run()
        {
            int[] arr = { 3, 4, -7, 1, 3, -4, -2, -2 };
            var subarrays = FindZeroSumSubarrays(arr);
            Console.WriteLine("Zero-sum subarrays:");
            foreach (var range in subarrays)
            {
                Console.WriteLine($"From index {range.start} to {range.end}");
            }
        }
    }
}
