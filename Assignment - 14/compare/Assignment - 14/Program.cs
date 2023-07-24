using System;
using System.Diagnostics;

class SortingAlgorithms
{
    static void Main()
    {
        int[] arraySizes = { 100, 500, 5000, 10000 };

        foreach (int size in arraySizes)
        {
            int[] arrBubbleSort = GenerateRandomArray(size);
            int[] arrInsertionSort = (int[])arrBubbleSort.Clone();

            Console.WriteLine($"Array size: {size}");

            // Bubble Sort
            Stopwatch bubbleSortStopwatch = new Stopwatch();
            bubbleSortStopwatch.Start();
            BubbleSortAlgorithm(arrBubbleSort);
            bubbleSortStopwatch.Stop();
            Console.WriteLine($"Bubble Sort - Time taken: {bubbleSortStopwatch.Elapsed.TotalMilliseconds} ms");

            // Insertion Sort
            Stopwatch insertionSortStopwatch = new Stopwatch();
            insertionSortStopwatch.Start();
            InsertionSortAlgorithm(arrInsertionSort);
            insertionSortStopwatch.Stop();
            Console.WriteLine($"Insertion Sort - Time taken: {insertionSortStopwatch.Elapsed.TotalMilliseconds} ms");

            Console.WriteLine();
        }
    }

    static void BubbleSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
           
            if (!swapped)
                break;
        }
    }

    static void InsertionSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(1000); 
        }
        return arr;
    }
}
