using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.SearchingTechniques
{
    // Search for the first and the last occurrence of an element
    internal class FirstLastOccurrence
    {
        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[] arr = new int[n];
                Console.WriteLine("Enter the elements (sorted):");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.Write("Enter the target value: ");
                int target = int.Parse(Console.ReadLine());

                int first = -1;
                int left = 0;
                int right = n - 1;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (arr[mid] == target)
                    {
                        first = mid;
                        right = mid - 1;
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
                int last = -1;
                left = 0;
                right = n - 1;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (arr[mid] == target)
                    {
                        last = mid;
                        left = mid + 1;
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
                if (first != -1)
                {
                    Console.WriteLine($"First Occurrence: {first}");
                    Console.WriteLine($"Last Occurrence: {last}");
                }
                else
                {
                    Console.WriteLine("Element not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
