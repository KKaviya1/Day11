using System;

class BubbleSort
{
    static void Main()
    {
        int[] arr = GenerateRandomArray(5);
        Console.WriteLine("Original array:");
        PrintArray(arr);


        BubbleSortAlgorithm(arr);

        Console.WriteLine("\nSorted array:");
        PrintArray(arr);
    }

    static int[] GenerateRandomArray(int size, int minValue = 0, int maxValue = 100)
    {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(minValue, maxValue);
        }
        return arr;
    }

    static void BubbleSortAlgorithm(int[] arr)
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

    static bool IsArraySorted(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[i - 1])
                return false;
        }
        return true;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

    }
}
    
