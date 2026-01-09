using System;
using System.Collections.Generic;

namespace StackQueueCS
{
    public static class PairWithGivenSum
    {
        public static bool HasPairWithSum(int[] arr, int target)
        {
            var seen = new HashSet<int>();

            foreach (var num in arr)
            {
                int complement = target - num;
                if (seen.Contains(complement))
                {
                    Console.WriteLine($"Pair found: ({num}, {complement})");
                    return true;
                }
                seen.Add(num);
            }

            return false;
        }

        public static void Run()
        {
            int[] arr = { 8, 4, 1, 6 };
            int target = 10;

            if (!HasPairWithSum(arr, target))
                Console.WriteLine("No pair found with sum " + target);
        }
    }
}
