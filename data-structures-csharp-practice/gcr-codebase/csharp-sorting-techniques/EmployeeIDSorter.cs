using System;

public class EmployeeIDSorter
{
    public static void InsertionSort(int[] ids)
    {
        int n = ids.Length;

        for (int i = 1; i < n; i++)
        {
            int key = ids[i];
            int j = i - 1;

            while (j >= 0 && ids[j] > key)
            {
                ids[j + 1] = ids[j];
                j--;
            }

            ids[j + 1] = key;
        }
    }

    public static void PrintArray(int[] arr)
    {
        Console.Write("Sorted Employee IDs: ");
        foreach (int id in arr)
        {
            Console.Write(id + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter number of employees: ");
        int n = int.Parse(Console.ReadLine());

        int[] employeeIds = new int[n];
        Console.WriteLine("Enter the Employee IDs:");
        for (int i = 0; i < n; i++)
        {
            employeeIds[i] = int.Parse(Console.ReadLine());
        }

        InsertionSort(employeeIds);
        PrintArray(employeeIds);
    }
}