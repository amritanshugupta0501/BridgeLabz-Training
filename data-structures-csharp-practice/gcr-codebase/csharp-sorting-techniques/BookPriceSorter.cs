using System;

public class BookPriceSorter
{
    public static void MergeSort(double[] prices, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            MergeSort(prices, left, mid);
            MergeSort(prices, mid + 1, right);

            Merge(prices, left, mid, right);
        }
    }

    public static void Merge(double[] prices, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        double[] leftArr = new double[n1];
        double[] rightArr = new double[n2];

        for (int x = 0; x < n1; x++)
            leftArr[x] = prices[left + x];
        for (int y = 0; y < n2; y++)
            rightArr[y] = prices[mid + 1 + y];

        int i = 0, j = 0, k = left;

        while (i < n1 && j < n2)
        {
            if (leftArr[i] <= rightArr[j])
            {
                prices[k++] = leftArr[i++];
            }
            else
            {
                prices[k++] = rightArr[j++];
            }
        }

        while (i < n1)
        {
            prices[k++] = leftArr[i++];
        }

        while (j < n2)
        {
            prices[k++] = rightArr[j++];
        }
    }

    public static void PrintArray(double[] arr)
    {
        Console.Write("Sorted Book Prices: ");
        foreach (double price in arr)
        {
            Console.Write(price + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter number of books: ");
        int n = int.Parse(Console.ReadLine());

        double[] prices = new double[n];
        Console.WriteLine("Enter the book prices:");
        for (int i = 0; i < n; i++)
        {
            prices[i] = double.Parse(Console.ReadLine());
        }

        MergeSort(prices, 0, n - 1);
        PrintArray(prices);
    }
}