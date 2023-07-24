using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearch
{
    internal class Program
    {
        public static int binarysearch(int[] arr, int sItem)
        {
            int left = 0;
            int right = arr.Length - 1;
            while(left<=right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid]==sItem)
                {
                    return mid;
                }
                else if (arr[mid]<sItem)
                {
                    left = mid+ 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
        
                int[] arr = { 5, 10, 15, 20, 30, 35 };
                Console.WriteLine("Enter search item");
                int sItem = int.Parse(Console.ReadLine());
                int result = binarysearch(arr, sItem);
                if (result != -1)
                {
                    Console.WriteLine($"{sItem} found at index {result}");

                }
                else
                {
                    Console.WriteLine($"{sItem} not found");
                }
                Console.ReadKey();
            }
        }
    }


