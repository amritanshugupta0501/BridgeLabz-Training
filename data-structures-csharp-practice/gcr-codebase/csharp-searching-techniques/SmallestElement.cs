using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.SearchingTechniques
{
    // Find smallest element in an array
    internal class SmallestElement
    {
        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int[] numbers = new int[n];
                Console.WriteLine("Enter the elements (rotated sorted):");
                for (int i = 0; i < n; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                int left = 0;
                int right = n - 1;
                while (left < right)
                {
                    int mid = left + (right - left) / 2;

                    if (numbers[mid] > numbers[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid;
                    }
                }
                Console.WriteLine("Rotation point (smallest element index): " + left);
                Console.WriteLine("Smallest element: " + numbers[left]);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
