using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.SearchingTechniques
{
    // Find the first missing positive integer using linear search and target index using binary search
    internal class PositiveMissingIntegerAndTargetIndex
    {
        static void Main()
        {
            Console.Write("Enter the number of elements: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[] arr = new int[n];
                Console.WriteLine("Enter the elements:");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                int[] arrForMissing = (int[])arr.Clone();
                int missing = FindFirstMissingPositive(arrForMissing);
                Console.WriteLine("First missing positive integer: " + missing);
                Console.Write("Enter target to search: ");
                int target = int.Parse(Console.ReadLine());
                Array.Sort(arr);
                Console.WriteLine("Sorted Array: " + string.Join(", ", arr));
                int resultIndex = BinarySearch(arr, target);
                if (resultIndex != -1)
                {
                    Console.WriteLine("Target found at index (in sorted array): " + resultIndex);
                }
                else
                {
                    Console.WriteLine("Target not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        static int FindFirstMissingPositive(int[] nums)
        {
            int n = nums.Length;
            bool containsOne = false;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] == 1)
                {
                    containsOne = true;
                    break;
                }
            }
            if (!containsOne) return 1;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] <= 0 || nums[i] > n)
                {
                    nums[i] = 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0)
                {
                    nums[index] = -nums[index];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (nums[i] > 0)
                {
                    return i + 1;
                }
            }
            return n + 1;
        }
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}
