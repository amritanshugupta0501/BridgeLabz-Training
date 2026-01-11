using System;

public class StudentMarksSorter
{
    public static void BubbleSort(int[] marks)
    {
        int n = marks.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - 1 - i; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
    }

    public static void PrintArray(int[] arr)
    {
        Console.Write("Sorted Marks: ");
        foreach (int mark in arr)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] marks = new int[n];
        Console.WriteLine("Enter the marks of " + n + " students:");
        for (int i = 0; i < n; i++)
        {
            marks[i] = int.Parse(Console.ReadLine());
        }

        BubbleSort(marks);
        PrintArray(marks);
    }
}