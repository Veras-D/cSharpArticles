using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 5, 2, 9, 1, 5, 6 };

        Console.WriteLine("Original array:");
        PrintArray(array);

        BubbleSortOptimized(array);

        Console.WriteLine("Sorted array:");
        PrintArray(array);
    }

    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
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

    public static void BubbleSortOptimized(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }

    public static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}
