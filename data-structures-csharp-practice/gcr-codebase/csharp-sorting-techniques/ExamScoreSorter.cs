using System;

public class ExamScoreSorter
{
    public static void SelectionSort(int[] scores)
    {
        int n = scores.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = scores[minIndex];
            scores[minIndex] = scores[i];
            scores[i] = temp;
        }
    }

    public static void PrintArray(int[] arr)
    {
        Console.Write("Sorted Exam Scores: ");
        foreach (int score in arr)
        {
            Console.Write(score + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] scores = new int[n];
        Console.WriteLine("Enter the exam scores:");
        for (int i = 0; i < n; i++)
        {
            scores[i] = int.Parse(Console.ReadLine());
        }

        SelectionSort(scores);
        PrintArray(scores);
    }
}