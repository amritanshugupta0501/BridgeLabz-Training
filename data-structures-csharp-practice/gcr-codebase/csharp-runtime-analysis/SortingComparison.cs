using System;
using System.Diagnostics;
// Comparison of time between merge sort , quick sort and bubble sort
class SortingComparison
{
    static void Main()
    {
        SortingComparison program = new SortingComparison();
        program.Run();
    }
    void Run()
    {
        int size = 10000;
        int[] original = new int[size];
        Random rand = new Random();
        for (int i = 0; i < size; i++) 
	{
		original[i] = rand.Next();
	}
        int[] bubbleData = (int[])original.Clone();
        Stopwatch sw = Stopwatch.StartNew();
        BubbleSort(bubbleData);
        sw.Stop();
        Console.WriteLine("Bubble Sort Time: " + sw.Elapsed.TotalMilliseconds + " ms");
        int[] mergeData = (int[])original.Clone();
        sw.Restart();
        MergeSort(mergeData, 0, mergeData.Length - 1);
        sw.Stop();
        Console.WriteLine("Merge Sort Time: " + sw.Elapsed.TotalMilliseconds + " ms");
        int[] quickData = (int[])original.Clone();
        sw.Restart();
        QuickSort(quickData, 0, quickData.Length - 1);
        sw.Stop();
        Console.WriteLine("Quick Sort Time: " + sw.Elapsed.TotalMilliseconds + " ms");
    }

    void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
	{
            for (int j = 0; j < n - i - 1; j++)
	    {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
	    }
	}
    }
    void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        int[] L = new int[n1];
        int[] R = new int[n2];
        for (int i = 0; i < n1; ++i) 
	{
		L[i] = arr[left + i];
	}
        for (int j = 0; j < n2; ++j)
	{
		 R[j] = arr[mid + 1 + j];
	}
        int k = left, x = 0, y = 0;
        while (x < n1 && y < n2)
        {
            if (L[x] <= R[y]) 
	    {
		arr[k++] = L[x++];
	    }
            else
	    {
		arr[k++] = R[y++];
	    }
        }
        while (x < n1) 
	{
		arr[k++] = L[x++];
	}
        while (y < n2)
	{
		arr[k++] = R[y++];
	}
    }

    void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = (low - 1);
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;
        return i + 1;
    }
}