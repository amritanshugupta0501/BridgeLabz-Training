using System;
using System.Diagnostics;
// Comparison between linear and binary search timing
class SearchComparison
{
    static void Main()
    {
        SearchComparison program = new SearchComparison();
        program.Run();
    }
    void Run()
    {
        int size = 1000000;
        int[] data = new int[size];
        for (int i = 0; i < size; i++) 
	{
		data[i] = i;
	}
        int target = size - 1;
        Stopwatch sw = Stopwatch.StartNew();
        LinearSearch(data, target);
        sw.Stop();
        Console.WriteLine("Linear Search Time: " + sw.Elapsed.TotalMilliseconds + " ms");
        sw.Restart();
        BinarySearch(data, target);
        sw.Stop();
        Console.WriteLine("Binary Search Time: " + sw.Elapsed.TotalMilliseconds + " ms");
    }
    int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target) return i;
        }
        return -1;
    }
    int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
	    {
                return mid;
	    }
            if (arr[mid] < target)
	    {
                left = mid + 1;
	    }
            else
	    {
                right = mid - 1;
	    }
        }
        return -1;
    }
}