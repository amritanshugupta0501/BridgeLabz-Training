using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.SearchingTechniques
{
    // Find peak element in the array of numbers
    internal class PeakElementInArray
    {
        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[] numbers = new int[n];
                Console.WriteLine("Enter the elements:");
                for (int i = 0; i < n; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                int left = 0;
                int right = n - 1;
                while (left < right)
                {
                    int mid = left + (right - left) / 2;

                    if (numbers[mid] > numbers[mid + 1])
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                Console.WriteLine("Peak element index: " + left);
                Console.WriteLine("Peak element value: " + numbers[left]);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
