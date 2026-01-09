using System;
using System.Collections.Generic;

namespace StackQueueCS
{
    public static class TwoSum
    {
        public static int[] TwoSumMethod(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement)) return new int[] { map[complement], i };
                if (!map.ContainsKey(nums[i])) map[nums[i]] = i;
            }
            return new int[] { };
        }

        public static void Run()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            var result = TwoSumMethod(nums, target);
            if (result.Length == 2) Console.WriteLine("Indices: " + result[0] + ", " + result[1]);
            else Console.WriteLine("No solution found.");
        }
    }
}
