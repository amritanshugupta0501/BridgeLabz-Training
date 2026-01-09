using System;
using System.Collections.Generic;

namespace StackQueueCS
{
    public static class LongestConsecutiveSequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            var numSet = new HashSet<int>(nums);
            int maxLength = 0;

            foreach (var num in nums)
            {
                if (!numSet.Contains(num - 1))
                {
                    int currentNum = num;
                    int length = 1;

                    while (numSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        length++;
                    }

                    maxLength = Math.Max(maxLength, length);
                }
            }

            return maxLength;
        }

        public static void Run()
        {
            int[] arr = { 100, 4, 200, 1, 3, 2 };
            int result = LongestConsecutive(arr);
            Console.WriteLine("Length of longest consecutive sequence: " + result);
        }
    }
}
