using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertionsort
{
    internal class Program
    {
        public static void insertionsort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
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
        public static void Print(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]+ " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 12,5,36,84,21,46,};
            Console.WriteLine("Print array without sort");
            Print(arr);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            insertionsort(arr);
            stopwatch.Stop();
            Console.WriteLine("after insertion sort");
            Print(arr);
            Console.WriteLine($"array size {arr.Length} time taken {stopwatch.Elapsed.TotalMilliseconds }");
            Console.ReadKey();
        }
    }
}

