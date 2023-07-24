﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linearsearch
{
    internal class Program
    {
        public static int linearsearch(int[] arr, int sItem)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == sItem)
                {
                    return i;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 20, 5, 15 };
            Console.WriteLine("Enter search item");
            int sItem = int.Parse(Console.ReadLine());
            int result=linearsearch(arr, sItem);
            if(result!=-1) 
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
