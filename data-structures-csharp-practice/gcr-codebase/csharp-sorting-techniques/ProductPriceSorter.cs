using System;

public class ProductPriceSorter
{
    public static void QuickSort(double[] prices, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(prices, low, high);
            QuickSort(prices, low, pivotIndex - 1);
            QuickSort(prices, pivotIndex + 1, high);
        }
    }

    public static int Partition(double[] prices, int low, int high)
    {
        double pivot = prices[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (prices[j] <= pivot)
            {
                i++;
                double temp = prices[i];
                prices[i] = prices[j];
                prices[j] = temp;
            }
        }

        double temp2 = prices[i + 1];
        prices[i + 1] = prices[high];
        prices[high] = temp2;

        return i + 1;
    }

    public static void PrintArray(double[] arr)
    {
        Console.Write("Sorted Product Prices: ");
        foreach (double price in arr)
        {
            Console.Write(price + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter number of products: ");
        int n = int.Parse(Console.ReadLine());

        double[] prices = new double[n];
        Console.WriteLine("Enter the product prices:");
        for (int i = 0; i < n; i++)
        {
            prices[i] = double.Parse(Console.ReadLine());
        }

        QuickSort(prices, 0, n - 1);
        PrintArray(prices);
    }
}