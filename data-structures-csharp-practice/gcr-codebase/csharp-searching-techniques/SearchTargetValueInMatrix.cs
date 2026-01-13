using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.SearchingTechniques
{
    // Search for a target value in a 2-D Matrix
    internal class SearchTargetValueInMatrix
    {
        static void Main()
        {
            Console.Write("Enter number of rows: ");
            if (int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
            {
                Console.Write("Enter number of columns: ");
                if (int.TryParse(Console.ReadLine(), out int cols) && cols > 0)
                {
                    int[,] matrix = new int[rows, cols];
                    Console.WriteLine("Enter the elements (sorted row by row):");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            matrix[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    Console.Write("Enter the target value to search: ");
                    int target = int.Parse(Console.ReadLine());
                    int left = 0;
                    int right = rows * cols - 1;
                    bool found = false;
                    while (left <= right)
                    {
                        int mid = left + (right - left) / 2;
                        int midValue = matrix[mid / cols, mid % cols];
                        if (midValue == target)
                        {
                            Console.WriteLine($"Found at Row: {mid / cols}, Column: {mid % cols}");
                            found = true;
                            break;
                        }
                        else if (midValue < target)
                        {
                            left = mid + 1;
                        }
                        else
                        {
                            right = mid - 1;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Target not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid column input.");
                }
            }
            else
            {
                Console.WriteLine("Invalid row input.");
            }
        }
    }
}
