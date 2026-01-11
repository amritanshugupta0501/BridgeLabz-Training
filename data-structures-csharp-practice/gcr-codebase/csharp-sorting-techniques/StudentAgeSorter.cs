using System;

public class StudentAgeSorter
{
    public static void CountingSort(int[] ages)
    {
        int minAge = 10;
        int maxAge = 18;
        int range = maxAge - minAge + 1;

        int[] count = new int[range];
        int[] output = new int[ages.Length];

        foreach (int age in ages)
        {
            count[age - minAge]++;
        }

        for (int i = 1; i < range; i++)
        {
            count[i] += count[i - 1];
        }

        for (int i = ages.Length - 1; i >= 0; i--)
        {
            int age = ages[i];
            output[count[age - minAge] - 1] = age;
            count[age - minAge]--;
        }

        Array.Copy(output, 0, ages, 0, ages.Length);
    }

    public static void PrintArray(int[] arr)
    {
        Console.Write("Sorted Student Ages: ");
        foreach (int age in arr)
        {
            Console.Write(age + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] ages = new int[n];
        Console.WriteLine("Enter the student ages (between 10 and 18):");
        for (int i = 0; i < n; i++)
        {
            ages[i] = int.Parse(Console.ReadLine());
            if (ages[i] < 10 || ages[i] > 18)
            {
                Console.WriteLine("Invalid age entered. Please enter age between 10 and 18.");
                i--;
            }
        }

        CountingSort(ages);
        PrintArray(ages);
    }
}