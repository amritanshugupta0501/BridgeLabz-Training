using System;

class SalarySorter
{
    public static void HeapSort(int[] salaries)
    {
        int n = salaries.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(salaries, n, i);
        }

        for (int i = n - 1; i > 0; i--)
        {
            int temp = salaries[0];
            salaries[0] = salaries[i];
            salaries[i] = temp;

            Heapify(salaries, i, 0);
        }
    }

    public static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
            largest = left;

        if (right < n && arr[right] > arr[largest])
            largest = right;

        if (largest != i)
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;

            Heapify(arr, n, largest);
        }
    }

    public static void PrintArray(int[] arr)
    {
        Console.Write("Sorted Salary Demands: ");
        foreach (int val in arr)
        {
            Console.Write(val + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter number of applicants: ");
        int n = int.Parse(Console.ReadLine());

        int[] salaries = new int[n];
        Console.WriteLine("Enter the salary demands:");
        for (int i = 0; i < n; i++)
        {
            salaries[i] = int.Parse(Console.ReadLine());
        }

        HeapSort(salaries);
        PrintArray(salaries);
    }
}