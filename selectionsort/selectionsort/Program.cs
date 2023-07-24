using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace selectionsort
{
    internal class Program
    {
        public static void selectionsort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    { minIndex = j; }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }

        public static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item + "");
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        { 
        int[] arr = { 51, 11, 17, 35, 58, 46, 24, 6 };
            Console.WriteLine("print array withour sort");
            Print(arr);
            selectionsort(arr);
            Console.WriteLine("after selction sort");
            Print(arr);
            Console.ReadKey();


        }
    }
}
